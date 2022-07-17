using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuzaiRight : MonoBehaviour
{
    public GameObject Guzai;
    public GameObject Goal;

    private void OnTriggerStay(Collider other)
    {
        if(Guzai.GetComponent<GuzaiMove>().gMigiCheck == true)
        {
            if (other.CompareTag("Ground"))
            {
                Guzai.GetComponent<GuzaiMove>().RightCheck = other.gameObject;
                Guzai.GetComponent<GuzaiMove>().DistancegR = Vector3.Distance(other.transform.position, Goal.transform.position);
                Guzai.GetComponent<GuzaiMove>().gMigiCheck = false;
            }

            if (other.CompareTag("Dontgo") || other.CompareTag("Guzai"))
            {
                Guzai.GetComponent<GuzaiMove>().RightCheck = null;
                Guzai.GetComponent<GuzaiMove>().DistancegR = 0f;
                Guzai.GetComponent<GuzaiMove>().gMigiCheck = false;
            }
        }
    }
}
