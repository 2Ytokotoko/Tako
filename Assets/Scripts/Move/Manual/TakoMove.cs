using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakoMove : MonoBehaviour
{
    public GameObject North;
    public GameObject West;
    public GameObject East;
    public GameObject South;
    public GameObject Destination;
    public bool NorthCheck = true;
    public bool WestCheck = true;
    public bool EastCheck = true;
    public bool SouthCheck = true;
    float speed = 0.1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Destination == null)
        {
            if (Input.GetKeyDown(KeyCode.W) && North != null)
            {
                Destination = North;
            }

            if (Input.GetKeyDown(KeyCode.A) && West != null)
            {
                Destination = West;
            }

            if (Input.GetKeyDown(KeyCode.S) && South != null)
            {
                Destination = South;
            }

            if (Input.GetKeyDown(KeyCode.D) && East != null)
            {
                Destination = East;
            }
        }

        else if (Destination != null)
        {
            if (transform.position != Destination.transform.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, Destination.transform.position, speed);
            }

            if (transform.position == Destination.transform.position)
            {
                Destination = null;
                NorthCheck = true;
                WestCheck = true;
                EastCheck = true;
                SouthCheck = true;
            }
        }
    }
}
