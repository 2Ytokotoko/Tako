using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using DG.Tweening;

public class ClickGuzai2 : MonoBehaviour
{
    [SerializeField, Tooltip("具材を持ち上げて放すスクリプト")]
    public GameObject Mokutekiti;
    public GameObject Player;
    public GameObject Tako;
    public Camera Camera;
    private NavMeshObstacle Block;
    public float Distance;
    [SerializeField, Tooltip("標的のオブジェクトをここに割り当てる")]
    private GameObject TargetObject;
    public GameObject Guzai;
    public GameObject Hanasuiti;
    float PosX;
    float PosY;
    float PosZ;
    float MPosX;
    float MPosY;
    float MPosZ;
    float HPosX;
    float HPosY;
    float HPosZ;
    [SerializeField, Tooltip("ブロックの真上")]
    private float Maue;
    [SerializeField, Tooltip("頭上の位置")]
    private float Zujou;
    // Start is called before the first frame update
    void Start()
    {
        Block = GetComponent<NavMeshObstacle>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Mokutekiti.transform.position == Player.transform.position && Input.GetMouseButtonDown(0) && Player.GetComponent<PlayerMove>().Lift == false)
        {
            Ray ray = Camera.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                //具材を選択、具材を運ぶ位置に移動
                if (hit.collider.gameObject.tag == "Bento")
                {
                    TargetObject = hit.collider.gameObject;
                    Player.GetComponent<PlayerMove>().Lift = true;
                    Player.GetComponent<PlayerMove>().Guzai = null;
                    transform.parent = Tako.transform;

                    PosX = transform.position.x;
                    PosY = transform.position.y;
                    PosZ = transform.position.z;
                    MPosX = Mokutekiti.transform.position.x;
                    MPosY = Mokutekiti.transform.position.y;
                    MPosZ = Mokutekiti.transform.position.z;

                    Vector3[] path =
                    {
                        new Vector3(PosX, PosY,PosZ),
                        new Vector3(PosX,PosY + Maue,PosZ),
                        new Vector3(MPosX,MPosY + Zujou,MPosZ),
                    };

                    //持ち上げる
                    gameObject.transform.DOPath(path, 1.0f, PathType.CatmullRom).SetEase(Ease.Linear);
                }
            }
        }

        if (Player.GetComponent<PlayerMove>().Lift == true && transform.parent != null && Input.GetMouseButtonDown(1))
        {
            transform.parent = null;
            PosX = transform.position.x;
            PosY = transform.position.y;
            PosZ = transform.position.z;
            HPosX = Hanasuiti.transform.position.x;
            HPosY = Hanasuiti.transform.position.y;
            HPosZ = Hanasuiti.transform.position.z;

            Vector3[] path =
            {
                        new Vector3(PosX, PosY, PosZ),
                        new Vector3(HPosX, HPosY + Maue ,HPosZ),
                        new Vector3(HPosX, HPosY ,HPosZ),
            };

            //降ろす
            gameObject.transform.DOPath(path, 1.0f, PathType.CatmullRom).SetEase(Ease.Linear);
        }
    }

    public void GuzaiSentaku()
    {
        Player.GetComponent<PlayerMove>().Mokutekiti = Mokutekiti;
    }
}
