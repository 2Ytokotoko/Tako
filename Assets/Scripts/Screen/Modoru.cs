using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Modoru : MonoBehaviour
{
    public GameObject warn, option;
    public GameObject ExplanationPage, RulePage, SoundPage, GalleryPage;
    public AudioSource se; //�߂�


    //�X�^�[�g_�I�v�V����_����
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

    //�X�^�[�g_��߂�_������
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

    //�X�e�[�W�I��_�߂�
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