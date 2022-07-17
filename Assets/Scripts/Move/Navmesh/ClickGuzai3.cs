using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using DG.Tweening;

public class ClickGuzai3 : MonoBehaviour
{
    [SerializeField, Tooltip("��ނ��ړ�������X�N���v�g")]

    public GameObject Mokutekiti;
    public GameObject Player;
    public Camera Camera;
    public float Distance;
    [SerializeField, Tooltip("���Ƃ������ꏊ�����蓖�Ă�i���v���O������Łj")]
    private GameObject TargetObject;
    float PosX;
    float PosY;
    float PosZ;
    float MPosX;
    float MPosY;
    float MPosZ;
    float RPosX;
    float RPosY;
    float RPosZ;
    public PlayerMove playerMove;
    public string Tag;
    bool Kaiten = false;
    float Wheel;
    NavMeshObstacle Block;
    public GameObject Modori;
    // Start is called before the first frame update
    void Start()
    {
        Block = GetComponent<NavMeshObstacle>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Mokutekiti.transform.position == Player.transform.position && playerMove.Lift == false && gameObject.tag != "Finish")
        {
            Wheel = Input.GetAxis("Mouse ScrollWheel");

            if(Wheel > 0 && !Kaiten)
            {
                Kaiten = true;
                Block.carving = false;
                Mokutekiti.transform.parent = null;
                StartCoroutine("HidariKaiten");
            }

            else if(Wheel < 0 && !Kaiten)
            {
                Kaiten = true;
                Block.carving = false;
                Mokutekiti.transform.parent = null;
                StartCoroutine("MigiKaiten");
            }

            if (Input.GetMouseButtonDown(0))
            {
                Ray ray = Camera.ScreenPointToRay(Input.mousePosition);
                RaycastHit hit;

                if (Physics.Raycast(ray, out hit))
                {
                    //��ނ�I���A��ނ��^�Ԉʒu�Ɉړ�
                    if (hit.collider.gameObject.tag == Tag)
                    {
                        TargetObject = hit.collider.gameObject;
                        Modori.transform.parent = null;
                        playerMove.Lift = true;
                        playerMove.Guzai = null;

                        PosX = transform.position.x;
                        PosY = transform.position.y;
                        PosZ = transform.position.z;
                        MPosX = TargetObject.transform.position.x;
                        MPosY = TargetObject.transform.position.y;
                        MPosZ = TargetObject.transform.position.z;

                        Vector3[] path =
                        {
                        new Vector3(PosX, PosY,PosZ),
                        new Vector3(PosX, PosY + 10f, PosZ),
                        new Vector3(MPosX,MPosY + 10f,MPosZ),
                        };

                        //�����グ��
                        gameObject.transform.DOPath(path, 1.0f, PathType.CatmullRom).SetEase(Ease.Linear);
                        gameObject.tag = "Finish";
                        Invoke("ReLift", 1.0f);
                    }

                    if (gameObject.tag == "Finish" && hit.collider.gameObject.tag == "Finish")
                    {
                        PosX = transform.position.x;
                        PosY = transform.position.y;
                        PosZ = transform.position.z;
                        RPosX = Modori.transform.position.x;
                        RPosY = Modori.transform.position.y;
                        RPosZ = Modori.transform.position.z;

                        Vector3[] path =
                        {
                        new Vector3(PosX, PosY,PosZ),
                        new Vector3(PosX, PosY + 10f, PosZ),
                        new Vector3(RPosX,RPosY + 10f,RPosZ),
                         };

                        //�����グ��
                        gameObject.transform.DOPath(path, 1.0f, PathType.CatmullRom).SetEase(Ease.Linear);
                        gameObject.tag = Tag;
                    }
                }
            }
        }
    }

    //�ړI�n��ݒ�
    public void GuzaiSentaku()
    {
        playerMove.Mokutekiti = Mokutekiti;
    }

    void ReLift()
    {
        playerMove.Lift = false;
    }

    public void Modoru()
    {
        Debug.Log("�N���b�N���ꂽ");
        if(gameObject.tag == "Finish")
        {
            PosX = transform.position.x;
            PosY = transform.position.y;
            PosZ = transform.position.z;
            RPosX = Modori.transform.position.x;
            RPosY = Modori.transform.position.y;
            RPosZ = Modori.transform.position.z;

            Vector3[] path =
            {
                        new Vector3(PosX, PosY,PosZ),
                        new Vector3(PosX, PosY + 10f, PosZ),
                        new Vector3(RPosX,RPosY + 10f,RPosZ),
             };

            //���̏ꏊ�ɖ߂�
            gameObject.transform.DOPath(path, 1.0f, PathType.CatmullRom).SetEase(Ease.Linear);
            gameObject.tag = Tag;
        }
    }

    IEnumerator HidariKaiten()
    {
        for(int turn = 0; turn < 10; turn++)
        {
            transform.Rotate(0, -9, 0);
            yield return new WaitForSeconds(0.01f);
        }
        Kaiten = false;
        Block.carving = true;
        Mokutekiti.transform.parent = gameObject.transform;
    }

    IEnumerator MigiKaiten()
    {
        for (int turn = 0; turn < 10; turn++)
        {
            transform.Rotate(0, 9, 0);
            yield return new WaitForSeconds(0.01f);
        }
        Kaiten = false;
        Block.carving = true;
        Mokutekiti.transform.parent = gameObject.transform;
    }
}
