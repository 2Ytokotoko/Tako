using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Kcal : MonoBehaviour
{
    //    public TextMeshProUGUI scoreText; //Text用変数
    public Text scoreText;
    public int score = 0;//スコア計算用変数

    //メイン
    public int KARAAGE = 70;
    public int EBIHURAI = 60;
    public int HANBAAGU = 130;
    public int SYUUMAI= 25;


    //サブ
    public int TOMATO = 5;
    public int TAMAGOYAKI = 60;
    public int BUROKKORII = 10;
    public int MIITOBOURU= 25;
    public int NAPORITANN = 50;
    public int PASUTA = 30;
    public int POPPUCONSHURINPU = 25;

    //たこさんウィンナー
    public int TAKO = 20;
    private int TAKOCOUNT = 0;

    private GameObject odai, bento;

    void Start()
    {
        score += 235; //米分
        SetScore();   //初期スコアを代入して表示
    }
    private void Update()
    {
        odai = GameObject.Find("OdaiName");
        if (odai != null)
        {
            TAKOCOUNT += 1;
            if (TAKOCOUNT == 1)
            {
                score += TAKO;
                SetScore();
            }
        }
        bento = GameObject.Find("BentoNAMAE");
        if (bento != null)
        {
            score += TAKO;
            TAKOCOUNT += 1;
            if (TAKOCOUNT == 1)
            {
                SetScore();
            }
        }
    }
    //cube同士での衝突＋100 cube以外との衝突＋100
    void OnTriggerEnter(Collider other)
    {
        //メイン
        if (other.CompareTag("KARAAGE"))
        {
            score += KARAAGE;
        }
        if (other.CompareTag("EBIHURAI"))
        {
            score += EBIHURAI;
        }
        if (other.CompareTag("HANNBAAGU"))
        {
            score += HANBAAGU;
        }
        if (other.CompareTag("SYUUMAI"))
        {
            score += SYUUMAI;
        }
        //サブ
        if (other.CompareTag("TOMATO"))
        {
            score += TOMATO;
        }
        if (other.CompareTag("TAMAGOYAKI"))
        {
            score += TAMAGOYAKI;
        }
        if (other.CompareTag("BUROKKORII"))

        {
            score += BUROKKORII;
        }

        if (other.CompareTag("MIITOBOURU"))
        {
            score += MIITOBOURU;
        }
        if (other.CompareTag("NAPORITANN"))
        {
            score += NAPORITANN;
        }
        if (other.CompareTag("PASUTA"))
        {
            score += NAPORITANN;
        }
        if (other.CompareTag("POPPUCONSHURINPU"))
        {
            score += NAPORITANN;
        }
        //タコ
        if (other.CompareTag("TAKO") || other.CompareTag("Player"))

        {
            score += TAKO;
        }
        if (other.CompareTag("PASUTA"))
        {
            score += PASUTA;
        }
        if (other.CompareTag("POPPUCONSHURINPU"))
        {
            score += POPPUCONSHURINPU;
        }
        SetScore();
    }

    private void OnTriggerExit(Collider other)
    {
        //メイン
        if (other.CompareTag("datuKARAAGE"))
        {
            score -= KARAAGE;
        }
        if (other.CompareTag("datuEBIHURAI"))
        {
            score -= EBIHURAI;
        }
        if (other.CompareTag("datuHANNBAAGU"))
        {
            score -= HANBAAGU;
        }
        if (other.CompareTag("datuSYUUMAI"))
        {
            score -= SYUUMAI;
        }
        //サブ
        if (other.CompareTag("datuTOMATO"))
        {
            score -= TOMATO;
        }
        if (other.CompareTag("datuTAMAGOYAKI"))
        {
            score -= TAMAGOYAKI;
        }
        if (other.CompareTag("datuBUROKKORII"))

        {
            score -= BUROKKORII;
        }

        if (other.CompareTag("datuMIITOBOURU"))
        {
            score -= MIITOBOURU;
        }
        if (other.CompareTag("datuNAPORITANN"))
        {
            score -= NAPORITANN;
        }
        if (other.CompareTag("datuPASUTA"))
        {
            score -= PASUTA;
        }
        if (other.CompareTag("datuPOPPUCONSHURINPU"))
        {
            score -= POPPUCONSHURINPU;
        }
        SetScore();
    }

    void SetScore()
    {
        scoreText.text = string.Format("現在カロリー:"+"{0}", score + "Kcal");
    }
}

