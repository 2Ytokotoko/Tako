using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SouthCheck : MonoBehaviour
{
    public GameObject Player;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerStay(Collider other)
    {
        if (Player.GetComponent<TakoMove>().SouthCheck == true)
        {
            if (other.CompareTag("Ground"))
            {
                Player.GetComponent<TakoMove>().South = other.gameObject;
                Player.GetComponent<TakoMove>().SouthCheck = false;
            }

            if (other.CompareTag("STOP"))
            {
                Player.GetComponent<TakoMove>().South = null;
                Player.GetComponent<TakoMove>().SouthCheck = false;
            }

            if (other.CompareTag("Dontgo"))
            {
                Player.GetComponent<TakoMove>().South = null;
                Player.GetComponent<TakoMove>().SouthCheck = false;
            }
        }
    }
}
