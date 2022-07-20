using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Gallary : MonoBehaviour
{
    //âüÇ≥ÇÍÇΩâÒêîÇäiî[Ç∑ÇÈïœêî
    public int counter = 0;
    const int counterMin = 0;  //ç≈ëÂíl
    const int counterMax = 2;  //ç≈ëÂíl
    public Image myPhotoA, myPhotoB;
    public Sprite I1;
    public Sprite I2;
    public Sprite I3;
    public Sprite I4;
    public Sprite NotOpen;
    private AudioSource audioSource;
    public AudioClip se;
    public int Score1, Score2, Score3;

    void Start()
    {
        myPhotoA = GameObject.Find("ImageA").GetComponent<Image>();
        myPhotoA.enabled = false;
        myPhotoB = GameObject.Find("ImageB").GetComponent<Image>();
        myPhotoB.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        Score1 = PlayerPrefs.GetInt("Highscore1", 0);
        Score2 = PlayerPrefs.GetInt("Highscore2", 0);
        Score3 = PlayerPrefs.GetInt("Highscore3", 0);
    }
    public void ClickR()
    {
        audioSource = gameObject.GetComponent<AudioSource>();
        audioSource.clip = se;
        audioSource.PlayOneShot(se);
        counter++;
        PP(counter);
        if (counter >= counterMax)
        {

            counter = 2;
        }
    }
    public void ClickL()
    {
        audioSource = gameObject.GetComponent<AudioSource>();
        audioSource.clip = se;
        audioSource.PlayOneShot(se);
        counter--;
        PP(counter);
        if (counter <= counterMin)
        {

            counter = 0;
        }
    }

    void PP(int counter)
    {
        if (counter >= 0)
        {
            myPhotoA.enabled = false;
            myPhotoB.enabled = true;
            myPhotoB.sprite = I1;
        }
        if (counter >= 1)
        {
            myPhotoA.enabled = true;
            myPhotoB.enabled = true;
            if (Score1 == 3)
            {
                myPhotoA.sprite = I2;
            }
            else
            {
                myPhotoA.sprite = NotOpen;
            }
            if (Score2 == 4)
            {
                myPhotoB.sprite = I3;
            }
            else
            {
                myPhotoB.sprite = NotOpen;
            }
        }
        if (counter >= 2)
        {
            myPhotoA.enabled = true;
            if (Score3 == 5)
            {
                myPhotoA.sprite = I4;
            }
            else
            {
                myPhotoA.sprite = NotOpen;
            }
            myPhotoB.enabled = false;
        }
    }
}
