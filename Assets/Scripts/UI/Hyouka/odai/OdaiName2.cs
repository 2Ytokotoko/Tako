using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OdaiName2 : MonoBehaviour
{
    public Text NameText;

    public Sprite Hyouka0;
    public Sprite Hyouka1;
    public Sprite Hyouka2;
    public Sprite Hyouka3;    
    public Sprite Hyouka4;
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
        int count = 4- check;
        if (count == 4)
        {
            myPhoto.sprite = Hyouka4;
            NameText.text = ("ì¡ê∑çDÇ´Ç»Ç‡ÇÃÇæÇØïŸìñ");
        }
        if (count == 3)
        {
            myPhoto.sprite = Hyouka3;
            NameText.text = ("Ç‡Ç§è≠ÇµÇ≈ñûì_");
        }
        if (count == 2)
        {
            myPhoto.sprite = Hyouka2;
            NameText.text = ("îºï™ÇÕÇ≈Ç´ÇƒÇ¢ÇÈ");
        }
        if (count == 1)
        {
            myPhoto.sprite = Hyouka1;
            NameText.text = ("Ç‡Ç§ÇøÇÂÇ¡Ç∆äÊí£ÇÎÇ§");
        }
        if (count == 0)
        {
            myPhoto.sprite = Hyouka0;
            NameText.text = ("Ç‡Ç¡Ç∆äÊí£ÇËÇ‹ÇµÇÂÇ§");
        }
        NameText.text += "ïŸìñ";
    }
}