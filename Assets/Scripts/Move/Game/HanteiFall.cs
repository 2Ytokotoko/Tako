using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HanteiFall : MonoBehaviour
{
    bool Fall = true;
    public string Tag;
    GameObject Child;
    // Start is called before the first frame update
    void Start()
    {
        Child = gameObject.transform.GetChild(0).gameObject;
        Child.tag = Tag;
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("TOMATO") || other.CompareTag("SYUUMAI") || other.CompareTag("MIITOBOURU")
            || other.CompareTag("NAPORITANN") || other.CompareTag("PASUTA") || other.CompareTag("TAMAGOYAKI")
            || other.CompareTag("HANNBAAGU") || other.CompareTag("EBIHURAI") || other.CompareTag("EBIHURAI2"))
        {
            transform.position = new Vector3(transform.position.x, other.transform.position.y + 2, transform.position.z);
        }

        if (other.CompareTag("KARAAGE"))
        {
            transform.position = new Vector3(transform.position.x, other.transform.position.y + 4, transform.position.z);
        }

        /*if (other.CompareTag("TOMATO") || other.CompareTag("HANNBAAGU") || other.CompareTag("TAMAGOYAKI") || other.CompareTag("SYUUMAI"))
        {
            transform.position = new Vector3(transform.position.x, other.transform.position.y + 3, transform.position.z);
        }

        if (other.CompareTag("NAPORITANN") || other.CompareTag("MIITOBOURU") || other.CompareTag("PASUTA") || other.CompareTag("EBIHURAI") || other.CompareTag("EBIHURAI2"))
        {
            transform.position = new Vector3(transform.position.x, other.transform.position.y + 2, transform.position.z);
        }

        if (other.CompareTag("KARAAGE"))
        {
            transform.position = new Vector3(transform.position.x, other.transform.position.y + 4, transform.position.z);
        }

        if (other.CompareTag("POPPUCONSHURINPU"))
        {
            transform.position = new Vector3(transform.position.x, other.transform.position.y + 1.5f, transform.position.z);
        }

        if (other.CompareTag("POPPUCONSHURINPU2"))
        {
            transform.position = new Vector3(transform.position.x, other.transform.position.y + 0.5f, transform.position.z);
        }

        if (other.CompareTag("BUROKKORII"))
        {
            transform.position = new Vector3(transform.position.x, other.transform.position.y + 2.5f, transform.position.z);
        }*/
    }

    /*private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("BUROKKORII")
            || other.CompareTag("BUROKKORII2")
            || other.CompareTag("EBIHURAI")
            || other.CompareTag("EBIHURAI2")
            || other.CompareTag("HANNBAAGU")
            || other.CompareTag("KARAAGE")
            || other.CompareTag("MIITOBOURU")
            || other.CompareTag("PASUTA")
            || other.CompareTag("POPPUCONSHURINPU")
            || other.CompareTag("NAPORITANN")
            || other.CompareTag("SYUUMAI")
            || other.CompareTag("TOMATO")
            || other.CompareTag("TAMAGOYAKI")
            || other.CompareTag("Ground"))
        {
            Fall = false;
            Child.tag = Tag;
        }

        if (other.CompareTag("STOP"))
        {
            transform.position = new Vector3(transform.position.x, transform.position.y + 1, transform.position.z);
        }
    }*/

    // Update is called once per frame
    void Update()
    {
        /*‰½‚©‚É“–‚½‚é‚Ü‚Å—Ž‰º‚µ‘±‚¯‚é
        if (Fall == true)
        {
            //transform.Translate(0, -1, 0);
            transform.position = new Vector3(transform.position.x, transform.position.y - 1, transform.position.z);
        }*/
    }
}
