using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Setumei : MonoBehaviour
{
    //‰Ÿ‚³‚ê‚½‰ñ”‚ğŠi”[‚·‚é•Ï”
    public int counter = 0;
    const int counterMin = 0;  //Å‘å’l
    const int counterMax = 4;  //Å‘å’l
    public Image myPhoto;
    public Sprite I1;
    public Sprite I2;
    public Sprite I3;
    public Sprite I4;
    public Sprite I5;
    private AudioSource audioSource;
    public AudioClip se;

    //”­Ë‚·‚é‹Ê‚ÌPrefab


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
