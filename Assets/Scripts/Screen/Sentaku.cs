using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Sentaku : MonoBehaviour
{
    public GameObject warn, option;
    public GameObject ExplanationPage, RulePage, SoundPage, GalleryPage;
    public AudioSource se; //選択

    //スタート_ステージ選択
    public void SM_StageSelect()
    {
        se.Play();
        StartCoroutine("LoadSM_StageSelect");
    }

    IEnumerator LoadSM_StageSelect()
    {
        yield return new WaitForSeconds(0.2f);
        SceneManager.LoadScene("StageSelect");
    }
    //スタート＿オプション
    public void Start_Option()
    {
        se.Play();
        option.SetActive(true);
    }
    //スタート＿やめる
    public void Start_Quit()
    {
        se.Play();
        warn.SetActive(true);
    }
    //スタート_やめる_はい

    public void Start_Quit_y()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;//ゲームプレイ終了
#else
    Application.Quit();//ゲームプレイ終了
#endif
    }

    //ステージ選択_ステージ1
    public void StageSelect_Stage1()
    {
        se.Play();
        StartCoroutine("LoadStartStage1");
    }

    IEnumerator LoadStartStage1()
    {
        yield return new WaitForSeconds(4f);
        SceneManager.LoadScene("Game");
    }
    //ステージ選択_ステージ2
    public void StageSelect_Stage2()
    {
        se.Play();
        Time.timeScale = 1f;
        StartCoroutine("LoadStartStage2");
    }

    IEnumerator LoadStartStage2()
    {
        yield return new WaitForSeconds(4f);
        SceneManager.LoadScene("Game2");
    }

    //ステージ選択_ステージ3
    public void StageSelect_Stage3()
    {
        se.Play();
        Time.timeScale = 1f;
        StartCoroutine("LoadStartStage3");
    }

    IEnumerator LoadStartStage3()
    {
        yield return new WaitForSeconds(4f);
        SceneManager.LoadScene("Game3");
    }

    //ステージ選択_フリーステージ1
    public void StageSelect_FS1()
    {
        se.Play();
        Time.timeScale = 1f;
        StartCoroutine("LoadStartFS");
    }

    IEnumerator LoadStartFS()
    {
        yield return new WaitForSeconds(4f);
        SceneManager.LoadScene("FreeGame");
    }

    //タイトルに戻る
    public void OnStartButtonClicked()
    {
        se.Play();
        Time.timeScale = 1f;
        StartCoroutine("LoadReturn");
    }
    IEnumerator LoadReturn()
    {
        yield return new WaitForSeconds(0.2f);
        SceneManager.LoadScene("Start+Mainmenu");
    }

    public void ExplanationButton()
    {
        se.Play();
        ExplanationPage.SetActive(true);
    }
    public void RuleButton()
    {
        se.Play();
        RulePage.SetActive(true);
    }
    public void SoundButton()
    {
        se.Play();
        SoundPage.SetActive(true);
    }
    public void GalleryButton()
    {
        se.Play();
        GalleryPage.SetActive(true);
    }
    public void DataReset()
    {
        se.Play();
        PlayerPrefs.SetInt("Highscore1", 0);
        PlayerPrefs.SetInt("Highscore2", 0);
        PlayerPrefs.SetInt("Highscore3", 0);
    }
}