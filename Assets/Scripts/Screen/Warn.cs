using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Warn: MonoBehaviour
{
    public GameObject Warning;
    private AudioSource audioSource;
    public AudioClip se1;
    public AudioClip se2;
    public void NotOpen()
    {
        //audioSource = gameObject.GetComponent<AudioSource>();
        //audioSource.clip = se1;
        //audioSource.PlayOneShot(se1);
        Warning.SetActive(true);
    }
    public void close()
    {
        //audioSource = gameObject.GetComponent<AudioSource>();
        //audioSource.clip = se2;
        //audioSource.PlayOneShot(se2);
        Warning.SetActive(false);
    }
}