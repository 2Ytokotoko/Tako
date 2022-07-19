using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OdaiName : MonoBehaviour
{
    public Text NameText;
  //  public bool flag;
    // Start is called before the first frame update
    void Start()
    {
        //flag = false;
    }

    // Update is called once per frame
    void Update()
    {
     //   flag = true;
        int check = GameObject.FindGameObjectsWithTag("Check").Length;
        int count = 3 - check;
        if (count ==3)
        {
            NameText.text = ("Ç›ÇÒÇ»ëÂçDÇ´ìÇógÇ∞");
        }
        if (count == 2)
        {
            NameText.text = ("Ç†Ç∆è≠ÇµÇ≈ñûì_");
        }
        if (count == 1)
        {
            NameText.text = ("Ç‡Ç§ÇøÇÂÇ¡Ç∆äÊí£ÇÎÇ§");
        }
        if (count == 0)
        {
            NameText.text = ("Ç‡Ç¡Ç∆äÊí£ÇËÇ‹ÇµÇÂÇ§");
        }
        NameText.text += "ïŸìñ";
    }
}
