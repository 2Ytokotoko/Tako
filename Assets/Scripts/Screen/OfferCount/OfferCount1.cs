using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OfferCount1 : MonoBehaviour
{
    public GameObject Notplay, play;
    public int Stage1;
    private void Start()
    {
        Stage1 = PlayerPrefs.GetInt("Highscore1", 0);
    }
    private void Update()
    {
        int count = GameObject.FindGameObjectsWithTag("Check").Length;
        int check = 3 - count;
        Debug.Log("’B¬‚µ‚½‚¨‘è‚Ì”‚Í" + check.ToString() + "ŒÂ");
        if (Stage1 < check)
        {
            Stage1 = check;
            PlayerPrefs.SetInt("Highscore1", Stage1);
            PlayerPrefs.Save();
        }
        if (Stage1 == 3)
        {
            Notplay.SetActive(false);
            play.SetActive(true);
        }
        }
    }
