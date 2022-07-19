using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sousasetsumei : MonoBehaviour
{
    public GameObject ExplanationPage,RulePage,SoundPage,GalleryPage;
    public void ExplanationButton()
    {
        ExplanationPage.SetActive(true);
        }

    public void Return_E()
    {
        ExplanationPage.SetActive(false);
    }

    public void RuleButton()
    {
        RulePage.SetActive(true);
    }

    public void Return_R()
    {
        RulePage.SetActive(false);
    }

    public void SoundButton()
    {
        SoundPage.SetActive(true);
    }

    public void Return_S()
    {
        SoundPage.SetActive(false);
    }
    public void GalleryButton()
    {
        GalleryPage.SetActive(true);
    }

    public void Return_G()
    {
        GalleryPage.SetActive(false);
    }
}
