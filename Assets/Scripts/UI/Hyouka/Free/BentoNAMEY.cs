using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class BentoNAMEY : MonoBehaviour
{
    public int Tamagoyaki;
    public int Karaage;
    public int Ebihurai;
    public int Hanbaagu;
    public int Syuumai;
    public int Naporitan;
    public int Tomato;
    public int Burokkorii;
    public int Miitobouru;
    private KaitenNumber kaitenNumber;

    //   StringBuilder Name = new StringBuilder();
    // GameObject KS;
    // Start is called before the first frame update


    private Animator anime;�@//�A�j���[�^�[������ϐ���p�ӂ��܂�
    bool flag;
    void Start()
    {
        kaitenNumber = FindObjectOfType<KaitenNumber>();
        anime = GetComponent<Animator>();�@�@�@//�ϐ���Animator�R���|�l���g�����܂�
        anime.SetBool("Ani", false);		//Animator���ɂ���bool�t���O�hisShoot�h��false�ɂ��Ă����܂�
    }
    void OnTriggerEnter(Collider other)
    {
        //���C��
        if (other.CompareTag("KARAAGE"))
        {
            kaitenNumber.karaage += 1;
        }
        if (other.CompareTag("EBIHURAI"))
        {
            kaitenNumber.ebihurai += 1;
        }
        if (other.CompareTag("HANNBAAGU"))
        {
            kaitenNumber.hanbaagu += 1;
        }
        if (other.CompareTag("SYUUMAI"))
        {
            kaitenNumber.syuumai += 1;
        }
        //�T�u
        if (other.CompareTag("TOMATO"))
        {
            kaitenNumber.tomato += 1;
        }
        if (other.CompareTag("TAMAGOYAKI"))
        {
            kaitenNumber.tamagoyaki += 1;
        }
        if (other.CompareTag("BUROKKORII"))
        {
            kaitenNumber.burokkorii += 1;
        }
        if (other.CompareTag("MIITOBOURU"))
        {
            kaitenNumber.miitobouru += 1;
        }
        if (other.CompareTag("NAPORITANN"))
        {
            kaitenNumber.naporitan += 1;
        }
        if (other.CompareTag("TAKO") || other.CompareTag("Player"))
        {
             flag = true;
            BENT();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        //���C��
        if (other.CompareTag("datuKARAAGE"))
        {
            kaitenNumber.karaage -= 1;
        }
        if (other.CompareTag("datuEBIHURAI"))
        {
            kaitenNumber.ebihurai -= 1;
        }
        if (other.CompareTag("datuHANNBAAGU"))
        {
            kaitenNumber.hanbaagu -= 1;
        }
        if (other.CompareTag("datuSYUUMAI"))
        {
            kaitenNumber.syuumai -= 1;
        }
        //�T�u
        if (other.CompareTag("datuTOMATO"))
        {
            kaitenNumber.tomato -= 1;
        }
        if (other.CompareTag("datuTAMAGOYAKI"))
        {
            kaitenNumber.tamagoyaki -= 1;
        }
        if (other.CompareTag("datuBUROKKORII"))
        {
            kaitenNumber.burokkorii -= 1;
        }

        if (other.CompareTag("datuMIITOBOURU"))
        {
            kaitenNumber.miitobouru -= 1;
        }
        if (other.CompareTag("datuNAPORITANN"))
        {
            kaitenNumber.naporitan -= 1;
        }
    }

    void BENT()
    {
        if (flag == true)�@		//�@����shootFlag��true�Ȃ�Aanimator�́hishoot�h�t���O��true�ɂ��܂�
        {

            anime.SetTrigger("Ani"); // "Trigger"�ɂ̓p�����[�^��������܂�

        }
    }
}