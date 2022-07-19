using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OfferCount1 : MonoBehaviour
{
    public GameObject Notplay, play;
    public int HighScore1;
    private void Start()
    {
        HighScore1 = PlayerPrefs.GetInt("SCORE1", 0);
    }
    private void Update()
    {
        int check = GameObject.FindGameObjectsWithTag("Check").Length;
        Debug.Log("íBê¨ÇµÇΩÇ®ëËÇÃêîÇÕ" + check.ToString() + "å¬");
        if (HighScore1 < check)
        {
            HighScore1 = check;
            PlayerPrefs.SetInt("SCORE1", HighScore1);
            PlayerPrefs.Save();
        }
        if (HighScore1 == 3)
        {
            Notplay.SetActive(false);
            play.SetActive(true);
        }
        }
    }
