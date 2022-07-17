using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OdaiName : MonoBehaviour
{
    public Text NameText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int check = GameObject.FindGameObjectsWithTag("Check").Length;
        int count = 3 - check;
        if (count ==3)
        {
            NameText.text = ("みんな大好き唐揚げ");
        }
        if (count == 2)
        {
            NameText.text = ("あと少しで満点");
        }
        if (count == 1)
        {
            NameText.text = ("もうちょっと頑張ろう");
        }
        if (count == 0)
        {
            NameText.text = ("もっと頑張りましょう");
        }
        NameText.text += "弁当";
    }
}
