using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OfferCount2 : MonoBehaviour
{
    public GameObject Notplay, play;
    public int Stage2;
    private void Start()
    {
        Stage2 = PlayerPrefs.GetInt("Highscore2", 0);
    }
    private void Update()
    {
        int count = GameObject.FindGameObjectsWithTag("Check").Length;
        int check = 4 - count;
        Debug.Log("’B¬‚µ‚½‚¨‘è‚Ì”‚Í" + check.ToString() + "ŒÂ");
        if (Stage2 < check)
        {
            Stage2 = check;
            PlayerPrefs.SetInt("Highscore2", Stage2);
            PlayerPrefs.Save();
        }
        if (Stage2 == 4)
        {
            Notplay.SetActive(false);
            play.SetActive(true);
        }
    }
}
