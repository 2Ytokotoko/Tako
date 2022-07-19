using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BentoNameX : MonoBehaviour
{ 
    Kcal kal;
    Weight  g;
    Price en;
    CountDown time;

    //�X�N���v�g�������Ă���I�u�W�F�N�g
    GameObject KS;
    GameObject TT;

    private KaitenNumber kaitenNumber;
    public Text NameText;
    // Start is called before the first frame update
    void Start()
    {
        TT = GameObject.Find("Time");
        KS = GameObject.Find("Hantei");

        kal = KS.GetComponent<Kcal>();
        g = KS.GetComponent<Weight>();
        en = KS.GetComponent<Price>();
        time = TT.GetComponent<CountDown>();

        kaitenNumber = FindObjectOfType<KaitenNumber>();

        int Kal = kal.score;
        int G = g.score;
        int En = en.score;
        float  Ime = time.countdown;


        //�J�����[ �@500�𒆐S�Ƃ��Č��Ă���
        if (Kal >= 900)
        {
            NameText.text += ("���A�a�Ɨx��܂��傤");
        }
        else if (Kal >= 3000)
        {
            NameText.text += ("1�����̂��ٓ�");
        }
        else if (Kal >= 2000)
        {
            NameText.text += ("�f�u�����Č��t�����邵");
        }
        else if (Kal >= 1000)
        {
            NameText.text += ("���^�{�܂�������");
        }
        else if (Kal >= 600)
        {
            NameText.text += ("�l�ɂ���Ă͂��ꂭ�炢");
        }
        else if (Kal >= 500)
        {
            NameText.text += ("���傤�ǂ���");
        }
        else if (Kal >= 400)
        {
            NameText.text += ("�w���V�[");
        }
        else if (Kal >= 300)
        {
            NameText.text += ("�_�C�G�b�g");
        }
        else  
        {
            NameText.text += ("�f�H");
        }

        //�d��
        if (G >= 3000)
        {
            NameText.text += ("���ɕٓ�������Ă�̂����I");
        }
       else if (G >= 2000)
        {
            NameText.text += ("���w�r�[��");
        }
        if (G >= 1000)
        {
            NameText.text += ("�w�r�[��");
        }
        if (G >= 800)
        {
            NameText.text += ("��Âɍl����0.8Kg���ďd������");
        }
        if (G >= 500)
        {
            NameText.text += ("������Əd�����ȁH");
        }
        if (G >= 300)
        {
            NameText.text += ("�����^�тɕ֗�");
        }
        if (G >= 100)
        {
            NameText.text += ("�ƂĂ��y����");
        }
        else
        {
            NameText.text += ("��C��肩��`���I");
        }

        //�l�i
        if (En >= 10000)
        {
            NameText.text += ("���{�����ł��肢���܂�");
        }
        else if (En >= 5000)
        {
            NameText.text += (En+"�~�̂��ٓ����ĂȂ��Ȃ��Ȃ���");
        }
        else if (En >= 1000)
        {
            NameText.text += ("�f���炵�����؂�");
        }
        else if (En >= 700)
        {
            NameText.text += ("������ƍ��؂Ȃ���");
        }
        else if (En >= 500)
        {
            NameText.text += ("�����͑�̂��ꂭ�炢");
        }
        else if (En >= 100)
        {
            NameText.text += ("����y");
        }
        else
        {
            NameText.text += ("���K");
        }

        //����
        if (Ime <= 30)
        {
            NameText.text += ("�T���}���_�[");
        }
      else  if (Ime <= 60)
        {
            NameText.text += ("�����}");
        }
        else if (Ime <= 180)
        {
            NameText.text += ("�}�s");
        }
        else if (Ime <= 300)
        {
            NameText.text += ("�e�w���");
        }
        else if (Ime <= 420)
        {
            NameText.text += ("�x��");
        }
        else if (Ime <= 600)
        {
            NameText.text += ("���̔���");
        }
        else
        {
            NameText.text += ("�F���񂪂��ٓ������܂�", Ime + "�b������܂���");
        }


        //���̏o���Ȃ��n
        if (kaitenNumber.tamagoyaki == 0 && kaitenNumber.karaage == 0 && kaitenNumber.ebihurai == 0 && kaitenNumber.hanbaagu == 0 &&  // kaitenNumber.pasuta== 0 && kaitenNumber.poppuconshurinpu == 0 &&
            kaitenNumber.syuumai == 0 && kaitenNumber.naporitan == 0 & kaitenNumber.tomato == 0 && kaitenNumber.burokkorii == 0 && kaitenNumber.miitobouru == 0)
        {
            NameText.text += ("�I�����[���[");
        }

        if (kaitenNumber.tamagoyaki == 0 && kaitenNumber.karaage == 0 && kaitenNumber.ebihurai == 0 && kaitenNumber.hanbaagu == 0 &&
               kaitenNumber.syuumai == 0 && kaitenNumber.naporitan >= 1 & kaitenNumber.tomato >=1 && kaitenNumber.burokkorii == 0 && kaitenNumber.miitobouru >= 1)
        {
            NameText.text += ("�܂�������");
        }

        if (kaitenNumber.tamagoyaki >= 1 && kaitenNumber.karaage >= 1 && kaitenNumber.ebihurai == 0 && kaitenNumber.hanbaagu == 0 &&
            kaitenNumber.syuumai == 0 && kaitenNumber.naporitan == 0 & kaitenNumber.tomato == 0 && kaitenNumber.burokkorii == 0 && kaitenNumber.miitobouru == 0)
        {
            NameText.text += ("�e�q");
        }

        if (kaitenNumber.tamagoyaki == 0 && kaitenNumber.karaage >=1 && kaitenNumber.ebihurai == 0 && kaitenNumber.hanbaagu >= 1 &&
          kaitenNumber.syuumai > 1 && kaitenNumber.naporitan == 0 & kaitenNumber.tomato == 0 && kaitenNumber.burokkorii == 0 && kaitenNumber.miitobouru >= 1)
        {
            NameText.text += ("�ɂ��ɂ�������");
        }

        if (kaitenNumber.tamagoyaki == 0 && kaitenNumber.karaage == 0 && kaitenNumber.ebihurai ==0 && kaitenNumber.hanbaagu == 0 &&
          kaitenNumber.syuumai == 0 && kaitenNumber.naporitan == 0 & kaitenNumber.tomato >= 1 && kaitenNumber.burokkorii == 0 && kaitenNumber.miitobouru == 0)
        {

            NameText.text += ("������Ƃ����Ƃ܂��ĂƂ܂�");
        }


        if (kaitenNumber.tamagoyaki == 0 && kaitenNumber.karaage == 0 && kaitenNumber.ebihurai == 0 && kaitenNumber.hanbaagu == 0 &&
          kaitenNumber.syuumai == 0 && kaitenNumber.naporitan == 0 & kaitenNumber.tomato == 0 && kaitenNumber.burokkorii >= 1 && kaitenNumber.miitobouru == 0)
        {

            NameText.text += ("�W�����O���T��");
        }

        if (kaitenNumber.tamagoyaki == 0 && kaitenNumber.karaage == 0 && kaitenNumber.ebihurai >= 1 && kaitenNumber.hanbaagu == 0 &&
          kaitenNumber.syuumai == 0 && kaitenNumber.naporitan == 0 & kaitenNumber.tomato == 0 && kaitenNumber.burokkorii == 0 && kaitenNumber.miitobouru == 0)
        {

            NameText.text += ("�U��̊C");
        }

        if (kaitenNumber.tamagoyaki == 0 && kaitenNumber.karaage > 0 && kaitenNumber.ebihurai >= 1 && kaitenNumber.hanbaagu >= 1 &&
          kaitenNumber.syuumai == 0 && kaitenNumber.naporitan == 0 & kaitenNumber.tomato == 0 && kaitenNumber.burokkorii == 0 && kaitenNumber.miitobouru >= 1)
        {

            NameText.text += ("���F");
        }

        //���̂ł���n

        if (kaitenNumber.tamagoyaki >= 2)
        {
            NameText.text += "�Â���������ς���";
        }

        if (kaitenNumber.karaage >= 2)
        {
            NameText.text += "����������g����";
        }
        if (kaitenNumber.syuumai >= 12)
        {
            NameText.text += "�݂��������悤����I";
        }
        if (kaitenNumber.tomato >= 12)
        {
            NameText.text += "���R�s����������";
        }
        if (kaitenNumber.hanbaagu >= 6)
        {
            NameText.text += "�͂�΁\�\�\�\�\�\���I";
        }
        if (kaitenNumber.ebihurai >= 4)
        {
            NameText.text += "������";
        }
        if (kaitenNumber.miitobouru >= 12)
        {
            NameText.text += "�݁\�\�\�Ƃځ\�\�\��I";
        }
        if (kaitenNumber.burokkorii >= 16)
        {
            NameText.text += "�`���̎��C";
        }
        if (kaitenNumber.naporitan >= 8)
        {
            NameText.text += "Sey!�Ȃۂ肽��";
        }
        NameText.text += "�ٓ�";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
