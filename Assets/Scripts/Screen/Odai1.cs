using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Odai1 : MonoBehaviour
{
    public GameObject Main1, Main2, Main3, Clear1, Clear2, Clear3;
    public float Count;
    public int wScore,KARAAGECOUNT,Gcheck,Wcheck;
    public CountDown countDown;
    public Weight weight;
    private AudioSource audioSource;
    public AudioClip se1, se2;
    public int KARAAGE = 30;
    public int EBIHURAI = 30;
    public int HANBAAGU = 70;
    public int SYUUMAI = 15;
    public int TOMATO = 10;
    public int TAMAGOYAKI = 40;
    public int BUROKKORII = 20;
    public int MIITOBOURU = 10;
    public int NAPORITANN = 35;
    public int TAKO = 20;
    private GameObject Bentoname;

    void Start()
    {
        Main1.SetActive(true);
        Clear1.SetActive(false);
        Main2.SetActive(true);
        Clear2.SetActive(false);
        Main3.SetActive(true);
        Clear3.SetActive(false);
        KARAAGECOUNT = 0;
        wScore = 150;
         Gcheck = 0;
         Wcheck = 0;
        Check();
    }
    void Update()
    {
        Count = countDown.countdown;
        //wScore = weight.score;
        Bentoname = GameObject.Find("OdaiName");
        Check();
    }
    void OnTriggerEnter(Collider other)
    {

        //個数カウント
        if (other.CompareTag("KARAAGE"))
        {
            KARAAGECOUNT += 1;
            wScore += KARAAGE;
        }
        if (other.CompareTag("EBIHURAI"))
        {
            wScore += EBIHURAI;
        }
        if (other.CompareTag("HANNBAAGU"))
        {
            wScore += HANBAAGU;
        }
        if (other.CompareTag("SYUUMAI"))
        {
            wScore += SYUUMAI;
        }
        //サブ
        if (other.CompareTag("TOMATO"))
        {
            wScore += TOMATO;
        }
        if (other.CompareTag("TAMAGOYAKI"))
        {
            wScore += TAMAGOYAKI;
        }
        if (other.CompareTag("BUROKKORII"))

        {
            wScore += BUROKKORII;
        }

        if (other.CompareTag("MIITOBOURU"))
        {
            wScore += MIITOBOURU;
        }
        if (other.CompareTag("NAPORITANN"))
        {
            wScore += NAPORITANN;
        }
        if (other.CompareTag("TAKO"))

        {
            wScore += TAKO;
        }
        Check();
    }
    void OnTriggerExit(Collider other)
    {
        //操作取り消し時
        if (other.CompareTag("datuKARAAGE"))
        {
            KARAAGECOUNT -= 1;
            wScore -= KARAAGE;
        }
        if (other.CompareTag("datuEBIHURAI"))
        {
            wScore -= EBIHURAI;
        }
        if (other.CompareTag("datuHANNBAAGU"))
        {
            wScore -= HANBAAGU;
        }
        if (other.CompareTag("datuSYUUMAI"))
        {
            wScore -= SYUUMAI;
        }
        //サブ
        if (other.CompareTag("datuTOMATO"))
        {
            wScore -= TOMATO;
        }
        if (other.CompareTag("datuTAMAGOYAKI"))
        {
            wScore -= TAMAGOYAKI;
        }
        if (other.CompareTag("datuBUROKKORII"))

        {
            wScore -= BUROKKORII;
        }

        if (other.CompareTag("datuMIITOBOURU"))
        {
            wScore -= MIITOBOURU;
        }
        if (other.CompareTag("datuNAPORITANN"))
        {
            wScore -= NAPORITANN;
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
        

        //お題②重量450g以上
        if (wScore >= 450)
        {
            Main2.SetActive(false);
            Clear2.SetActive(true);
            audioSource = gameObject.GetComponent<AudioSource>();
            audioSource.clip = se1;
            audioSource.Play();
            Wcheck = 1;
        }
        else if(Wcheck == 1)
        {
            Main2.SetActive(true);
            Clear2.SetActive(false);
            audioSource = gameObject.GetComponent<AudioSource>();
            audioSource.clip = se2;
            audioSource.Play();
        }
        else
        {
            Main2.SetActive(true);
            Clear2.SetActive(false);

        }

        //お題③3分以内にクリア
        if (Count <= 180)
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
