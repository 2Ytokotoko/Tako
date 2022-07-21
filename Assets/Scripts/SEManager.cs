using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SEManager : MonoBehaviour
{
    private AudioSource audioSource;
    public AudioClip se1; //選択
    public AudioClip se2; //戻る
    public GameObject warn, option;

    //スタート_ステージ選択
    public void SM_StageSelect()
    {
        audioSource = gameObject.GetComponent<AudioSource>();
        audioSource.clip = se1;
        audioSource.Play();
        StartCoroutine("LoadSM_StageSelect");
    }

    IEnumerator LoadSM_StageSelect()
    {
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene("StageSelect");
    }
    //スタート＿オプション
    public void Start_Option()
    {
        audioSource = gameObject.GetComponent<AudioSource>();
        audioSource.clip = se1;
        audioSource.Play();
        StartCoroutine("LoadOptionPage");
    }

    IEnumerator LoadOptionPage()
    {
        yield return new WaitForSeconds(1f);
        option.SetActive(true);
    }
    //スタート_オプション_閉じる
    public void Option_close()
    {
        audioSource = gameObject.GetComponent<AudioSource>();
        audioSource.clip = se2;
        audioSource.Play();
        StartCoroutine("LoadCloseOption");
    }

    IEnumerator LoadCloseOption()
    {
        yield return new WaitForSeconds(1f);
        option.SetActive(false);
    }
    //スタート＿やめる
    public void Start_Quit()
    {
        audioSource = gameObject.GetComponent<AudioSource>();
        audioSource.clip = se1;
        audioSource.Play();
        StartCoroutine("LoadQuit");
    }

    IEnumerator LoadQuit()
    {
        yield return new WaitForSeconds(1f);
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
    //スタート_やめる_いいえ
public void Start_Quit_n()
{
    audioSource = gameObject.GetComponent<AudioSource>();
    audioSource.clip = se2;
    audioSource.Play();
    StartCoroutine("LoadStartPage");
}

IEnumerator LoadStartPage()
{
    yield return new WaitForSeconds(1f);
    SceneManager.LoadScene("Start+Mainmenu");
}

//ステージ選択_ステージ1
public void StageSelect_Stage1()
    {
        audioSource = gameObject.GetComponent<AudioSource>();
        audioSource.clip = se1;
        audioSource.Play();
        StartCoroutine("LoadStartStage1");

    }

    IEnumerator LoadStartStage1()
    {
        yield return new WaitForSeconds(4.25f);
        SceneManager.LoadScene("Game");
    }
    //ステージ選択_ステージ2
    public void StageSelect_Stage2()
    {
        audioSource = gameObject.GetComponent<AudioSource>();
        audioSource.clip = se1;
        audioSource.Play();
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
        audioSource = gameObject.GetComponent<AudioSource>();
        audioSource.clip = se1;
        audioSource.Play();
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
        audioSource = gameObject.GetComponent<AudioSource>();
        audioSource.clip = se1;
        audioSource.Play();
        Time.timeScale = 1f;
        StartCoroutine("LoadStartFS1");
    }

    IEnumerator LoadStartFS1()
    {
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene("FreeGame");
    }

    //ステージ選択_フリーステージ2
    public void StageSelect_FS2()
    {
        audioSource = gameObject.GetComponent<AudioSource>();
        audioSource.clip = se1;
        audioSource.Play();
        Time.timeScale = 1f;
        StartCoroutine("LoadStartFS2");
    }

    IEnumerator LoadStartFS2()
    {
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene("FreeStage2");
    }

    //ステージ選択_フリーステージ3
    public void StageSelect_FS3()
    {
        audioSource = gameObject.GetComponent<AudioSource>();
        audioSource.clip = se1;
        audioSource.Play();
        Time.timeScale = 1f;
        StartCoroutine("LoadStartFS3");
    }

    IEnumerator LoadStartFS3()
    {
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene("FreeStage3");
    }

    //ステージ選択_戻る
    public void StageSelect_SM()
    {
        audioSource = gameObject.GetComponent<AudioSource>();
        audioSource.clip = se2;
        audioSource.Play();
        StartCoroutine("LoadStageSelectSM");
    }

    IEnumerator LoadStageSelectSM()
    {
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene("Start+Mainmenu");
    }

    //タイトルに戻る
    public void OnStartButtonClicked()
    {
        SceneManager.LoadScene("Start+Mainmenu");
    }
    public void MuteStageselect()
    {
        SceneManager.LoadScene("StageSelect");
    }
    public void MuteGameStart()
    {
        SceneManager.LoadScene("Game");
    }
}