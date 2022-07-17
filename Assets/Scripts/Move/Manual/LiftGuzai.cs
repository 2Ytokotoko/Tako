using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LiftGuzai : MonoBehaviour
{
    public bool NorthCheck = false;
    public bool WestCheck = false;
    public bool EastCheck = false;
    public bool SouthCheck = false;
    public GameObject Player;
    private Rigidbody Rb;

    // Start is called before the first frame update
    void Start()
    {
        Rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < 0)
        {
            transform.parent = null;
            Rb.velocity = new Vector3(0, -2f, 0);
        }

        if (NorthCheck == true)
        {
            if (Input.GetKeyDown(KeyCode.S))
            {
                gameObject.tag = "Player";
                transform.parent = Player.transform;
            }

            if (Input.GetKeyDown(KeyCode.D))
            {
                gameObject.tag = "Guzai";
                transform.parent = null;
            }

            if (Input.GetKeyDown(KeyCode.W))
            {
                gameObject.tag = "Guzai";
                transform.parent = null;
            }

            if (Input.GetKeyDown(KeyCode.A))
            {
                gameObject.tag = "Guzai";
                transform.parent = null;
            }
        }

        if(WestCheck == true)
        {
            if (Input.GetKeyDown(KeyCode.D))
            {
                gameObject.tag = "Player";
                transform.parent = Player.transform;
            }

            if (Input.GetKeyDown(KeyCode.W))
            {
                gameObject.tag = "Guzai";
                transform.parent = null;
            }

            if (Input.GetKeyDown(KeyCode.A))
            {
                gameObject.tag = "Guzai";
                transform.parent = null;
            }

            if (Input.GetKeyDown(KeyCode.S))
            {
                gameObject.tag = "Guzai";
                transform.parent = null;
            }
        }

        if(EastCheck == true)
        {
            if (Input.GetKeyDown(KeyCode.A))
            {
                gameObject.tag = "Player";
                transform.parent = Player.transform;
            }

            if (Input.GetKeyDown(KeyCode.S))
            {
                gameObject.tag = "Guzai";
                transform.parent = null;
            }

            if (Input.GetKeyDown(KeyCode.D))
            {
                gameObject.tag = "Guzai";
                transform.parent = null;
            }

            if (Input.GetKeyDown(KeyCode.W))
            {
                gameObject.tag = "Guzai";
                transform.parent = null;
            }
        }

        if(SouthCheck == true)
        {
            if (Input.GetKeyDown(KeyCode.W))
            {
                gameObject.tag = "Player";
                transform.parent = Player.transform;
            }

            if (Input.GetKeyDown(KeyCode.A))
            {
                gameObject.tag = "Guzai";
                transform.parent = null;
            }

            if (Input.GetKeyDown(KeyCode.S))
            {
                gameObject.tag = "Guzai";
                transform.parent = null;
            }

            if (Input.GetKeyDown(KeyCode.D))
            {
                gameObject.tag = "Guzai";
                transform.parent = null;
            }
        }
    }
}
