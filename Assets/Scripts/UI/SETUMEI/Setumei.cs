using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Setumei : MonoBehaviour
{
    //押された回数を格納する変数
    public int counter = 0;
    const int counterMin = 0;  //最大値
    const int counterMax = 4;  //最大値
    public Image myPhoto;
    public Sprite I1;
    public Sprite I2;
    public Sprite I3;
    public Sprite I4;
    public Sprite I5;
    private AudioSource audioSource;
    public AudioClip se;

    //発射する玉のPrefab


    // Use this for initialization
    void Start()
    {
        myPhoto = GameObject.Find("Image").GetComponent<Image>();
        myPhoto.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {


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

            counter = 4;
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

            myPhoto.sprite = I1;
        }
        if (counter >= 1)
        {

            myPhoto.sprite = I2;
        }
        if (counter >= 2)
        {

            myPhoto.sprite = I3;
        }
        if (counter >= 3)
        {

            myPhoto.sprite = I4;
        }
        if(counter>=4)
        {
            myPhoto.sprite = I5;
        }

    }
}
