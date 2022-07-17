using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuzaiFront : MonoBehaviour
{
    public GameObject Guzai;
    public GameObject Goal;

    private void OnTriggerStay(Collider other)
    {
        if(Guzai.GetComponent<GuzaiMove>().gMaeCheck == true)
        {
            if (other.CompareTag("Ground"))
            {
                Guzai.GetComponent<GuzaiMove>().FrontCheck = other.gameObject;
                Guzai.GetComponent<GuzaiMove>().DistancegF = Vector3.Distance(other.transform.position, Goal.transform.position);
                Guzai.GetComponent<GuzaiMove>().gMaeCheck = false;
            }

            if (other.CompareTag("Dontgo") || other.CompareTag("Guzai"))
            {
                Guzai.GetComponent<GuzaiMove>().FrontCheck = null;
                Guzai.GetComponent<GuzaiMove>().DistancegF = 0f;
                Guzai.GetComponent<GuzaiMove>().gMaeCheck = false;
            }
        }
    }
}
