using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EastCheck : MonoBehaviour
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
        if (Player.GetComponent<TakoMove>().EastCheck == true)
        {
            if (other.CompareTag("Ground"))
            {
                Player.GetComponent<TakoMove>().East = other.gameObject;
                Player.GetComponent<TakoMove>().EastCheck = false;
            }

            if (other.CompareTag("STOP"))
            {
                Player.GetComponent<TakoMove>().East = null;
                Player.GetComponent<TakoMove>().EastCheck = false;
            }

            if (other.CompareTag("Dontgo"))
            {
                Player.GetComponent<TakoMove>().East = null;
                Player.GetComponent<TakoMove>().EastCheck = false;
            }
        }
    }
}
