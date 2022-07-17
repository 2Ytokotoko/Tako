using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sousasetsumei : MonoBehaviour
{
    public GameObject ExplanationPage,RulePage,SoundPage;
    private AudioSource audioSource;
    public AudioClip se1; //‘I‘ð
    public AudioClip se2; //–ß‚é
    public void Button()
    {
        audioSource = gameObject.GetComponent<AudioSource>();
        audioSource.clip = se1;
        audioSource.PlayOneShot(se1);
        StartCoroutine("LoadExplanationPage");
    }
        IEnumerator LoadExplanationPage()
        {
            yield return new WaitForSeconds(1.5f);
            ExplanationPage.SetActive(true);
        }

    public void Return_E()
    {
        audioSource = gameObject.GetComponent<AudioSource>();
        audioSource.clip = se2;
        audioSource.PlayOneShot(se2);
        StartCoroutine("LoadcloseE");
    }
    IEnumerator LoadcloseE()
    {
        yield return new WaitForSeconds(1.5f);
        ExplanationPage.SetActive(false);
    }

    public void RuleButton()
    {
        audioSource = gameObject.GetComponent<AudioSource>();
        audioSource.clip = se1;
        audioSource.PlayOneShot(se1);
        StartCoroutine("LoadRulePage");
    }
    IEnumerator LoadRulePage()
    {
        yield return new WaitForSeconds(1.5f);
        RulePage.SetActive(true);
    }

    public void Return_R()
    {
        audioSource = gameObject.GetComponent<AudioSource>();
        audioSource.clip = se2;
        audioSource.PlayOneShot(se2);
        StartCoroutine("LoadcloseR");
    }
    IEnumerator LoadcloseR()
    {
        yield return new WaitForSeconds(1.5f);
        RulePage.SetActive(false);
    }

    public void SoundButton()
    {
        audioSource = gameObject.GetComponent<AudioSource>();
        audioSource.clip = se1;
        audioSource.PlayOneShot(se1);
        StartCoroutine("LoadSoundPage");
    }
    IEnumerator LoadSoundPage()
    {
        yield return new WaitForSeconds(1.5f);
        SoundPage.SetActive(true);
    }

    public void Return_S()
    {
        audioSource = gameObject.GetComponent<AudioSource>();
        audioSource.clip = se2;
        audioSource.PlayOneShot(se2);
        StartCoroutine("LoadcloseS");
    }
    IEnumerator LoadcloseS()
    {
        yield return new WaitForSeconds(1.5f);
        SoundPage.SetActive(false);
    }
}
