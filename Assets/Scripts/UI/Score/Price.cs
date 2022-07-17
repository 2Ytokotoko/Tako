using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Price : MonoBehaviour
{
//    public TextMeshProUGUI scoreText; //Text�p�ϐ�
    public Text scoreText; //Text�p�ϐ�
    public int score = 20; //�ĕ�
                            //�X�R�A�v�Z�p�ϐ�

    //メイン
    public int KARAAGE = 70;
    public int EBIHURAI = 100;
    public int HANBAAGU = 100;
    public int SYUUMAI = 15;


    //サブ
    public int TOMATO = 5;
    public int TAMAGOYAKI = 20;
    public int BUROKKORII = 10;
    public int MIITOBOURU = 20;
    public int NAPORITANN = 65;
    //たこさんウィンナー
    public int TAKO = 20;

    void Start()
    {
        SetScore();   //初期スコアを代入して表示
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
        //タコ
        if (other.CompareTag("TAKO") || other.CompareTag("Player"))

        {
            score += TAKO;
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
        SetScore();
    }

    void SetScore()
    {
        scoreText.text = string.Format("合計金額:"+"{0}", score + "円");
    }
}
