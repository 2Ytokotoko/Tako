using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Odai1 : MonoBehaviour
{
    public GameObject Main1, Main2, Main3, Clear1, Clear2, Clear3;
    public int G, Kal,En;
    public float Ime;
    public int KARAAGECOUNT,Gcheck,Wcheck;
    private AudioSource audioSource;
    public AudioClip se1, se2;
    Kcal kal;
    Weight g;
    Price en;　//緑波線出てるかもだけど問題なく反映されてた
    CountDown time;

    //スクリプトが入っているオブジェクト
    GameObject KS;
    GameObject TT;
    private GameObject Bentoname;
    bool once = true;

    void Start()
    {
        TT = GameObject.Find("Time");
        KS = GameObject.Find("Hantei");
        kal = KS.GetComponent<Kcal>();
        g = KS.GetComponent<Weight>();
        en = KS.GetComponent<Price>();
        time = TT.GetComponent<CountDown>();
        Main1.SetActive(true);
        Clear1.SetActive(false);
        Main2.SetActive(true);
        Clear2.SetActive(false);
        Main3.SetActive(true);
        Clear3.SetActive(false);
        Check();
    }
    void Update()
    {
        Kal = kal.score;
        G = g.score;
        En = en.score;
        Ime = time.countdown;
        Bentoname = GameObject.Find("OdaiName");
        Check();
    }
    void OnTriggerEnter(Collider other)
    { 
        //個数カウント
        if (other.CompareTag("KARAAGE"))
        {
            KARAAGECOUNT += 1;
        }
        Check();
    }
    void OnTriggerExit(Collider other)
    {
        //操作取り消し時
        if (other.CompareTag("datuKARAAGE"))
        {
            KARAAGECOUNT -= 1;
        }
        Check();
    }

    void Check()
    {
        //お題①唐揚げを3個以上
        if (KARAAGECOUNT >= 3)
        {
            Main1.SetActive(false);
            Clear1.SetActive(true);
            audioSource = gameObject.GetComponent<AudioSource>();
            audioSource.clip = se1;
            audioSource.Play();
            Gcheck = 1;
        }
        else if (Gcheck == 1) 
            {
                Main1.SetActive(true);
                Clear1.SetActive(false);
                audioSource = gameObject.GetComponent<AudioSource>();
                audioSource.clip = se2;
                audioSource.Play();
            }else
            {
                Main1.SetActive(true);
                Clear1.SetActive(false);

            }
        

        //お題②重量350g以上
        if (G >= 350)
        {
            Main2.SetActive(false);
            Clear2.SetActive(true);
            audioSource = gameObject.GetComponent<AudioSource>();
            audioSource.clip = se1;
            audioSource.Play();
            Wcheck = 1;
            if (once == true)
            {
                audioSource = gameObject.GetComponent<AudioSource>();
                audioSource.clip = se1;
                audioSource.Play();
                once = false;
            }
            else
            {
            }
        }
        else if(Wcheck == 1)
        {
            Main2.SetActive(true);
            Clear2.SetActive(false);
            audioSource = gameObject.GetComponent<AudioSource>();
            audioSource.clip = se2;
            audioSource.Play();
            once = true;
        }
        else
        {
            Main2.SetActive(true);
            Clear2.SetActive(false);

        }

        //お題③3分以内にクリア
        if (Ime <= 180)
        {
            if (Bentoname != null)
            {
                Main3.SetActive(false);
                Clear3.SetActive(true);
                audioSource = gameObject.GetComponent<AudioSource>();
                audioSource.clip = se1;
                audioSource.Play();
            }
            else
            {
                Main3.SetActive(true);
                Clear3.SetActive(false);
            }
        }
    }
}
