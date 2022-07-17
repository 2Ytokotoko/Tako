using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HanteiFall : MonoBehaviour
{
    bool Fall = true;
    public string Tag;
    public GameObject Child;
    // Start is called before the first frame update
    void Start()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("BUROKKORII")
            || other.CompareTag("BUROKKORII2")
            || other.CompareTag("EBIHURAI")
            || other.CompareTag("EBIHURAI2")
            || other.CompareTag("HANNBAAGU")
            || other.CompareTag("KARAAGE")
            || other.CompareTag("MIITOBOURU")
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
    }

    // Update is called once per frame
    void Update()
    {
        //‰½‚©‚É“–‚½‚é‚Ü‚Å—Ž‰º‚µ‘±‚¯‚é
        if (Fall == true)
        {
            //transform.Translate(0, -1, 0);
            transform.position = new Vector3(transform.position.x, transform.position.y - 1, transform.position.z);
        }
    }
}
