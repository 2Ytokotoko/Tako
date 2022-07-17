using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NorthCheck : MonoBehaviour
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
        if(Player.GetComponent<TakoMove>().NorthCheck == true)
        {
            if (other.CompareTag("Ground"))
            {
                Player.GetComponent<TakoMove>().North = other.gameObject;
                Player.GetComponent<TakoMove>().NorthCheck = false;
            }

            if (other.CompareTag("STOP"))
            {
                Player.GetComponent<TakoMove>().North = null;
                Player.GetComponent<TakoMove>().NorthCheck = false;
            }

            if (other.CompareTag("Dontgo"))
            {
                Player.GetComponent<TakoMove>().North = null;
                Player.GetComponent<TakoMove>().NorthCheck = false;
            }
        }
    }
}
