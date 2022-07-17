using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using DG.Tweening;

public class PlayerMove : MonoBehaviour
{
    private NavMeshAgent Player;
    public GameObject Mokutekiti;
    public GameObject Tako;
    public GameObject Guzai;
    public Camera Camera;
    public bool Lift = false;
    public bool winner = false;
    float PosX;
    float PosY;
    float PosZ;
    float MPosX;
    float MPosY;
    float MPosZ;
    public GameObject Goal;
    public string tag;
    // Start is called before the first frame update
    void Start()
    {
        Player = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Mokutekiti != null)
        {
            //�ړI�n�ɒ����Ă��Ȃ�������
            if (transform.position != Mokutekiti.transform.position)
            {
                Player.Resume();
                Player.destination = Mokutekiti.transform.position;
            }

            //�ړI�n�ɒ�������
            if (transform.position == Mokutekiti.transform.position)
            {
                Player.Stop();
                Mokutekiti = null;
                //Guzai = null;
            }
        }

        //��ނ�I��ł�����
        if (Guzai != null)
        {
            Face();
        }

        if (Input.GetMouseButtonDown(0) && Lift == false)
        {
            Ray ray = Camera.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                //��ނ�I���A��ނ��^�Ԉʒu�Ɉړ�
                if (hit.collider.gameObject.tag == "Guzai")
                {
                    winner = false;
                    Guzai = hit.collider.gameObject;
                    hit.collider.gameObject.GetComponent<ClickGuzai3>().GuzaiSentaku();
                }

                //�^�R����E�B���i�[��I���A��ނ��^�Ԉʒu�Ɉړ�
                if (hit.collider.gameObject.tag == "Player")
                {
                    winner = true;
                }

                if(winner == true && hit.collider.gameObject.tag == tag)
                {
                    Goal = hit.collider.gameObject;
                    PosX = transform.position.x;
                    PosY = transform.position.y;
                    PosZ = transform.position.z;
                    MPosX = Goal.transform.position.x;
                    MPosY = Goal.transform.position.y;
                    MPosZ = Goal.transform.position.z;

                    Vector3[] path =
                    {
                        new Vector3(PosX, PosY,PosZ),
                        new Vector3(PosX, PosY + 10f, PosZ),
                        new Vector3(MPosX,MPosY + 10f,MPosZ),
                    };

                    //�����グ��
                    Tako.transform.DOPath(path, 1.0f, PathType.CatmullRom).SetEase(Ease.Linear);
                }
            }
        }
    }

    //�������������鏈��
    void Face()
    {
        var direction = Guzai.transform.position - transform.position;
        direction.y = 0;
        var lookRotation = Quaternion.LookRotation(direction, Vector3.up);
        Tako.transform.rotation = Quaternion.Lerp(Tako.transform.rotation, lookRotation, 0.1f);
    }
}
