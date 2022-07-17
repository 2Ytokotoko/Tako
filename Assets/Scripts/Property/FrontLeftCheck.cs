using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrontLeftCheck : MonoBehaviour
{
    private Property property;
    public int FL;
    // Start is called before the first frame update
    void Start()
    {
        property = FindObjectOfType<Property>();
    }

    // Update is called once per frame
    void Update()
    {
        FL = property.FrontLeft;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Dontgo"))
        {
            property.FrontLeft += 1;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Dontgo"))
        {
            property.FrontLeft -= 1;
        }
    }
}
