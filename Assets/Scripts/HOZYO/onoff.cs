using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onoff : MonoBehaviour
{
    public GameObject UP;
    public GameObject This;
    void Start()
    {
        UP.SetActive(false);
        This.SetActive(true);
    }

    void OnTriggerEnter(Collider other)
    {

        This.SetActive(false);
        UP.SetActive(true);

    }

    void OnTriggerExit(Collider other)
    {

        UP.SetActive(false);
        This.SetActive(true);

    }
}