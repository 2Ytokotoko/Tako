using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OfferCount3 : MonoBehaviour
{
    public GameObject Notplay, play;
    public int HighScore3;
    private void Start()
    {
        HighScore3 = PlayerPrefs.GetInt("SCORE3", 0);
    }
    private void Update()
    {
        int check = GameObject.FindGameObjectsWithTag("Check").Length;
        Debug.Log("íBê¨ÇµÇΩÇ®ëËÇÃêîÇÕ" + check.ToString() + "å¬");
        if (HighScore3 < check)
        {
            HighScore3 = check;
            PlayerPrefs.SetInt("SCORE3", HighScore3);
            PlayerPrefs.Save();
        }
        if (HighScore3 == 3)
        {
            Notplay.SetActive(false);
            play.SetActive(true);
        }
    }
}
