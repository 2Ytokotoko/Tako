using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WestCheck : MonoBehaviour
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
        if (Player.GetComponent<TakoMove>().WestCheck == true)
        {
            if (other.CompareTag("Ground"))
            {
                Player.GetComponent<TakoMove>().West = other.gameObject;
                Player.GetComponent<TakoMove>().WestCheck = false;
            }

            if (other.CompareTag("STOP"))
            {
                Player.GetComponent<TakoMove>().West = null;
                Player.GetComponent<TakoMove>().WestCheck = false;
            }

            if (other.CompareTag("Dontgo"))
            {
                Player.GetComponent<TakoMove>().West = null;
                Player.GetComponent<TakoMove>().WestCheck = false;
            }
        }
    }
}
