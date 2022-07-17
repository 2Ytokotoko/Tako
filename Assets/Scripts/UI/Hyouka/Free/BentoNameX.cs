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

    //スクリプトが入っているオブジェクト
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


        //カロリー 　500を中心として見ている
        if (Kal >= 900)
        {
            NameText.text += ("メタボまっしぐら");
        }
        else if (Kal >= 600)
        {
            NameText.text += ("人によってはこれくらい");
        }
        else if (Kal >= 500)
        {
            NameText.text += ("ちょうどいい");
        }
        else if (Kal >= 400)
        {
            NameText.text += ("ヘルシー");
        }
        else if (Kal >= 300)
        {
            NameText.text += ("ベリーヘルシー");
        }
        else  
        {
            NameText.text += ("ダイエット");
        }

        //重量
        if (G >= 900)
        {
            NameText.text += ("肩に弁当乗っけてんのかい！");
        }

        else
        {
            NameText.text += ("空気よりかる～い！");
        }

        //値段
        if (En >= 100)
        {
            NameText.text += ("お手軽");
        }
        else
        {
            NameText.text += ("小銭");
        }

        //時間
        if (Ime <= 60)
        {
            NameText.text += ("超特急");
        }
        else
        {
            NameText.text += ("サラマンダー");
        }


        //合体出来ない系
        if (kaitenNumber.tamagoyaki == 0 && kaitenNumber.karaage == 0 && kaitenNumber.ebihurai == 0 && kaitenNumber.hanbaagu == 0 &&
            kaitenNumber.syuumai == 0 && kaitenNumber.naporitan == 0 & kaitenNumber.tomato == 0 && kaitenNumber.burokkorii == 0 && kaitenNumber.miitobouru == 0)
        {
            NameText.text += ("オンリーユー");
        }

        if (kaitenNumber.tamagoyaki == 0 && kaitenNumber.karaage == 0 && kaitenNumber.ebihurai == 0 && kaitenNumber.hanbaagu == 0 &&
               kaitenNumber.syuumai == 0 && kaitenNumber.naporitan >= 1 & kaitenNumber.tomato >=1 && kaitenNumber.burokkorii == 0 && kaitenNumber.miitobouru >= 1)
        {
            NameText.text += ("まっかっか");
        }

        if (kaitenNumber.tamagoyaki >= 1 && kaitenNumber.karaage >= 1 && kaitenNumber.ebihurai == 0 && kaitenNumber.hanbaagu == 0 &&
            kaitenNumber.syuumai == 0 && kaitenNumber.naporitan == 0 & kaitenNumber.tomato == 0 && kaitenNumber.burokkorii == 0 && kaitenNumber.miitobouru == 0)
        {
            NameText.text += ("親子");
        }

        if (kaitenNumber.tamagoyaki == 0 && kaitenNumber.karaage >=1 && kaitenNumber.ebihurai == 0 && kaitenNumber.hanbaagu >= 1 &&
          kaitenNumber.syuumai > 1 && kaitenNumber.naporitan == 0 & kaitenNumber.tomato == 0 && kaitenNumber.burokkorii == 0 && kaitenNumber.miitobouru >= 1)
        {
            NameText.text += ("にくにくしい肉");
        }

        if (kaitenNumber.tamagoyaki == 0 && kaitenNumber.karaage == 0 && kaitenNumber.ebihurai ==0 && kaitenNumber.hanbaagu == 0 &&
          kaitenNumber.syuumai == 0 && kaitenNumber.naporitan == 0 & kaitenNumber.tomato >= 1 && kaitenNumber.burokkorii == 0 && kaitenNumber.miitobouru == 0)
        {

            NameText.text += ("ちょっとおっとまってとまと");
        }


        if (kaitenNumber.tamagoyaki == 0 && kaitenNumber.karaage == 0 && kaitenNumber.ebihurai == 0 && kaitenNumber.hanbaagu == 0 &&
          kaitenNumber.syuumai == 0 && kaitenNumber.naporitan == 0 & kaitenNumber.tomato == 0 && kaitenNumber.burokkorii >= 1 && kaitenNumber.miitobouru == 0)
        {

            NameText.text += ("ジャングル探検");
        }

        if (kaitenNumber.tamagoyaki == 0 && kaitenNumber.karaage == 0 && kaitenNumber.ebihurai >= 1 && kaitenNumber.hanbaagu == 0 &&
          kaitenNumber.syuumai == 0 && kaitenNumber.naporitan == 0 & kaitenNumber.tomato == 0 && kaitenNumber.burokkorii == 0 && kaitenNumber.miitobouru == 0)
        {

            NameText.text += ("偽りの海");
        }

        if (kaitenNumber.tamagoyaki == 0 && kaitenNumber.karaage > 0 && kaitenNumber.ebihurai >= 1 && kaitenNumber.hanbaagu >= 1 &&
          kaitenNumber.syuumai == 0 && kaitenNumber.naporitan == 0 & kaitenNumber.tomato == 0 && kaitenNumber.burokkorii == 0 && kaitenNumber.miitobouru >= 1)
        {

            NameText.text += ("茶色");
        }

        //合体できる系

        if (kaitenNumber.tamagoyaki >= 2)
        {
            NameText.text += "甘いかしょっぱいか";
        }

        if (kaitenNumber.karaage >= 2)
        {
            NameText.text += "朝を告げる揚げ鳥";
        }
        if (kaitenNumber.syuumai >= 12)
        {
            NameText.text += "みさきたいようけん！";
        }
        if (kaitenNumber.tomato >= 12)
        {
            NameText.text += "リコピンたくさん";
        }
        if (kaitenNumber.hanbaagu >= 6)
        {
            NameText.text += "はんば――――――ぐ！";
        }
        if (kaitenNumber.ebihurai >= 4)
        {
            NameText.text += "ご長寿";
        }
        if (kaitenNumber.miitobouru >= 12)
        {
            NameText.text += "み―――とぼ―――る！";
        }
        if (kaitenNumber.burokkorii >= 16)
        {
            NameText.text += "伝説の樹海";
        }
        if (kaitenNumber.naporitan >= 8)
        {
            NameText.text += "Sey!なぽりたん";
        }
        NameText.text += "弁当";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
