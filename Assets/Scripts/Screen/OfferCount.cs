using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OfferCount : MonoBehaviour
{
    public GameObject Notplay;
    private void Update()
    {
       int check = GameObject.FindGameObjectsWithTag("Check").Length;
       int count = 3 - check;
        Debug.Log("達成したお題の数は"+ count.ToString() + "個");
        if(count == 3)
        {
            Notplay.SetActive(false);
        }
    }

}
