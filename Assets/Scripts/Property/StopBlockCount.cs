using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopBlockCount : MonoBehaviour
{
    private Property property;
    // Start is called before the first frame update
    void Start()
    {
        property = FindObjectOfType<Property>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Dontgo"))
        {
            property.FrontLeft += 1;
            Debug.Log(property.FrontLeft);
        } 
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Dontgo"))
        {
            property.FrontLeft -= 1;
            Debug.Log(property.FrontLeft);
        }
    }
}
