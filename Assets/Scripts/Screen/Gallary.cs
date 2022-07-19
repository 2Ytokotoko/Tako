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
    OfferCount1 highScore1;
    OfferCount2 highScore2;
    OfferCount3 highScore3;
    GameObject KS;
    public int Score1, Score2, Score3;

    void Start()
    {
        myPhotoA = GameObject.Find("ImageA").GetComponent<Image>();
        myPhotoA.enabled = false;
        myPhotoB = GameObject.Find("ImageB").GetComponent<Image>();
        myPhotoB.enabled = true;
        KS = GameObject.Find("Hantei");
        highScore1 = KS.GetComponent<OfferCount1>();
        highScore2 = KS.GetComponent<OfferCount2>();
        highScore3 = KS.GetComponent<OfferCount3>();
    }

    // Update is called once per frame
    void Update()
    {

        Score1 = highScore1.HighScore1;
        Score2 = highScore2.HighScore2;
        Score3 = highScore3.HighScore3;

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
