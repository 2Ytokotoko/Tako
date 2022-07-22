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
    public GameObject Option, RulePage, SoundPage;
    private AudioSource audioSource;
    public AudioSource sentaku, modoru;

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
        sentaku.Play();
    }
    public void ExplanationButtonClick()
    {
        sentaku.Play();
        Option.SetActive(false);
        ExplanationPage.SetActive(true);
    }
    public void RuleButtonClick()
    {
        sentaku.Play();
        Option.SetActive(false);
        RulePage.SetActive(true);
    }
    public void OptionButtonClick()
    {
        sentaku.Play();
        PauseScreen.SetActive(false);
        Option.SetActive(true);
    }
    public void AdjustmentButtonClick()
    {
        sentaku.Play();
        AdjustmentPage.SetActive(true);
        Option.SetActive(false);
    }

    public void Return_A()
    {
        modoru.Play();
        AdjustmentPage.SetActive(false);
        Option.SetActive(true);
    }
    public void QuitButtonClick()
    {
        sentaku.Play();
        PauseScreen.SetActive(false);
        WarningPage.SetActive(true);
    }
    public void Return_W()
    {
        modoru.Play();
        WarningPage.SetActive(false);
        PauseScreen.SetActive(true);
    }
    public void Return_Option()
    {
        modoru.Play();
        ExplanationPage.SetActive(false);
        RulePage.SetActive(false);
        Option.SetActive(true);
    }
    public void Return_O()
    {
        modoru.Play();
        Option.SetActive(false);
        PauseScreen.SetActive(true);
    }
    public void Quit()
    {
        sentaku.Play();
        Time.timeScale = 1f;
        StartCoroutine("LoadCloseOption");
    }

    IEnumerator LoadCloseOption()
    {
        yield return new WaitForSeconds(0.2f);
        SceneManager.LoadScene("StageSelect");
    }

    public void SoundButtonClick()
    {
        sentaku.Play();
        SoundPage.SetActive(true);
        Option.SetActive(false);
    }
    public void Return_S()
    {
        modoru.Play();
        SoundPage.SetActive(false);
        Option.SetActive(true);
    }
}