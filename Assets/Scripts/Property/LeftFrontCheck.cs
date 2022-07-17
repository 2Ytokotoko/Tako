using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftFrontCheck : MonoBehaviour
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
            property.LeftFront += 1;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Dontgo"))
        {
            property.LeftFront -= 1;
        }
    }
}
