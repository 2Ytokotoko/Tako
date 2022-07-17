using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sousasetumei : MonoBehaviour
{
    public GameObject ExplanationPage;
    public void ExplanationButtonClick()
    {
        ExplanationPage.SetActive(true);
    }
    public void Return_E()
    {
        ExplanationPage.SetActive(false);
    }
}
