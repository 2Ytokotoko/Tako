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
        Debug.Log("�B����������̐���"+ count.ToString() + "��");
        if(count == 3)
        {
            Notplay.SetActive(false);
        }
    }

}
