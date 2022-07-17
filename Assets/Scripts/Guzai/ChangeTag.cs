using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeTag : MonoBehaviour
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
        if(Guzai.GetComponent<GuzaiMove>().selected == false)
        {
            if (other.CompareTag("Ground"))
            {
                other.gameObject.tag = "Dontgo";
            }
        }

        if(Guzai.GetComponent<GuzaiMove>().selected == true)
        {
            if (other.CompareTag("Dontgo"))
            {
                other.gameObject.tag = "Ground";
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Dontgo"))
        {
           other. gameObject.tag = "Ground";
        }
    }
}
