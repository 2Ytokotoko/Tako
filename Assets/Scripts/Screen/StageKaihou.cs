using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageKaihou : MonoBehaviour
{
    public GameObject NotGame2, NotGame3, NotFreeGame;
    public int Score1, Score2, Score3;

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

        Score1 = PlayerPrefs.GetInt("Highscore1", 0);
        Score2 = PlayerPrefs.GetInt("Highscore2", 0);
        Score3 = PlayerPrefs.GetInt("Highscore3", 0);

        if (Score1 == 3)
        {
            NotGame2.SetActive(false);
        }
        if (Score2 == 3)
        {
            NotGame3.SetActive(false);
        }
        if (Score3 == 3)
        {
            NotFreeGame.SetActive(false);
        }

    }
}
