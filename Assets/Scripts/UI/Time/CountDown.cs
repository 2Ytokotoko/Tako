using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class CountDown : MonoBehaviour
{
    //カウントダウン
    public float countdown = 10.0f;

    //時間を表示するText型の変数
    public Text timeText;
    public GameObject Stop; //ポーズ中を表示してくれるテキスト
    public GameObject Pause;//ポーズボタン
    public GameObject Continuation;//スタートボタン
    public GameObject PauseScreen;//ポーズ画面
    private AudioSource audioSource;
    public AudioSource se1,se2; 

    void Update()
    {
        //時間をカウントする
        countdown += Time.deltaTime;
        //時間を表示する

        timeText.text = "経過時間:"+countdown.ToString("f0")+"秒";
    }
  
    public void StopGame()
    {
        se1.Play(); ;
        Time.timeScale = 0f;
        PauseScreen.SetActive(true);
        Pause.SetActive(false);
    }    // Update is called once per frame

    public void ReStartGame()
    {
        se1.Play();
        Time.timeScale = 1f;
        StartCoroutine("Coroutine");
    }

    IEnumerator Coroutine()
    {
        yield return new WaitForSeconds(0.1f);
        PauseScreen.SetActive(false);
        Pause.SetActive(true);
        //Continuation.SetActive(false);
        //Stop.SetActive(false);

    }
}
