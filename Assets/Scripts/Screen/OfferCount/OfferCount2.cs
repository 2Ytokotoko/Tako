using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OfferCount2 : MonoBehaviour
{
    public GameObject Notplay, play;
    public int HighScore2;
    private void Start()
    {
        HighScore2 = PlayerPrefs.GetInt("SCORE2", 0);
    }
    private void Update()
    {
        int check = GameObject.FindGameObjectsWithTag("Check").Length;
        Debug.Log("íBê¨ÇµÇΩÇ®ëËÇÃêîÇÕ" + check.ToString() + "å¬");
        if (HighScore2 < check)
        {
            HighScore2 = check;
            PlayerPrefs.SetInt("SCORE2", HighScore2);
            PlayerPrefs.Save();
        }
        if (HighScore2 == 3)
        {
            Notplay.SetActive(false);
            play.SetActive(true);
        }
    }
}
