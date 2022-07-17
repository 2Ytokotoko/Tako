using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GNorthCheck : MonoBehaviour
{
    public GameObject Guzai;
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
        if (Guzai.transform.parent == null)
        {
            if (other.CompareTag("Player"))
            {
                Guzai.GetComponent<LiftGuzai>().NorthCheck = true;
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Guzai.GetComponent<LiftGuzai>().NorthCheck = false;
        }
    }
}
