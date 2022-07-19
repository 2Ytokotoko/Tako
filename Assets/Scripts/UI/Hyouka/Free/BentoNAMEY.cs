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


  //   Animator anime;　//アニメーターを入れる変数を用意します
    bool flag;
    void Start()
    {
        kaitenNumber = FindObjectOfType<KaitenNumber>();
        //anime = GetComponent<Animator>();　　　//変数にAnimatorコンポネントを入れます
     //   anime.SetBool("Ani", false);		//Animator内にあるboolフラグ”isShoot”をfalseにしておきます
    }
    void OnTriggerEnter(Collider other)
    {
        //メイン
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
        //サブ
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
        if (other.CompareTag("PASUTA"))
        {
         //   kaitenNumber.pasuta += 1;
        }
        if (other.CompareTag("POPPUCONSHURINPU"))
        {
          //  kaitenNumber.poppuconshurinpu += 1;
        }
        if (other.CompareTag("TAKO") || other.CompareTag("Player"))
        {
             flag = true;
            BENT();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        //メイン
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
        //サブ
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
        if (flag == true)　		//　そのshootFlagがtrueなら、animatorの”ishoot”フラグをtrueにします
        {

           // anime.SetTrigger("Ani"); // "Trigger"にはパラメータ名が入ります

        }
    }
}
