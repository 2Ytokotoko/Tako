using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Restart : MonoBehaviour
{
    private AudioSource audioSource;
    public AudioSource sentaku;
    [SerializeField]
    private Text _textCountdown;

    [SerializeField]
    private Image _imageMask;
    public GameObject Pause;

        public void OnStartButtonClicked()
    {
        Time.timeScale = 1f;
        sentaku.Play();
        StartCoroutine(CountdownCoroutine());

        IEnumerator CountdownCoroutine()
        {
            yield return new WaitForSeconds(1.0f);
            _imageMask.gameObject.SetActive(true);
            _textCountdown.gameObject.SetActive(true);

            _textCountdown.text = "3";
            yield return new WaitForSeconds(1.0f);

            _textCountdown.text = "2";
            yield return new WaitForSeconds(1.0f);

            _textCountdown.text = "1";
            yield return new WaitForSeconds(1.0f);

            _textCountdown.text = "START!";
            yield return new WaitForSeconds(1.0f);

            _textCountdown.text = "";
            _textCountdown.gameObject.SetActive(false);
            _imageMask.gameObject.SetActive(false);
            Pause.SetActive(false);
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
