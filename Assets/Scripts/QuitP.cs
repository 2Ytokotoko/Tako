using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitP : MonoBehaviour
{
    public GameObject Canvas;
    public GameObject Warn;
    //private AudioSource audioSource;
    //public AudioClip se1; //‘I‘ð
    //public AudioClip se2; //–ß‚é
    public void Button()
    {
        Canvas.SetActive(false);
        Warn.SetActive(true);
        //    audioSource = gameObject.GetComponent<AudioSource>();
        //    audioSource.clip = se1;
        //    audioSource.PlayOneShot(se1);
        //    StartCoroutine("LoadExplanationPage");
    }
    //IEnumerator LoadExplanationPage()
    //{
    //    yield return new WaitForSeconds(1.5f);
    //    QuitPage.SetActive(true);
    //}

    public void Return_E()
    {
        Warn.SetActive(false);
        Canvas.SetActive(true);

        //   audioSource = gameObject.GetComponent<AudioSource>();
        //   audioSource.clip = se2;
        //   audioSource.PlayOneShot(se2);
        //   StartCoroutine("Loadclosed");
    }
    //IEnumerator Loadclosed()
    //{
    //    yield return new WaitForSeconds(1.5f);
    //    ExplanationPage.SetActive(false);
    //}
}
