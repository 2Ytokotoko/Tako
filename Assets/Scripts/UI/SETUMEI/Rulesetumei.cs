using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Rulesetumei : MonoBehaviour
{
    //‰Ÿ‚³‚ê‚½‰ñ”‚ğŠi”[‚·‚é•Ï”
    public int counter = 0;
    const int counterMin = 0;  //Å‘å’l
    const int counterMax = 2;  //Å‘å’l
    public Image Photo;
    public Sprite I1;
    public Sprite I2;
    public Sprite I3;
    private AudioSource audioSource;
    public AudioClip se;
    //”­Ë‚·‚é‹Ê‚ÌPrefab


    // Use this for initialization
    void Start()
    {
        Photo = GameObject.Find("Image").GetComponent<Image>();
        Photo.enabled = true;
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

            Photo.sprite = I1;
        }
        if (counter >= 1)
        {

            Photo.sprite = I2;
        }
        if (counter >= 2)
        {

            Photo.sprite = I3;
        }
    }
}
