using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Player : MonoBehaviour
{
    public GameObject Mokutekiti;
    public GameObject Tako;
    public GameObject Guzai;
    float PosX;
    float PosY;
    float PosZ;
    float MPosX;
    float MPosY;
    float MPosZ;
    public GameObject Goal;
    public string tag;
    public bool Owari = false;
    public GameObject GoalPrefab;
    public GameObject Mugenwakiti;
    public GameObject GameUI;
    public GameObject ClearUI;
    public GameObject Bento;
    AudioSource audioSource;
    public AudioClip Sentaku;
    public AudioClip Chakuti;
    public AudioClip rakka;
    KaitenNumber kaitenNumber;
    GameObject HanteiPrefab;
    public GameObject BroccoliHantei;
    public GameObject EbiflyHantei;
    public GameObject HamburgHantei;
    public GameObject KaraageHantei;
    public GameObject MeatballHantei;
    public GameObject NeapolitanHantei;
    public GameObject PastaHantei;
    public GameObject PopcornshrimpHantei;
    public GameObject SyumaiHantei;
    public GameObject TamagoyakiHantei;
    public GameObject TomatoHantei;

    public bool flag;//リザルトアニメーション用
    // Start is called before the first frame update
    void Start()
    {
        kaitenNumber = FindObjectOfType<KaitenNumber>();
        audioSource = GetComponent<AudioSource>();

        flag = false;//リザルトアニメーション
    }

    // Update is called once per frame
    void Update()
    {
        if (Mokutekiti != null)
        {
            //目的地に着いたら
            if (transform.position == Mokutekiti.transform.position)
            {
                Mokutekiti = null;
                //Guzai = null;
            }
        }

        //具材を選んでいたら
        if (Guzai != null)
        {
            //Face();
        }

        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit) && Owari == false)
            {
                if (hit.collider.gameObject.tag == "BUROKKORII" && hit.collider.gameObject.GetComponent<UniqueGuzai>().Mokutekiti != null)
                {
                    kaitenNumber.Select = 1;
                    audioSource.PlayOneShot(Sentaku);
                    kaitenNumber.Winner = 0;
                    Guzai = hit.collider.gameObject;
                    Mokutekiti = hit.collider.gameObject.GetComponent<UniqueGuzai>().Mokutekiti;
                    if (transform.position != Mokutekiti.transform.position)
                    {
                        PosX = transform.position.x;
                        PosY = transform.position.y;
                        PosZ = transform.position.z;
                        MPosX = Mokutekiti.transform.position.x;
                        MPosY = Mokutekiti.transform.position.y;
                        MPosZ = Mokutekiti.transform.position.z;

                        Vector3[] path =
                        {
                        new Vector3(PosX, PosY,PosZ),
                        new Vector3(PosX, PosY + 35f, PosZ),
                        new Vector3(MPosX,MPosY + 35f,MPosZ),
                        new Vector3(MPosX,MPosY,MPosZ),
                         };

                        gameObject.transform.DOPath(path, 0.2f, PathType.CatmullRom).SetEase(Ease.Linear);
                        Invoke("ChakutiSound", 0.2f);
                    }

                    //具材戻すモードでも移動可能、判定は生成しない
                    if(kaitenNumber.ModeChange % 2 == 0)
                    {
                        hit.collider.gameObject.GetComponent<UniqueGuzai>().HanteiCreate();
                    }
                }

                if (hit.collider.gameObject.tag == "EBIHURAI" && hit.collider.gameObject.GetComponent<UniqueGuzai>().Mokutekiti != null)
                {
                    kaitenNumber.Select = 2;
                    audioSource.PlayOneShot(Sentaku);
                    kaitenNumber.Winner = 0;
                    Guzai = hit.collider.gameObject;
                    Mokutekiti = hit.collider.gameObject.GetComponent<UniqueGuzai>().Mokutekiti;
                    if (transform.position != Mokutekiti.transform.position)
                    {
                        PosX = transform.position.x;
                        PosY = transform.position.y;
                        PosZ = transform.position.z;
                        MPosX = Mokutekiti.transform.position.x;
                        MPosY = Mokutekiti.transform.position.y;
                        MPosZ = Mokutekiti.transform.position.z;

                        Vector3[] path =
                        {
                        new Vector3(PosX, PosY,PosZ),
                        new Vector3(PosX, PosY + 35f, PosZ),
                        new Vector3(MPosX,MPosY + 35f,MPosZ),
                        new Vector3(MPosX,MPosY,MPosZ),
                         };

                        gameObject.transform.DOPath(path, 0.2f, PathType.CatmullRom).SetEase(Ease.Linear);
                        Invoke("ChakutiSound", 0.2f);
                    }

                    //具材戻すモードでも移動可能、判定は生成しない
                    if (kaitenNumber.ModeChange % 2 == 0)
                    {
                        hit.collider.gameObject.GetComponent<UniqueGuzai>().HanteiCreate();
                    }
                }

                if (hit.collider.gameObject.tag == "HANNBAAGU" && hit.collider.gameObject.GetComponent<TyouhoukeiGuzai>().Mokutekiti != null)
                {
                    kaitenNumber.Select = 3;
                    audioSource.PlayOneShot(Sentaku);
                    kaitenNumber.Winner = 0;
                    Guzai = hit.collider.gameObject;
                    Mokutekiti = hit.collider.gameObject.GetComponent<TyouhoukeiGuzai>().Mokutekiti;
                    if (transform.position != Mokutekiti.transform.position)
                    {
                        PosX = transform.position.x;
                        PosY = transform.position.y;
                        PosZ = transform.position.z;
                        MPosX = Mokutekiti.transform.position.x;
                        MPosY = Mokutekiti.transform.position.y;
                        MPosZ = Mokutekiti.transform.position.z;

                        Vector3[] path =
                        {
                        new Vector3(PosX, PosY,PosZ),
                        new Vector3(PosX, PosY + 35f, PosZ),
                        new Vector3(MPosX,MPosY + 35f,MPosZ),
                        new Vector3(MPosX,MPosY,MPosZ),
                         };

                        gameObject.transform.DOPath(path, 0.2f, PathType.CatmullRom).SetEase(Ease.Linear);
                        Invoke("ChakutiSound", 0.2f);
                    }

                    //具材戻すモードでも移動可能、判定は生成しない
                    if (kaitenNumber.ModeChange % 2 == 0)
                    {
                        hit.collider.gameObject.GetComponent<TyouhoukeiGuzai>().HanteiCreate();
                    }
                }

                //具材を選択、具材を運ぶ位置に移動
                if (hit.collider.gameObject.tag == "KARAAGE" && hit.collider.gameObject.GetComponent<Guzai>().Mokutekiti != null)
                {
                    kaitenNumber.Select = 4;
                    audioSource.PlayOneShot(Sentaku);
                    kaitenNumber.Winner = 0;
                    Guzai = hit.collider.gameObject;
                    Mokutekiti = hit.collider.gameObject.GetComponent<Guzai>().Mokutekiti;

                    if(transform.position != Mokutekiti.transform.position)
                    {
                        PosX = transform.position.x;
                        PosY = transform.position.y;
                        PosZ = transform.position.z;
                        MPosX = Mokutekiti.transform.position.x;
                        MPosY = Mokutekiti.transform.position.y;
                        MPosZ = Mokutekiti.transform.position.z;

                        Vector3[] path =
                        {
                        new Vector3(PosX, PosY,PosZ),
                        new Vector3(PosX, PosY + 35f, PosZ),
                        new Vector3(MPosX,MPosY + 35f,MPosZ),
                        new Vector3(MPosX,MPosY,MPosZ),
                         };

                        gameObject.transform.DOPath(path, 0.2f, PathType.CatmullRom).SetEase(Ease.Linear);
                        Invoke("ChakutiSound", 0.2f);
                    }

                    //具材戻すモードでも移動可能、判定は生成しない
                    if (kaitenNumber.ModeChange % 2 == 0)
                    {
                        hit.collider.gameObject.GetComponent<Guzai>().HanteiCreate();
                    }
                }

                if (hit.collider.gameObject.tag == "MIITOBOURU" && hit.collider.gameObject.GetComponent<Guzai>().Mokutekiti != null)
                {
                    kaitenNumber.Select = 5;
                    audioSource.PlayOneShot(Sentaku);
                    kaitenNumber.Winner = 0;
                    Guzai = hit.collider.gameObject;
                    Mokutekiti = hit.collider.gameObject.GetComponent<Guzai>().Mokutekiti;
                    if (transform.position != Mokutekiti.transform.position)
                    {
                        PosX = transform.position.x;
                        PosY = transform.position.y;
                        PosZ = transform.position.z;
                        MPosX = Mokutekiti.transform.position.x;
                        MPosY = Mokutekiti.transform.position.y;
                        MPosZ = Mokutekiti.transform.position.z;

                        Vector3[] path =
                        {
                        new Vector3(PosX, PosY,PosZ),
                        new Vector3(PosX, PosY + 35f, PosZ),
                        new Vector3(MPosX,MPosY + 35f,MPosZ),
                        new Vector3(MPosX,MPosY,MPosZ),
                         };

                        gameObject.transform.DOPath(path, 0.2f, PathType.CatmullRom).SetEase(Ease.Linear);
                        Invoke("ChakutiSound", 0.2f);
                    }

                    //具材戻すモードでも移動可能、判定は生成しない
                    if (kaitenNumber.ModeChange % 2 == 0)
                    {
                        hit.collider.gameObject.GetComponent<Guzai>().HanteiCreate();
                    }
                }

                if (hit.collider.gameObject.tag == "NAPORITANN" && hit.collider.gameObject.GetComponent<Guzai>().Mokutekiti != null)
                {
                    kaitenNumber.Select = 6;
                    audioSource.PlayOneShot(Sentaku);
                    kaitenNumber.Winner = 0;
                    Guzai = hit.collider.gameObject;
                    Mokutekiti = hit.collider.gameObject.GetComponent<Guzai>().Mokutekiti;

                    if (transform.position != Mokutekiti.transform.position)
                    {
                        PosX = transform.position.x;
                        PosY = transform.position.y;
                        PosZ = transform.position.z;
                        MPosX = Mokutekiti.transform.position.x;
                        MPosY = Mokutekiti.transform.position.y;
                        MPosZ = Mokutekiti.transform.position.z;

                        Vector3[] path =
                        {
                        new Vector3(PosX, PosY,PosZ),
                        new Vector3(PosX, PosY + 35f, PosZ),
                        new Vector3(MPosX,MPosY + 35f,MPosZ),
                        new Vector3(MPosX,MPosY,MPosZ),
                         };

                        gameObject.transform.DOPath(path, 0.2f, PathType.CatmullRom).SetEase(Ease.Linear);
                        Invoke("ChakutiSound", 0.2f);
                    }

                    //具材戻すモードでも移動可能、判定は生成しない
                    if (kaitenNumber.ModeChange % 2 == 0)
                    {
                        hit.collider.gameObject.GetComponent<Guzai>().HanteiCreate();
                    }
                }

                if (hit.collider.gameObject.tag == "PASUTA" && hit.collider.gameObject.GetComponent<Guzai>().Mokutekiti != null)
                {
                    kaitenNumber.Select = 7;
                    audioSource.PlayOneShot(Sentaku);
                    kaitenNumber.Winner = 0;
                    Guzai = hit.collider.gameObject;
                    Mokutekiti = hit.collider.gameObject.GetComponent<Guzai>().Mokutekiti;

                    if (transform.position != Mokutekiti.transform.position)
                    {
                        PosX = transform.position.x;
                        PosY = transform.position.y;
                        PosZ = transform.position.z;
                        MPosX = Mokutekiti.transform.position.x;
                        MPosY = Mokutekiti.transform.position.y;
                        MPosZ = Mokutekiti.transform.position.z;

                        Vector3[] path =
                        {
                        new Vector3(PosX, PosY,PosZ),
                        new Vector3(PosX, PosY + 35f, PosZ),
                        new Vector3(MPosX,MPosY + 35f,MPosZ),
                        new Vector3(MPosX,MPosY,MPosZ),
                         };

                        gameObject.transform.DOPath(path, 0.2f, PathType.CatmullRom).SetEase(Ease.Linear);
                        Invoke("ChakutiSound", 0.2f);
                    }

                    //具材戻すモードでも移動可能、判定は生成しない
                    if (kaitenNumber.ModeChange % 2 == 0)
                    {
                        hit.collider.gameObject.GetComponent<Guzai>().HanteiCreate();
                    }
                }

                if (hit.collider.gameObject.tag == "POPPUCONSHURINPU" && hit.collider.gameObject.GetComponent<UniqueGuzai>().Mokutekiti != null)
                {
                    kaitenNumber.Select = 8;
                    audioSource.PlayOneShot(Sentaku);
                    kaitenNumber.Winner = 0;
                    Guzai = hit.collider.gameObject;
                    Mokutekiti = hit.collider.gameObject.GetComponent<UniqueGuzai>().Mokutekiti;
                    if (transform.position != Mokutekiti.transform.position)
                    {
                        PosX = transform.position.x;
                        PosY = transform.position.y;
                        PosZ = transform.position.z;
                        MPosX = Mokutekiti.transform.position.x;
                        MPosY = Mokutekiti.transform.position.y;
                        MPosZ = Mokutekiti.transform.position.z;

                        Vector3[] path =
                        {
                        new Vector3(PosX, PosY,PosZ),
                        new Vector3(PosX, PosY + 35f, PosZ),
                        new Vector3(MPosX,MPosY + 35f,MPosZ),
                        new Vector3(MPosX,MPosY,MPosZ),
                         };

                        gameObject.transform.DOPath(path, 0.2f, PathType.CatmullRom).SetEase(Ease.Linear);
                        Invoke("ChakutiSound", 0.2f);
                    }

                    //具材戻すモードでも移動可能、判定は生成しない
                    if (kaitenNumber.ModeChange % 2 == 0)
                    {
                        hit.collider.gameObject.GetComponent<UniqueGuzai>().HanteiCreate();
                    }
                }

                if (hit.collider.gameObject.tag == "SYUUMAI" && hit.collider.gameObject.GetComponent<Guzai>().Mokutekiti != null)
                {
                    kaitenNumber.Select = 9;
                    audioSource.PlayOneShot(Sentaku);
                    kaitenNumber.Winner = 0;
                    Guzai = hit.collider.gameObject;
                    Mokutekiti = hit.collider.gameObject.GetComponent<Guzai>().Mokutekiti;
                    if (transform.position != Mokutekiti.transform.position)
                    {
                        PosX = transform.position.x;
                        PosY = transform.position.y;
                        PosZ = transform.position.z;
                        MPosX = Mokutekiti.transform.position.x;
                        MPosY = Mokutekiti.transform.position.y;
                        MPosZ = Mokutekiti.transform.position.z;

                        Vector3[] path =
                        {
                        new Vector3(PosX, PosY,PosZ),
                        new Vector3(PosX, PosY + 35f, PosZ),
                        new Vector3(MPosX,MPosY + 35f,MPosZ),
                        new Vector3(MPosX,MPosY,MPosZ),
                         };

                        gameObject.transform.DOPath(path, 0.2f, PathType.CatmullRom).SetEase(Ease.Linear);
                        Invoke("ChakutiSound", 0.2f);
                    }

                    //具材戻すモードでも移動可能、判定は生成しない
                    if (kaitenNumber.ModeChange % 2 == 0)
                    {
                        hit.collider.gameObject.GetComponent<Guzai>().HanteiCreate();
                    }
                }

                if (hit.collider.gameObject.tag == "TAMAGOYAKI" && hit.collider.gameObject.GetComponent<TyouhoukeiGuzai>().Mokutekiti != null)
                {
                    kaitenNumber.Select = 10;
                    audioSource.PlayOneShot(Sentaku);
                    kaitenNumber.Winner = 0;
                    Guzai = hit.collider.gameObject;
                    Mokutekiti = hit.collider.gameObject.GetComponent<TyouhoukeiGuzai>().Mokutekiti;
                    if (transform.position != Mokutekiti.transform.position)
                    {
                        PosX = transform.position.x;
                        PosY = transform.position.y;
                        PosZ = transform.position.z;
                        MPosX = Mokutekiti.transform.position.x;
                        MPosY = Mokutekiti.transform.position.y;
                        MPosZ = Mokutekiti.transform.position.z;

                        Vector3[] path =
                        {
                        new Vector3(PosX, PosY,PosZ),
                        new Vector3(PosX, PosY + 35f, PosZ),
                        new Vector3(MPosX,MPosY + 35f,MPosZ),
                        new Vector3(MPosX,MPosY,MPosZ),
                         };

                        gameObject.transform.DOPath(path, 0.2f, PathType.CatmullRom).SetEase(Ease.Linear);
                        Invoke("ChakutiSound", 0.2f);
                    }

                    //具材戻すモードでも移動可能、判定は生成しない
                    if (kaitenNumber.ModeChange % 2 == 0)
                    {
                        hit.collider.gameObject.GetComponent<TyouhoukeiGuzai>().HanteiCreate();
                    }
                }

                if (hit.collider.gameObject.tag == "TOMATO" && hit.collider.gameObject.GetComponent<Guzai>().Mokutekiti != null)
                {
                    kaitenNumber.Select = 11;
                    audioSource.PlayOneShot(Sentaku);
                    kaitenNumber.Winner = 0;
                    Guzai = hit.collider.gameObject;
                    Mokutekiti = hit.collider.gameObject.GetComponent<Guzai>().Mokutekiti;
                    if (transform.position != Mokutekiti.transform.position)
                    {
                        PosX = transform.position.x;
                        PosY = transform.position.y;
                        PosZ = transform.position.z;
                        MPosX = Mokutekiti.transform.position.x;
                        MPosY = Mokutekiti.transform.position.y;
                        MPosZ = Mokutekiti.transform.position.z;

                        Vector3[] path =
                        {
                        new Vector3(PosX, PosY,PosZ),
                        new Vector3(PosX, PosY + 35f, PosZ),
                        new Vector3(MPosX,MPosY + 35f,MPosZ),
                        new Vector3(MPosX,MPosY,MPosZ),
                         };

                        gameObject.transform.DOPath(path, 0.2f, PathType.CatmullRom).SetEase(Ease.Linear);
                        Invoke("ChakutiSound", 0.2f);
                    }

                    //具材戻すモードでも移動可能、判定は生成しない
                    if (kaitenNumber.ModeChange % 2 == 0)
                    {
                        hit.collider.gameObject.GetComponent<Guzai>().HanteiCreate();
                    }
                }

                //タコさんウィンナーを選択
                if (hit.collider.gameObject.tag == "Player")
                {
                    kaitenNumber.Select = 12;
                    audioSource.PlayOneShot(Sentaku);
                    kaitenNumber.Winner = 1;

                    //具材戻すモードでは判定は生成しない
                    if (kaitenNumber.ModeChange %2 == 0)
                    {
                        GoalCreate();
                    }
                }

                //ウィンナー飛ばす
                if (hit.collider.gameObject.tag == tag && kaitenNumber.Winner == 1)
                {
                    kaitenNumber.Winner = 2;
                    audioSource.PlayOneShot(rakka);
                    Invoke("Result", 1.0f);
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
                        new Vector3(PosX, PosY + 150f, PosZ),
                        new Vector3(MPosX,MPosY + 150f,MPosZ),
                        new Vector3(MPosX,MPosY,MPosZ)
                    };

                    Tako.transform.DOPath(path, 0.2f, PathType.CatmullRom).SetEase(Ease.Linear);
                    Invoke("ChakutiSound", 0.2f);
                    HanteiDestroy();
                }
            }
        }

        //マウスホイール押してモード切替
        if (Input.GetMouseButtonDown(2) && kaitenNumber.Winner < 2)
        {
            kaitenNumber.ModeChange += 1;
            HanteiDestroy();
        }

        //入れるモードに切り替えたときに判定生成
        if(Input.GetMouseButtonDown(2) && kaitenNumber.ModeChange %2 == 0&& kaitenNumber.Winner < 2)
        {
            if(kaitenNumber.Select == 1)
            {
                Debug.Log("ブロッコリー");
                HanteiPrefab = BroccoliHantei;
                HanteiReCreate();
            }

            else if(kaitenNumber.Select == 2)
            {
                Debug.Log("エビフライ");
                HanteiPrefab = EbiflyHantei;
                HanteiReCreate();
            }

            else if(kaitenNumber.Select == 3)
            {
                Debug.Log("ハンバーグ");
                HanteiPrefab = HamburgHantei;
                HanteiReCreate();
            }

            else if (kaitenNumber.Select == 4)
            {
                Debug.Log("唐揚げ");
                HanteiPrefab = KaraageHantei;
                HanteiReCreate();
            }

            else if (kaitenNumber.Select == 5)
            {
                Debug.Log("ミートボール");
                HanteiPrefab = MeatballHantei;
                HanteiReCreate();
            }

            else if (kaitenNumber.Select == 6)
            {
                Debug.Log("ナポリタン");
                HanteiPrefab = NeapolitanHantei;
                HanteiReCreate();
            }

            else if (kaitenNumber.Select == 7)
            {
                Debug.Log("パスタ");
                HanteiPrefab = PastaHantei;
                HanteiReCreate();
            }

            else if (kaitenNumber.Select == 8)
            {
                Debug.Log("ポップコーンシュリンプ");
                HanteiPrefab = PopcornshrimpHantei;
                HanteiReCreate();
            }

            else if (kaitenNumber.Select == 9)
            {
                Debug.Log("焼売");
                HanteiPrefab = SyumaiHantei;
                HanteiReCreate();
            }

            else if (kaitenNumber.Select == 10)
            {
                Debug.Log("卵焼き");
                HanteiPrefab = TamagoyakiHantei;
                HanteiReCreate();
            }

            else if (kaitenNumber.Select == 11)
            {
                Debug.Log("トマト");
                HanteiPrefab = TomatoHantei;
                HanteiReCreate();
            }

            else if (kaitenNumber.Select == 12)
            {
                Debug.Log("タコさんウィンナー");
                HanteiPrefab = GoalPrefab;
                HanteiReCreate();
            }
        }
    }

    //方向を向かせる処理
    void Face()
    {
        var direction = Guzai.transform.position - transform.position;
        direction.y = 0;
        var lookRotation = Quaternion.LookRotation(direction, Vector3.up);
        Tako.transform.rotation = Quaternion.Lerp(Tako.transform.rotation, lookRotation, 0.1f);
    }

    //判定を全て消す
    void HanteiDestroy()
    {
        GameObject[] Hanteis = GameObject.FindGameObjectsWithTag("Hantei");
        foreach (GameObject Hantei in Hanteis)
        {
            Destroy(Hantei);
        }
    }

    //タコさんの移動場所を作成
    public void GoalCreate()
    {
        GameObject[] Hanteis = GameObject.FindGameObjectsWithTag("Hantei");
        foreach (GameObject Hantei in Hanteis)
        {
            Destroy(Hantei);
        }
        GameObject goalObject = Instantiate(GoalPrefab, new Vector3(0, 0, 0), Quaternion.identity) as GameObject;
    }

    //具材戻すモードを解除したときに対応した食材の判定を生成
    public void HanteiReCreate()
    {
        GameObject HanteiObject = Instantiate(HanteiPrefab, new Vector3(0, 0, 0), Quaternion.identity) as GameObject;
    }

    void Result()
    {

        Time.timeScale = 0f;
        ClearUI.SetActive(true);
        GameUI.SetActive(false);
        Mugenwakiti.SetActive(false);
        Bento.SetActive(false);   
        flag = true;//リザルトアニメーション用
     //   Debug.Log("ok1");
    }

    void ChakutiSound()
    {
        audioSource.PlayOneShot(Chakuti);
    }
}
