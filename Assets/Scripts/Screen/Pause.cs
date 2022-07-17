using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
    public GameObject GameUI;
    public GameObject ExplanationPage;
    public GameObject PauseScreen;
    public GameObject AdjustmentPage;
    public GameObject WarningPage;
    public GameObject Option, RulePage,SoundPage;
    private AudioSource audioSource;
    public AudioClip se1,se2;

    void Start()
    {
        ExplanationPage.SetActive(false);
        AdjustmentPage.SetActive(false);
        WarningPage.SetActive(false);
        Option.SetActive(false);
        RulePage.SetActive(false);
        SoundPage.SetActive(false);
    }
    public void StartButtonClick()
    {
        audioSource = gameObject.GetComponent<AudioSource>();
        audioSource.clip = se1;
        audioSource.Play();
    }
    public void ExplanationButtonClick()
    {
        audioSource = gameObject.GetComponent<AudioSource>();
        audioSource.clip = se1;
        audioSource.Play();
        Option.SetActive(false);
        ExplanationPage.SetActive(true);
    }
    public void RuleButtonClick()
    {
        audioSource = gameObject.GetComponent<AudioSource>();
        audioSource.clip = se1;
        audioSource.Play();
        Option.SetActive(false);
        RulePage.SetActive(true);
    }
    public void OptionButtonClick()
    {
        audioSource = gameObject.GetComponent<AudioSource>();
        audioSource.clip = se1;
        audioSource.Play();
        PauseScreen.SetActive(false);
        Option.SetActive(true);
    }
    public void AdjustmentButtonClick()
    {
        audioSource = gameObject.GetComponent<AudioSource>();
        audioSource.clip = se1;
        audioSource.Play();
        AdjustmentPage.SetActive(true);
        Option.SetActive(false);
    }

    public void Return_A()
    {
        audioSource = gameObject.GetComponent<AudioSource>();
        audioSource.clip = se2;
        audioSource.Play();
        AdjustmentPage.SetActive(false);
        Option.SetActive(true);
    }
    public void QuitButtonClick()
    {
        audioSource = gameObject.GetComponent<AudioSource>();
        audioSource.clip = se1;
        audioSource.Play();
        PauseScreen.SetActive(false);
        WarningPage.SetActive(true);
    }
    public void Return_W()
    {
        audioSource = gameObject.GetComponent<AudioSource>();
        audioSource.clip = se2;
        audioSource.Play();
        WarningPage.SetActive(false);
        PauseScreen.SetActive(true);
    }
    public void Return_Option()
    {
        audioSource = gameObject.GetComponent<AudioSource>();
        audioSource.clip = se2;
        audioSource.Play();
        ExplanationPage.SetActive(false);
        RulePage.SetActive(false);
        Option.SetActive(true);
    }
    public void Return_O()
    {
        audioSource = gameObject.GetComponent<AudioSource>();
        audioSource.clip = se2;
        audioSource.Play();
        Option.SetActive(false);
        PauseScreen.SetActive(true);
    }
    public void Quit()
    {
        audioSource = gameObject.GetComponent<AudioSource>();
        audioSource.clip = se1;
        audioSource.Play();
        Time.timeScale = 1f;
        StartCoroutine("LoadCloseOption");
    }

    IEnumerator LoadCloseOption()
    {
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene("StageSelect");
    }

    public void SoundButtonClick()
    {
        audioSource = gameObject.GetComponent<AudioSource>();
        audioSource.clip = se1;
        audioSource.Play();
        SoundPage.SetActive(true);
        Option.SetActive(false);
    }
    public void Return_S()
    {
        audioSource = gameObject.GetComponent<AudioSource>();
        audioSource.clip = se2;
        audioSource.Play();
        SoundPage.SetActive(false);
        Option.SetActive(true);
    }
}
