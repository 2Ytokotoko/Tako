using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class KcalH : MonoBehaviour
{
    GameObject KS;
    Kcal script;
    int score;

//    public TextMeshProUGUI Hyouka ;
    public Text Hyouka;
    public GameObject GameUI, ResultUI;

    public int HYOUKA = 10;//基準とする数値
    // Start is called before the first frame update
    void Start()
    {
        KS = GameObject.Find("Hantei");
        script = KS.GetComponent<Kcal>();
        Hyouka.enabled = false;      // 変数textGameoverに入れられたテキストを 表示しません
}

// Update is called once per frame
void Update()
    {
        score = script.score;

    }
    public void PushButton()
    {
        GameUI.SetActive(false);
        ResultUI.SetActive(true);

        //Time.timeScale = 0f;
        Hyouka.enabled = true;
        if (score <= HYOUKA)
        {
            Hyouka.text = "Bad";
        }

        if (score >= HYOUKA)
        {
            Hyouka.text = "Good";
        }
    }
}


