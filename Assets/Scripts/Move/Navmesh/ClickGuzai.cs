using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ClickGuzai : MonoBehaviour
{
    [SerializeField, Tooltip("具材を投げるスクリプト")]
    public GameObject Mokutekiti;
    public GameObject Player;
    public Camera Camera;
    private NavMeshObstacle Block;
    public float Distance;

    [SerializeField, Tooltip("射出するオブジェクトをここに割り当てる")]
    private GameObject ThrowingObject;

    [SerializeField, Tooltip("標的のオブジェクトをここに割り当てる")]
    private GameObject TargetObject;

    [SerializeField, Range(0F, 90F), Tooltip("射出する角度")]
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
                //具材を選択、具材を運ぶ位置に移動
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
            // 標的の座標
            Vector3 targetPosition = TargetObject.transform.position;

            // 射出角度
            float angle = ThrowingAngle;

            // 射出速度を算出
            Vector3 velocity = CalculateVelocity(this.transform.position, targetPosition, angle);

            // 射出
            Rigidbody rid =ThrowingObject.GetComponent<Rigidbody>();
            rid.AddForce(velocity * rid.mass, ForceMode.Impulse);
        }
        else
        {
            throw new System.Exception("射出するオブジェクトまたは標的のオブジェクトが未設定です。");
        }
    }

    /// <param name="pointA">射出開始座標</param>
    /// <param name="pointB">標的の座標</param>
    private Vector3 CalculateVelocity(Vector3 pointA, Vector3 pointB, float angle)
    {
        // 射出角をラジアンに変換
        float rad = angle * Mathf.PI / 180;

        // 水平方向の距離x
        float x = Vector2.Distance(new Vector2(pointA.x, pointA.z), new Vector2(pointB.x, pointB.z));

        // 垂直方向の距離y
        float y = pointA.y - pointB.y;

        // 斜方投射の公式を初速度について解く
        float speed = Mathf.Sqrt(-Physics.gravity.y * Mathf.Pow(x, 2) / (2 * Mathf.Pow(Mathf.Cos(rad), 2) * (x * Mathf.Tan(rad) + y)));

        if (float.IsNaN(speed))
        {
            // 条件を満たす初速を算出できなければVector3.zeroを返す
            return Vector3.zero;
        }
        else
        {
            return (new Vector3(pointB.x - pointA.x, x * Mathf.Tan(rad), pointB.z - pointA.z).normalized * speed);
        }
    }
}
