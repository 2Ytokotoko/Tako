using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Odai3 : MonoBehaviour
{
    public GameObject Main1, Main2, Main3, Main4, Main5, Clear1, Clear2, Clear3, Clear4, Clear5;
    public int pScore, kScore,wScore;
    public float Count;
    public int EBIHURAICOUNT;
    CountDown time;

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
    public int pEBIHURAI = 100;

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
    public int kEBIHURAI = 100;
    
    //重量
    public int wKARAAGE = 30;
    public int wEBIHURAI = 30;
    public int wTOMATO = 10;
    public int wTAMAGOYAKI = 40;
    public int wBUROKKORII = 20;
    public int wTAKO = 20;
    public int wSYUUMAI = 15;
    public int wMIITOBOURU = 10;
    public int wNAPORITANN = 35;
    public int wPASUTA = 35;
    public int wHANNBAAGU = 70;

    public GameObject BentoName;

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
        Main5.SetActive(true);
        Clear5.SetActive(false);
        EBIHURAICOUNT = 0;
        pScore = 20;
        kScore = 235;
        wScore = 150;
        time = FindObjectOfType<CountDown>();
        Check();
    }
    void Update()
    {
        Count = time.countdown;
        Check();
    }
    void OnTriggerEnter(Collider other)
    {
        //個数カウント
        if (other.CompareTag("KARAAGE"))
        {
            kScore += kKARAAGE;
            pScore += pKARAAGE;
            wScore += wKARAAGE;
        }
        if (other.CompareTag("HANNBAAGU"))
        {
            kScore += kHANNBAAGU;
            pScore += pHANNBAAGU;
            wScore += wHANNBAAGU;
        }
        //サブ
        if (other.CompareTag("TOMATO"))
        {
            kScore += kTOMATO;
            pScore += pTOMATO;
            wScore += wTOMATO;
        }
        if (other.CompareTag("TAMAGOYAKI"))
        {
            kScore += kTAMAGOYAKI;
            pScore += pTAMAGOYAKI;
            wScore += wTAMAGOYAKI;
        }
        if (other.CompareTag("TAKO") || other.CompareTag("Player"))
        {
            kScore += kTAKO;
            pScore += pTAKO;
            wScore += wTAKO;
        }
        if (other.CompareTag("SYUUMAI"))
        {

            kScore += kSYUUMAI;
            pScore += pSYUUMAI;
            wScore += wSYUUMAI;
        }
        if (other.CompareTag("MIITOBOURU"))
        {
            kScore += kMIITOBOURU;
            pScore += pMIITOBOURU;
            wScore += wMIITOBOURU;
        }
        //サブ
        if (other.CompareTag("NAPORITANN"))
        {
            kScore += kNAPORITANN;
            pScore += pNAPORITANN;
            wScore += wNAPORITANN;
        }
        if (other.CompareTag("PASUTA"))
        {
            kScore += kPASUTA;
            pScore += pPASUTA;
            wScore += wPASUTA;
        }
        if (other.CompareTag("EBIHURAI"))
        {
            EBIHURAICOUNT = EBIHURAICOUNT + 1;
            kScore += kEBIHURAI;
            pScore += pEBIHURAI;
            wScore += wEBIHURAI;
        }
        Check();
    }

    void Check()
    {
        //お題①エビフライ4個以上
        if (EBIHURAICOUNT >= 4)
        {
                Main1.SetActive(false);
                Clear1.SetActive(true);
        }
        else if(EBIHURAICOUNT < 4)
        {
            Main1.SetActive(true);
            Clear1.SetActive(false);
        }

        //お題②重量400以上
        if (wScore >= 400)
        {
            Main2.SetActive(false);
            Clear2.SetActive(true);
        }
        else if(wScore < 400)
        {
            Main2.SetActive(true);
            Clear2.SetActive(false);
        }

        //お題③カロリー400以上
        if (kScore >= 400)
        {
            Main3.SetActive(false);
            Clear3.SetActive(true);
        }
        else if(kScore < 400)
        {
            Main3.SetActive(true);
            Clear3.SetActive(false);
        }

        //お題④値段1200以下
        if (kScore <= 1200)
        {
            Main4.SetActive(false);
            Clear4.SetActive(true);
        }
        else if (kScore > 1200)
        {
            Main4.SetActive(true);
            Clear4.SetActive(false);
        }

        //お題⑤5分以内にクリア
        if (Count <= 420)
        {
            if (BentoName.activeSelf)
            {
                Main5.SetActive(false);
                Clear5.SetActive(true);
            }
        }
    }
}
