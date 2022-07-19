using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Modoru : MonoBehaviour
{
    public GameObject warn, option;
    public GameObject ExplanationPage, RulePage, SoundPage, GalleryPage;
    public AudioSource se; //戻る


    //スタート_オプション_閉じる
    public void Option_close()
    {
        se.Play();
        option.SetActive(false);
    }
    public void Warn_close()
    {
        se.Play();
        warn.SetActive(false);
    }

    //スタート_やめる_いいえ
    public void Start_Quit_n()
    {
        se.Play();
        StartCoroutine("LoadStartPage");
    }

    IEnumerator LoadStartPage()
    {
        yield return new WaitForSeconds(0.2f);
        SceneManager.LoadScene("Start+Mainmenu");
    }

    //ステージ選択_戻る
    public void StageSelect_SM()
    {
        se.Play();
        Time.timeScale = 1f;
        StartCoroutine("LoadStageSelectSM");
    }

    IEnumerator LoadStageSelectSM()
    {
        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene("Start+Mainmenu");
    }
    public void Return_E()
    {
        ExplanationPage.SetActive(false);
        se.Play();
    }
    public void Return_R()
    {
        RulePage.SetActive(false);
        se.Play();
    }
    public void Return_S()
    {
        SoundPage.SetActive(false);
        se.Play();
    }
    public void Return_G()
    {
        GalleryPage.SetActive(false);
        se.Play();
    }
}