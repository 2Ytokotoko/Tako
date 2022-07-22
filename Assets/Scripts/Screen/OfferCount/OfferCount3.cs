using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OfferCount3 : MonoBehaviour
{
    public GameObject Notplay, play;
    public int Stage3;
    private void Start()
    {
        Stage3 = PlayerPrefs.GetInt("Highscore3", 0);
    }
    private void Update()
    {
        int count = GameObject.FindGameObjectsWithTag("Check").Length;
        int check = 5 - count;
        Debug.Log("�B����������̐���" + check.ToString() + "��");
        play.SetActive(true);
        if (Stage3 < check)
        {
            Stage3 = check;
            PlayerPrefs.SetInt("Highscore3", Stage3);
            PlayerPrefs.Save();
        }
    }
}
