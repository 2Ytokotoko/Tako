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
    CountDown time;

    //�l�i
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

    //�J�����[
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
        NAPORITANNCOUNT = 0;
        MIITOBOURUCOUNT = 0;
        pScore = 20;
        kScore = 235;
        Check();
        time = FindObjectOfType<CountDown>();
    }
    void Update()
    {
        Count = time.countdown;
        Check();
    }
    void OnTriggerEnter(Collider other)
    {
        //���J�E���g
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
        //�T�u
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
        //�T�u
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
        //����@�i�|���^��4�ȏ�A�~�[�g�{�[��6�ȏ�
        if ((NAPORITANNCOUNT >= 4) && (MIITOBOURUCOUNT >= 6))
        {
            Main1.SetActive(false);
            Clear1.SetActive(true);

        }
        else if ((NAPORITANNCOUNT != 4) || (MIITOBOURUCOUNT != 6))
        {
            Main1.SetActive(true);
            Clear1.SetActive(false);

        }
        //����A�J�����[500�ȏ�
        if (kScore >= 500)
        {
            Main2.SetActive(false);
            Clear2.SetActive(true);
        }

        else if(kScore < 500)
        {
            Main2.SetActive(true);
            Clear2.SetActive(false);
        }

        //����B�l�i1000�ȉ�
        if (pScore <= 1000)
        {
            Main3.SetActive(false);
            Clear3.SetActive(true);
        }
        else if(pScore > 1000)
        {
            Main3.SetActive(true);
            Clear3.SetActive(false);
        }

        //����C5���ȓ��ɃN���A
        if (Count <= 300)
        {
            if (BentoName.activeSelf)
            {
                Main4.SetActive(false);
                Clear4.SetActive(true);
            }
        }
    }
}
