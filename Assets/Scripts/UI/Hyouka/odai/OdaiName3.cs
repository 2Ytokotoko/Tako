using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OdaiName3 : MonoBehaviour
{
    public Text NameText;

    public Sprite Hyouka0;
    public Sprite Hyouka1;
    public Sprite Hyouka2;
    public Sprite Hyouka3;
    public Sprite Hyouka4;
    public Sprite Hyouka5;

    public Image myPhoto;
    //  public bool flag;
    // Start is called before the first frame update
    void Start()
    {
        myPhoto = GameObject.Find("Kyaku").GetComponent<Image>();
        //flag = false;
    }

    // Update is called once per frame
    void Update()
    {
        //   flag = true;
        int check = GameObject.FindGameObjectsWithTag("Check").Length;
        int count = 5 - check;
        if (count == 5)
        {
            myPhoto.sprite = Hyouka5;
            NameText.text = ("いっぱい食べて長生きしてね");
        }
        if (count == 4)
        {
            myPhoto.sprite = Hyouka4;
            NameText.text = ("もう少しで満点");
        }
        if (count == 3)
        {
            myPhoto.sprite = Hyouka2;
            NameText.text = ("半分はできている");
        }
        if (count == 2)
        {
            myPhoto.sprite = Hyouka1;
            NameText.text = ("もう少しで半分");
        }
        if (count == 1)
        {
            myPhoto.sprite = Hyouka0;
            NameText.text = ("もっと頑張りましょう");
        }
        if (count == 0)
        {
            myPhoto.sprite = Hyouka0;
            NameText.text = ("もっと頑張りましょう");
        }
        NameText.text += "弁当";
    }
}