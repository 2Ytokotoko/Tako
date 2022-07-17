using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Option : MonoBehaviour
{
    public GameObject Explanation,Rule,Sound,option;
    private AudioSource audioSource;
    public AudioClip se1; //‘I‘ð
    public AudioClip se2; //–ß‚é
    public void ExplanationButton()
    {
        audioSource = gameObject.GetComponent<AudioSource>();
        audioSource.clip = se1;
        audioSource.PlayOneShot(se1);
        StartCoroutine("LoadExplanationPage");
    }
        IEnumerator LoadExplanationPage()
        {
            yield return new WaitForSeconds(1f);
            Explanation.SetActive(true);
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
        yield return new WaitForSeconds(1f);
        Explanation.SetActive(true);
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
        yield return new WaitForSeconds(1f);
        Sound.SetActive(true);
    }

    public void Return_Option()
    {
        audioSource = gameObject.GetComponent<AudioSource>();
        audioSource.clip = se2;
        audioSource.PlayOneShot(se2);
        StartCoroutine("Loadclosed");
    }
    IEnumerator Loadclosed()
    {
        yield return new WaitForSeconds(1f);
        Explanation.SetActive(false);
        Rule.SetActive(false); 
        Sound.SetActive(false);
    }
    public void Optionclose()
    {
        audioSource = gameObject.GetComponent<AudioSource>();
        audioSource.clip = se2;
        audioSource.PlayOneShot(se2);
        StartCoroutine("Loadoptionclose");
    }
    IEnumerator Loadoptionclose()
    {
        yield return new WaitForSeconds(1f);
        option.SetActive(false);
    }
}
