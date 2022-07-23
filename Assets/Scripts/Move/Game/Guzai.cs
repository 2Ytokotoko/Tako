using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Guzai : MonoBehaviour
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
    public string Tag;
    bool Kaiten = false;
    float Wheel;
    bool can = false;
    BoxCollider boxCollider;
    public GameObject HanteiPrefab;
    public string Nuke;
    GameObject Oya;
    AudioSource audioSource;
    public AudioClip kaiten;
    public AudioClip rakka;
    public AudioClip haki;
    KaitenNumber kaitenNumber;
    // Start is called before the first frame update
    void Start()
    {
        animator = GameObject.Find("Tako").GetComponent<Animator>();
        Player = GameObject.Find("Player");
        boxCollider = GetComponent<BoxCollider>();
        Oya = GameObject.Find("EnterGuzai");
        audioSource = GetComponent<AudioSource>();
        kaitenNumber = FindObjectOfType<KaitenNumber>();

        //無限わきで続けて投げる
        if (Mokutekiti.transform.position == Player.transform.position)
        {
            HanteiCreate();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Mokutekiti != null && Mokutekiti.transform.position == Player.transform.position && TargetObject == null && kaitenNumber.ModeChange %2 == 0 && kaitenNumber.Winner == 0)
        {
            Wheel = Input.GetAxis("Mouse ScrollWheel");

            //上にマウスホイールを回転
            if (Wheel > 0 && !Kaiten)
            {
                Kaiten = true;
                audioSource.PlayOneShot(kaiten);
                Mokutekiti.transform.parent = null;
                StartCoroutine("HidariKaiten");
            }

            //下にマウスホイールを回転
            else if (Wheel < 0 && !Kaiten)
            {
                Kaiten = true;
                audioSource.PlayOneShot(kaiten);
                Mokutekiti.transform.parent = null;
                StartCoroutine("MigiKaiten");
            }

            if (Input.GetMouseButtonDown(0))
            {
                Ray Leftray = Camera.main.ScreenPointToRay(Input.mousePosition);
                RaycastHit Lefthit;

                if (Physics.Raycast(Leftray, out Lefthit))
                {
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

                        PosX = transform.position.x;
                        PosY = transform.position.y;
                        PosZ = transform.position.z;
                        MPosX = TargetObject.transform.position.x;
                        MPosY = TargetObject.transform.position.y;
                        MPosZ = TargetObject.transform.position.z;

                        Vector3[] path =
                        {
                        new Vector3(PosX, PosY,PosZ),
                        new Vector3(PosX, PosY + 20f, PosZ),
                        new Vector3(MPosX,MPosY + 20f,MPosZ),
                        new Vector3(MPosX,MPosY,MPosZ),
                        };

                        gameObject.transform.DOPath(path, 0.3f, PathType.CatmullRom).SetEase(Ease.Linear);
                        Mokutekiti = null;
                        can = true;
                    }
                }
            }
        }
    }

    //左回転
    IEnumerator HidariKaiten()
    {
        for (int turn = 0; turn < 10; turn++)
        {
            transform.Rotate(0, -9, 0);
            yield return new WaitForSeconds(0.01f);
        }
        Kaiten = false;
        Mokutekiti.transform.parent = gameObject.transform;
    }

    //右回転
    IEnumerator MigiKaiten()
    {
        for (int turn = 0; turn < 10; turn++)
        {
            transform.Rotate(0, 9, 0);
            yield return new WaitForSeconds(0.01f);
        }
        Kaiten = false;
        Mokutekiti.transform.parent = gameObject.transform;
    }

    private void OnMouseOver()
    {
        if (can == true && kaitenNumber.Winner < 2 && kaitenNumber.ModeChange % 2 == 1)
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
                boxCollider.isTrigger = true;
                Invoke("DestroySyokuzai", 1.0f);
            }
        }
    }

    void DestroySyokuzai()
    {
        Destroy(gameObject);
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
