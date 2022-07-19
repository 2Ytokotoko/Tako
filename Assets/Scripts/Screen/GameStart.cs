using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameStart: MonoBehaviour
{
	[SerializeField]
	private Text _textCountdown;

	[SerializeField]
	private Image _imageMask;

	public GameObject Odai1, Odai2, Odai3,free;
	void Start()
	{
		_textCountdown.text = "";
	}

	public void Stage1()
	{
		Time.timeScale = 1f;
		StartCoroutine(C_Stage1());
	}

	IEnumerator C_Stage1()
	{
		yield return new WaitForSeconds(0.5f);
		Odai1.SetActive(true);
		_imageMask.gameObject.SetActive(true);
		_textCountdown.gameObject.SetActive(true);

		_textCountdown.text = "3";
		yield return new WaitForSeconds(1.0f);

		_textCountdown.text = "2";
		yield return new WaitForSeconds(1.0f);

		_textCountdown.text = "1";
		yield return new WaitForSeconds(1.0f);

		_textCountdown.text = "START!";
		yield return new WaitForSeconds(0.5f);
		_textCountdown.text = "";
		_textCountdown.gameObject.SetActive(false);
		_imageMask.gameObject.SetActive(false);
		Odai1.SetActive(false);
		SceneManager.LoadScene("Game");
	}
	public void Stage2()
	{
		Time.timeScale = 1f;
		StartCoroutine(C_Stage2());
	}

	IEnumerator C_Stage2()
	{
		yield return new WaitForSeconds(0.5f);
		Odai2.SetActive(true);
		_imageMask.gameObject.SetActive(true);
		_textCountdown.gameObject.SetActive(true);

		_textCountdown.text = "3";
		yield return new WaitForSeconds(1.0f);

		_textCountdown.text = "2";
		yield return new WaitForSeconds(1.0f);

		_textCountdown.text = "1";
		yield return new WaitForSeconds(1.0f);

		_textCountdown.text = "START!";
		yield return new WaitForSeconds(0.5f);

		_textCountdown.text = "";
		_textCountdown.gameObject.SetActive(false);
		_imageMask.gameObject.SetActive(false);
		Odai2.SetActive(false);
		SceneManager.LoadScene("GameStage2");
	}
	public void Stage3()
	{
		Time.timeScale = 1f;
		StartCoroutine(C_Stage3());
	}

	IEnumerator C_Stage3()
	{
		yield return new WaitForSeconds(0.5f);
		Odai3.SetActive(true);
		_imageMask.gameObject.SetActive(true);
		_textCountdown.gameObject.SetActive(true);

		_textCountdown.text = "3";
		yield return new WaitForSeconds(1.0f);

		_textCountdown.text = "2";
		yield return new WaitForSeconds(1.0f);

		_textCountdown.text = "1";
		yield return new WaitForSeconds(1.0f);

		_textCountdown.text = "START!";
		yield return new WaitForSeconds(0.5f);

		_textCountdown.text = "";
		_textCountdown.gameObject.SetActive(false);
		_imageMask.gameObject.SetActive(false);
		Odai3.SetActive(false);
		SceneManager.LoadScene("GameStage3");
	}
	public void Freestage()
	{
		Time.timeScale = 1f;
		StartCoroutine(C_Freestage());
	}

	IEnumerator C_Freestage()
	{
		yield return new WaitForSeconds(0.5f);
		free.SetActive(true);
		_imageMask.gameObject.SetActive(true);
		_textCountdown.gameObject.SetActive(true);

		_textCountdown.text = "3";
		yield return new WaitForSeconds(1.0f);

		_textCountdown.text = "2";
		yield return new WaitForSeconds(1.0f);

		_textCountdown.text = "1";
		yield return new WaitForSeconds(1.0f);

		_textCountdown.text = "START!";
		yield return new WaitForSeconds(0.5f);

		_textCountdown.text = "";
		_textCountdown.gameObject.SetActive(false);
		_imageMask.gameObject.SetActive(false);
		free.SetActive(false);
		SceneManager.LoadScene("FreeStage");
	}

}