using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Stage1 : MonoBehaviour
{
    public void OnStartButtonClicked()
    {
        SceneManager.LoadScene("Game");
    }
}