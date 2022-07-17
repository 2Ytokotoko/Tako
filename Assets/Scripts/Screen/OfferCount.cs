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
        Debug.Log("’B¬‚µ‚½‚¨‘è‚Ì”‚Í"+ count.ToString() + "ŒÂ");
        if(count == 3)
        {
            Notplay.SetActive(false);
        }
    }

}
