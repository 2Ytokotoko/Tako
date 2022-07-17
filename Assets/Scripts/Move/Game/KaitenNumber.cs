using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KaitenNumber : MonoBehaviour
{
    //モードチェンジ（0：具材入れる　1：具材を戻す）
    private int modechange;

    //ウィンナー選択（選択前、選択中、タコさん入れた）
    private int winner;

    /*選択した具材分け（1：ブロッコリー
     *                           2：エビフライ
     *                           3：ハンバーグ
     *                           4：唐揚げ
     *                           5：ミートボール
     *                           6：ナポリタン
     *                           7：パスタ
     *                           8：ポップコーンシュリンプ
     *                           9：焼売
     *                           10：卵焼き
     *                           11：トマト
     *                           12：タコさんウィンナー
     *                           */
    private int select;

    public int ModeChange
    {
        get { return modechange; }
        set { modechange = value; }
    }
    
    public int Winner
    {
        get { return winner;}
        set { winner = value; }
    }

    public int Select
    {
        get { return select; }
        set { select = value; }
    }

    //長方形回転用
    private int tyouhoukei;

    //L字など特殊な形回転用
    private int unique;

    public int Tyouhoukei
    {
        get { return tyouhoukei; }
        set { tyouhoukei = value; }
    }

    public int Unique
    {
        get { return unique; }
        set { unique = value; }
    }

    public int tamagoyaki;
    public int karaage;
    public int ebihurai;
    public int hanbaagu;
    public int syuumai;
    public int naporitan;
    public int tomato;
    public int burokkorii;
    public int miitobouru;

    public int Tamagoyaki
    {
        get { return tamagoyaki; }
        set { tamagoyaki = value; }
    }

    public int Karaage
    {
        get { return karaage; }
        set { karaage = value; }
    }

    public int Ebihurai
    {
        get { return ebihurai; }
        set { ebihurai = value; }
    }

    public int Hanbaagu
    {
        get { return hanbaagu; }
        set { hanbaagu = value; }
    }

    public int Syuumai
    {
        get { return syuumai; }
        set { syuumai = value; }
    }

    public int Naporitan
    {
        get { return naporitan; }
        set { naporitan = value; }
    }

    public int Tomato
    {
        get { return tomato; }
        set { tomato = value; }
    }

    public int Burokkorii
    {
        get { return burokkorii; }
        set { burokkorii = value; }
    }

    public int Miitobouru
    {
        get { return miitobouru; }
        set { miitobouru = value; }
    }
}
