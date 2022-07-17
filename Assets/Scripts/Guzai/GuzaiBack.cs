using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuzaiBack : MonoBehaviour
{
    public GameObject Guzai;
    public GameObject Goal;

    private void OnTriggerStay(Collider other)
    {
        if(Guzai.GetComponent<GuzaiMove>().gUsiroCheck == true)
        {
            if (other.CompareTag("Ground"))
            {
                Guzai.GetComponent<GuzaiMove>().BackCheck = other.gameObject;
                Guzai.GetComponent<GuzaiMove>().DistancegB = Vector3.Distance(other.transform.position, Goal.transform.position);
                Guzai.GetComponent<GuzaiMove>().gUsiroCheck = false;
            }

            if (other.CompareTag("Dontgo") || other.CompareTag("Guzai"))
            {
                Guzai.GetComponent<GuzaiMove>().BackCheck = null;
                Guzai.GetComponent<GuzaiMove>().DistancegB = 0f;
                Guzai.GetComponent<GuzaiMove>().gUsiroCheck = false;
            }
        }
    }
}
