using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SEManager : MonoBehaviour
{
    private AudioSource audioSource;
    public AudioClip se1; //�I��
    public AudioClip se2; //�߂�
    public GameObject warn, option;

    //�X�^�[�g_�X�e�[�W�I��
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
    //�X�^�[�g�Q�I�v�V����
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
    //�X�^�[�g_�I�v�V����_����
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
    //�X�^�[�g�Q��߂�
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
    //�X�^�[�g_��߂�_�͂�

    public void Start_Quit_y()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;//�Q�[���v���C�I��
#else
    Application.Quit();//�Q�[���v���C�I��
#endif
    }
    //�X�^�[�g_��߂�_������
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

//�X�e�[�W�I��_�X�e�[�W1
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
    //�X�e�[�W�I��_�X�e�[�W2
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

    //�X�e�[�W�I��_�X�e�[�W3
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

    //�X�e�[�W�I��_�t���[�X�e�[�W1
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

    //�X�e�[�W�I��_�t���[�X�e�[�W2
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

    //�X�e�[�W�I��_�t���[�X�e�[�W3
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

    //�X�e�[�W�I��_�߂�
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

    //�^�C�g���ɖ߂�
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