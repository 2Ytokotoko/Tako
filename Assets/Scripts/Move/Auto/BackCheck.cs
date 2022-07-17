using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackCheck : MonoBehaviour
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

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ground"))
        {
            Player.GetComponent<CharacterMove2>().Usiro = other.gameObject;
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (Player.GetComponent<CharacterMove2>().UsiroCheck == true && Player.GetComponent<CharacterMove2>().Goal != null)
        {
            if (other.CompareTag("Guzai"))
            {
                Player.GetComponent<CharacterMove2>().Back = null;
                Player.GetComponent<CharacterMove2>().DistanceB = 99f;
                Player.GetComponent<CharacterMove2>().UsiroCheck = false;
            }

            if (other.CompareTag("Dontgo"))
            {
                Player.GetComponent<CharacterMove2>().Back = null;
                Player.GetComponent<CharacterMove2>().DistanceB = 99f;
                Player.GetComponent<CharacterMove2>().UsiroCheck = false;
            }

            if (other.CompareTag("STOP"))
            {
                Player.GetComponent<CharacterMove2>().Back = null;
                Player.GetComponent<CharacterMove2>().DistanceB = 99f;
                Player.GetComponent<CharacterMove2>().UsiroCheck = false;
            }

            else if (other.CompareTag("Ground"))
            {
                Player.GetComponent<CharacterMove2>().Back = other.gameObject;
                Player.GetComponent<CharacterMove2>().DistanceB = Vector3.Distance(Player.GetComponent<CharacterMove2>().Back.transform.position, Player.GetComponent<CharacterMove2>().Goal.transform.position);
                Player.GetComponent<CharacterMove2>().UsiroCheck = false;
            }
        }

        if (Player.GetComponent<CharacterMove2>().UsiroCheck == true && Player.GetComponent<CharacterMove2>().Goal == null)
        {
            if (other.CompareTag("Guzai"))
            {
                Player.GetComponent<CharacterMove2>().Back = null;
            }

            if (other.CompareTag("Dontgo"))
            {
                Player.GetComponent<CharacterMove2>().Back = null;
            }

            if (other.CompareTag("STOP"))
            {
                Player.GetComponent<CharacterMove2>().Back = null;
            }

            else if (other.CompareTag("Ground"))
            {
                Player.GetComponent<CharacterMove2>().Back = other.gameObject;
            }
        }
    }
}
