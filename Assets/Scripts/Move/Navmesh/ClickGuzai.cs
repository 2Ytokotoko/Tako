using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ClickGuzai : MonoBehaviour
{
    [SerializeField, Tooltip("��ނ𓊂���X�N���v�g")]
    public GameObject Mokutekiti;
    public GameObject Player;
    public Camera Camera;
    private NavMeshObstacle Block;
    public float Distance;

    [SerializeField, Tooltip("�ˏo����I�u�W�F�N�g�������Ɋ��蓖�Ă�")]
    private GameObject ThrowingObject;

    [SerializeField, Tooltip("�W�I�̃I�u�W�F�N�g�������Ɋ��蓖�Ă�")]
    private GameObject TargetObject;

    [SerializeField, Range(0F, 90F), Tooltip("�ˏo����p�x")]
    private float ThrowingAngle;
    // Start is called before the first frame update
    void Start()
    {
        Block = GetComponent<NavMeshObstacle>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Mokutekiti == Player.GetComponent<PlayerMove>().Mokutekiti)
        {
            Distance = Vector3.Distance(Player.transform.position, Mokutekiti.transform.position);
            if (Distance <= 0.5f)
            {
                Block.carving = false;
            }
        }

        if(Mokutekiti != Player.GetComponent<PlayerMove>().Mokutekiti && TargetObject == null)
        {
            Block.carving = true;
        }

        if(Mokutekiti.transform.position == Player.transform.position && Input.GetMouseButtonDown(0) && TargetObject == null)
        {
            Ray ray = Camera.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                //��ނ�I���A��ނ��^�Ԉʒu�Ɉړ�
                if (hit.collider.gameObject.tag == "Bento")
                {
                    TargetObject = hit.collider.gameObject;
                    ThrowingBall();
                }
            }
        }

        if(TargetObject != null)
        {
            Block.carving = false;
        }
    }

    public void GuzaiSentaku()
    {
        Player.GetComponent<PlayerMove>().Mokutekiti = Mokutekiti;
    }

    private void ThrowingBall()
    {
        if (ThrowingObject != null)
        {
            // �W�I�̍��W
            Vector3 targetPosition = TargetObject.transform.position;

            // �ˏo�p�x
            float angle = ThrowingAngle;

            // �ˏo���x���Z�o
            Vector3 velocity = CalculateVelocity(this.transform.position, targetPosition, angle);

            // �ˏo
            Rigidbody rid =ThrowingObject.GetComponent<Rigidbody>();
            rid.AddForce(velocity * rid.mass, ForceMode.Impulse);
        }
        else
        {
            throw new System.Exception("�ˏo����I�u�W�F�N�g�܂��͕W�I�̃I�u�W�F�N�g�����ݒ�ł��B");
        }
    }

    /// <param name="pointA">�ˏo�J�n���W</param>
    /// <param name="pointB">�W�I�̍��W</param>
    private Vector3 CalculateVelocity(Vector3 pointA, Vector3 pointB, float angle)
    {
        // �ˏo�p�����W�A���ɕϊ�
        float rad = angle * Mathf.PI / 180;

        // ���������̋���x
        float x = Vector2.Distance(new Vector2(pointA.x, pointA.z), new Vector2(pointB.x, pointB.z));

        // ���������̋���y
        float y = pointA.y - pointB.y;

        // �Ε����˂̌����������x�ɂ��ĉ���
        float speed = Mathf.Sqrt(-Physics.gravity.y * Mathf.Pow(x, 2) / (2 * Mathf.Pow(Mathf.Cos(rad), 2) * (x * Mathf.Tan(rad) + y)));

        if (float.IsNaN(speed))
        {
            // �����𖞂����������Z�o�ł��Ȃ����Vector3.zero��Ԃ�
            return Vector3.zero;
        }
        else
        {
            return (new Vector3(pointB.x - pointA.x, x * Mathf.Tan(rad), pointB.z - pointA.z).normalized * speed);
        }
    }
}
