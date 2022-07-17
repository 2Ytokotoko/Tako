using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuzaiLeft : MonoBehaviour
{
    public GameObject Guzai;
    public GameObject Goal;

    private void OnTriggerStay(Collider other)
    {
        if(Guzai.GetComponent<GuzaiMove>().gHidariCheck == true)
        {
            if (other.CompareTag("Ground"))
            {
                Guzai.GetComponent<GuzaiMove>().LeftCheck = other.gameObject;
                Guzai.GetComponent<GuzaiMove>().DistancegL = Vector3.Distance(other.transform.position, Goal.transform.position);
                Guzai.GetComponent<GuzaiMove>().gHidariCheck = false;
            }

            if (other.CompareTag("Dontgo") || other.CompareTag("Guzai"))
            {
                Guzai.GetComponent<GuzaiMove>().LeftCheck = null;
                Guzai.GetComponent<GuzaiMove>().DistancegL = 0f;
                Guzai.GetComponent<GuzaiMove>().gHidariCheck = false;
            }
        }
    }
}
