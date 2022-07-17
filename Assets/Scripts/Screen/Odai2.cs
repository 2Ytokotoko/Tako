using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Odai2 : MonoBehaviour
{
    public GameObject Main1, Main2, Main3, Main4, Clear1, Clear2, Clear3, Clear4;
    public int pScore, kScore;
    public float Count;
    public int MIITOBOURUCOUNT, NAPORITANNCOUNT;
    public CountDown countDown;

    //値段
    public int pKARAAGE = 70;
    public int pHANNBAAGU = 100;
    public int pTOMATO = 5;
    public int pTAMAGOYAKI = 20;
    public int pBUROKKORII = 10;
    public int pTAKO = 20;
    public int pSYUUMAI = 15;
    public int pMIITOBOURU = 20;
    public int pNAPORITANN = 65;
    public int pPASUTA = 60;

    //カロリー
    public int kKARAAGE = 70;
    public int kHANNBAAGU = 130;
    public int kTOMATO = 5;
    public int kTAMAGOYAKI = 20;
    public int kBUROKKORII = 10;
    public int kTAKO = 20;
    public int kSYUUMAI = 25;
    public int kMIITOBOURU = 25;
    public int kNAPORITANN = 50;
    public int kPASUTA = 30;

    void Start()
    {
        Main1.SetActive(true);
        Clear1.SetActive(false);
        Main2.SetActive(true);
        Clear2.SetActive(false);
        Main3.SetActive(true);
        Clear3.SetActive(false);
        Main4.SetActive(true);
        Clear4.SetActive(false);
        NAPORITANNCOUNT = 0;
        MIITOBOURUCOUNT = 0;
        pScore = 20;
        kScore = 235;
        Check();
    }
    void Update()
    {
        Count = countDown.countdown;
        Check();
    }
    void OnTriggerEnter(Collider other)
    {
        //個数カウント
        if (other.CompareTag("KARAAGE"))
        {
            kScore += kKARAAGE;
            pScore += pKARAAGE;
        }
        if (other.CompareTag("HANNBAAGU"))
        {
            kScore += kHANNBAAGU;
            pScore += pHANNBAAGU;
        }
        //サブ
        if (other.CompareTag("TOMATO"))
        {
            kScore += kTOMATO;
            pScore += pTOMATO;
        }
        if (other.CompareTag("TAMAGOYAKI"))
        {
            kScore += kTAMAGOYAKI;
            pScore += pTAMAGOYAKI;
        }
        if (other.CompareTag("TAKO") || other.CompareTag("Player"))
        {
            kScore += kTAKO;
            pScore += pTAKO;
        }
        if (other.CompareTag("SYUUMAI"))
        {

            kScore += kSYUUMAI;
            pScore += pSYUUMAI;
        }
        if (other.CompareTag("MIITOBOURU"))
        {
            MIITOBOURUCOUNT = MIITOBOURUCOUNT + 1;
            kScore += kMIITOBOURU;
            pScore += pMIITOBOURU;
        }
        //サブ
        if (other.CompareTag("NAPORITANN"))
        {
            NAPORITANNCOUNT = NAPORITANNCOUNT + 1;
            kScore += kNAPORITANN;
            pScore += pNAPORITANN;
        }
        if (other.CompareTag("PASUTA"))
        {
            kScore += kPASUTA;
            pScore += pPASUTA;
        }
        Check();
    }

    void Check()
    {
        //お題①ナポリタン4個以上、ミートボール6個以上
        if ((NAPORITANNCOUNT >= 4) && (MIITOBOURUCOUNT >= 6))
        {
                Main1.SetActive(false);
                Clear1.SetActive(true);
            
        }
            //お題②カロリー500以上
            if (kScore >= 500)
            {
                Main2.SetActive(false);
                Clear2.SetActive(true);
            }

            //お題③5分以内にクリア
            if (Count <= 300)
            {
                if (Time.timeScale == 0f)
                {
                    Main3.SetActive(false);
                    Clear3.SetActive(true);
                }
                else
                {
                    Main3.SetActive(true);
                    Clear3.SetActive(false);
                }
            }
            //お題④値段500以下
            if (kScore >= 500)
            {
                Main4.SetActive(true);
                Clear4.SetActive(false);
            }
            else
            {
                Main4.SetActive(false);
                Clear4.SetActive(true);


            }
        }
    }
