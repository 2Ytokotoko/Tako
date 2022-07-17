using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrontRightCheck : MonoBehaviour
{
    private Property property;
    public int FR;
    // Start is called before the first frame update
    void Start()
    {
        property = FindObjectOfType<Property>();
    }

    // Update is called once per frame
    void Update()
    {
        FR = property.FrontRight;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Dontgo"))
        {
            property.FrontRight += 1;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Dontgo"))
        {
            property.FrontRight -= 1;
        }
    }
}
