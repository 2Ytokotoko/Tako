using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightCheck : MonoBehaviour
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
            Player.GetComponent<CharacterMove2>().Migi = other.gameObject;
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (Player.GetComponent<CharacterMove2>().MigiCheck == true && Player.GetComponent<CharacterMove2>().Goal != null)
        {
            if (other.CompareTag("Guzai"))
            {
                Player.GetComponent<CharacterMove2>().Right = null;
                Player.GetComponent<CharacterMove2>().DistanceR = 99f;
                Player.GetComponent<CharacterMove2>().MigiCheck = false;
            }

            if (other.CompareTag("Dontgo"))
            {
                Player.GetComponent<CharacterMove2>().Right = null;
                Player.GetComponent<CharacterMove2>().DistanceR = 99f;
                Player.GetComponent<CharacterMove2>().MigiCheck = false;
            }

            if (other.CompareTag("STOP"))
            {
                Player.GetComponent<CharacterMove2>().Right = null;
                Player.GetComponent<CharacterMove2>().DistanceR = 99f;
                Player.GetComponent<CharacterMove2>().MigiCheck = false;
            }

            else if (other.CompareTag("Ground"))
            {
                Player.GetComponent<CharacterMove2>().Right = other.gameObject;
                Player.GetComponent<CharacterMove2>().DistanceR = Vector3.Distance(Player.GetComponent<CharacterMove2>().Right.transform.position, Player.GetComponent<CharacterMove2>().Goal.transform.position);
                Player.GetComponent<CharacterMove2>().MigiCheck = false;
            }
        }

        if (Player.GetComponent<CharacterMove2>().MigiCheck == true && Player.GetComponent<CharacterMove2>().Goal == null)
        {
            if (other.CompareTag("Guzai"))
            {
                Player.GetComponent<CharacterMove2>().Right = null;
            }

            if (other.CompareTag("Dontgo"))
            {
                Player.GetComponent<CharacterMove2>().Right = null;
            }

            if (other.CompareTag("STOP"))
            {
                Player.GetComponent<CharacterMove2>().Right = null;
            }

            else if (other.CompareTag("Ground"))
            {
                Player.GetComponent<CharacterMove2>().Right = other.gameObject;
            }
        }
    }
}
