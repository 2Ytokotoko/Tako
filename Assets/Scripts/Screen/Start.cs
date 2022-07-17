using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Start : MonoBehaviour
{
    private AudioSource audioSource;
    public AudioClip se;
    public void OnStartButtonClicked()
    {
        Time.timeScale = 1f;
        audioSource = gameObject.GetComponent<AudioSource>();
        audioSource.clip = se;
        audioSource.PlayOneShot(se); StartCoroutine("LoadCoroutine");
    }

    IEnumerator LoadCoroutine()
    {
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene("Start+Mainmenu");
    }
}
