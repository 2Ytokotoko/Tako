using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Sentaku : MonoBehaviour
{
    public GameObject warn, option;
    public GameObject ExplanationPage, RulePage, SoundPage, GalleryPage;
    public AudioSource se; //�I��

    //�X�^�[�g_�X�e�[�W�I��
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
    //�X�^�[�g�Q�I�v�V����
    public void Start_Option()
    {
        se.Play();
        option.SetActive(true);
    }
    //�X�^�[�g�Q��߂�
    public void Start_Quit()
    {
        se.Play();
        warn.SetActive(true);
    }
    //�X�^�[�g_��߂�_�͂�

    public void Start_Quit_y()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;//�Q�[���v���C�I��
#else
    Application.Quit();//�Q�[���v���C�I��
#endif
    }

    //�X�e�[�W�I��_�X�e�[�W1
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
    //�X�e�[�W�I��_�X�e�[�W2
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

    //�X�e�[�W�I��_�X�e�[�W3
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

    //�X�e�[�W�I��_�t���[�X�e�[�W1
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

    //�^�C�g���ɖ߂�
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