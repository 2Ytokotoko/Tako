using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class TyouhoukeiGuzai : MonoBehaviour
{
    Animator animator;
    public GameObject Mokutekiti;
    GameObject Player;
    GameObject TargetObject;
    float PosX;
    float PosY;
    float PosZ;
    float MPosX;
    float MPosY;
    float MPosZ;
    Player PlayerScript;
    public string Tag;
    bool Kaiten = false;
    float Wheel;
    bool can = false;
    BoxCollider boxColider;
    KaitenNumber kaitenNumber;
    public GameObject HanteiPrefab;
    public string Nuke;
    GameObject Oya;
    AudioSource audioSource;
    public AudioClip kaiten;
    public AudioClip rakka;
    public AudioClip haki;
    // Start is called before the first frame update
    void Start()
    {
        animator = GameObject.Find("Tako").GetComponent<Animator>();
        Mokutekiti.transform.parent = null;
        kaitenNumber = FindObjectOfType<KaitenNumber>();
        Player = GameObject.Find("PLAYERparent");
        PlayerScript = GameObject.Find("PLAYERparent").GetComponent<Player>();
        boxColider = GetComponent<BoxCollider>();
        Oya = GameObject.Find("EnterGuzai");
        audioSource = GetComponent<AudioSource>();

        //�ȑO�������`�������p��
        if (kaitenNumber.Tyouhoukei == 0)
        {
            transform.rotation = Quaternion.Euler(new Vector3(0, 0, 0));
        }
        else if (kaitenNumber.Tyouhoukei == 1)
        {
            transform.rotation = Quaternion.Euler(new Vector3(0, 90, 0));
        }

        //�����킫�ő����ē�����
        if (Mokutekiti.transform.position == Player.transform.position)
        {
            HanteiCreate();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Mokutekiti != null && Mokutekiti.transform.position == Player.transform.position && TargetObject == null && kaitenNumber.ModeChange % 2 == 0 && kaitenNumber.Winner == 0)
        {
            Wheel = Input.GetAxis("Mouse ScrollWheel");
            if(transform.localEulerAngles.y > -45 && transform.localEulerAngles.y < 45)
            {
                kaitenNumber.Tyouhoukei = 0;
            }

            if(transform.localEulerAngles.y > 45 && transform.localEulerAngles.y < 135)
            {
                kaitenNumber.Tyouhoukei = 1;
            }

            if(transform.localEulerAngles.y > 135 && transform.localEulerAngles.y < 225)
            {
                kaitenNumber.Tyouhoukei = 0;
            }

            if(transform.localEulerAngles.y > 225 && transform.localEulerAngles.y < 315)
            {
                kaitenNumber.Tyouhoukei = 1;
            }

            //��Ƀ}�E�X�z�C�[������]
            if (Wheel > 0 && !Kaiten)
            {
                Kaiten = true;
                audioSource.PlayOneShot(kaiten);
                StartCoroutine("HidariKaiten");
            }

            //���Ƀ}�E�X�z�C�[������]
            else if (Wheel < 0 && !Kaiten)
            {
                Kaiten = true;
                audioSource.PlayOneShot(kaiten);
                StartCoroutine("MigiKaiten");
            }

            if (Input.GetMouseButtonDown(0))
            {
                Ray Leftray = Camera.main.ScreenPointToRay(Input.mousePosition);
                RaycastHit Lefthit;

                if (Physics.Raycast(Leftray, out Lefthit))
                {
                    //��ނ�I���A��ނ��^�Ԉʒu�Ɉړ�
                    if (Lefthit.collider.gameObject.tag == Tag)
                    {
                        animator.SetTrigger("isThrow");
                        audioSource.PlayOneShot(rakka);
                        GameObject[] Hanteis = GameObject.FindGameObjectsWithTag("Hantei");
                        foreach (GameObject Hantei in Hanteis)
                        {
                            Destroy(Hantei);
                        }
                        Destroy(Mokutekiti);
                        gameObject.transform.parent = Oya.transform;
                        TargetObject = Lefthit.collider.gameObject;
                        PlayerScript.Guzai = null;

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
                        new Vector3(MPosX,MPosY,MPosZ),
                        };

                        //�����グ��
                        gameObject.transform.DOPath(path, 0.3f, PathType.CatmullRom).SetEase(Ease.Linear);
                        can = true;
                    }
                }
            }
        }
    }

    private void OnMouseOver()
    {
        if (can == true && kaitenNumber.Winner <2 && kaitenNumber.ModeChange % 2 == 1)
        {
            if (Input.GetMouseButtonDown(0))
            {
                audioSource.PlayOneShot(haki);
                gameObject.tag = Nuke;
                PosX = transform.position.x;
                PosY = transform.position.y;
                PosZ = transform.position.z;

                Vector3[] path =
                {
                        new Vector3(PosX, PosY,PosZ),
                        new Vector3(PosX, PosY + 50f, PosZ),
                 };

                gameObject.transform.DOPath(path, 0.2f, PathType.CatmullRom).SetEase(Ease.Linear);
                GameObject[] Hanteis = GameObject.FindGameObjectsWithTag("Hantei");
                foreach (GameObject Hantei in Hanteis)
                {
                    Destroy(Hantei);
                }
                boxColider.isTrigger = true;
                Invoke("DestroySyokuzai", 2.0f);
            }
        }
    }

    void DestroySyokuzai()
    {
        Destroy(gameObject);
    }

    //����]
    IEnumerator HidariKaiten()
    {
        for (int turn = 0; turn < 3; turn++)
        {
            transform.Rotate(0, -30, 0);
            yield return new WaitForSeconds(0.01f);
        }
        Kaiten = false;
    }

    //�E��]
    IEnumerator MigiKaiten()
    {
        for (int turn = 0; turn < 3; turn++)
        {
            transform.Rotate(0, 30, 0);
            yield return new WaitForSeconds(0.01f);
        }
        Kaiten = false;
    }

    public void HanteiCreate()
    {
        GameObject[] Hanteis = GameObject.FindGameObjectsWithTag("Hantei");
        foreach (GameObject Hantei in Hanteis)
        {
            Destroy(Hantei);
        }
        GameObject childObject = Instantiate(HanteiPrefab, new Vector3(0, 0, 0), Quaternion.identity) as GameObject;
    }
}
