using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrontCheck : MonoBehaviour
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
            Player.GetComponent<CharacterMove2>().Mae = other.gameObject;
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if(Player.GetComponent<CharacterMove2>().MaeCheck == true && Player.GetComponent<CharacterMove2>().Goal != null)
        {
            if (other.CompareTag("Guzai"))
            {
                Player.GetComponent<CharacterMove2>().Front = null;
                Player.GetComponent<CharacterMove2>().DistanceF = 99f;
                Player.GetComponent<CharacterMove2>().MaeCheck = false;
            }

            if (other.CompareTag("Dontgo"))
            {
                Player.GetComponent<CharacterMove2>().Front = null;
                Player.GetComponent<CharacterMove2>().DistanceF = 99f;
                Player.GetComponent<CharacterMove2>().MaeCheck = false;
            }

            if (other.CompareTag("STOP"))
            {
                Player.GetComponent<CharacterMove2>().Front = null;
                Player.GetComponent<CharacterMove2>().DistanceF = 99f;
                Player.GetComponent<CharacterMove2>().MaeCheck = false;
            }

            else if (other.CompareTag("Ground"))
            {
                Player.GetComponent<CharacterMove2>().Front = other.gameObject;
                Player.GetComponent<CharacterMove2>().DistanceF = Vector3.Distance(Player.GetComponent<CharacterMove2>().Front.transform.position, Player.GetComponent<CharacterMove2>().Goal.transform.position);
                Player.GetComponent<CharacterMove2>().MaeCheck = false;
            }
        }

        if (Player.GetComponent<CharacterMove2>().MaeCheck == true && Player.GetComponent<CharacterMove2>().Goal == null)
        {
            if (other.CompareTag("Guzai"))
            {
                Player.GetComponent<CharacterMove2>().Front = null;
            }

            if (other.CompareTag("Dontgo"))
            {
                Player.GetComponent<CharacterMove2>().Front = null;
            }

            if (other.CompareTag("STOP"))
            {
                Player.GetComponent<CharacterMove2>().Front = null;
            }

            else if (other.CompareTag("Ground"))
            {
                Player.GetComponent<CharacterMove2>().Front = other.gameObject;
            }
        }
    }
}
