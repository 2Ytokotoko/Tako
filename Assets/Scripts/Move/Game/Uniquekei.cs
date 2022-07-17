using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Uniquekei : MonoBehaviour
{
    private KaitenNumber kaitenNumber;
    public GameObject Two;
    public GameObject One;
    public GameObject Three;
    public GameObject Zero;
    // Start is called before the first frame update
    void Start()
    {
        kaitenNumber = FindObjectOfType<KaitenNumber>();
    }

    // Update is called once per frame
    void Update()
    {
        if (kaitenNumber.Unique ==  0)
        {
            Two.SetActive(false);
            Zero.SetActive(true);
            One.SetActive(false);
            Three.SetActive(false);
        }

        else if (kaitenNumber.Unique == 1)
        {
            Two.SetActive(false);
            Zero.SetActive(false);
            One.SetActive(true);
            Three.SetActive(false);
        }

        else if (kaitenNumber.Unique == 2)
        {
            Two.SetActive(true);
            Zero.SetActive(false);
            One.SetActive(false);
            Three.SetActive(false);
        }

        else if (kaitenNumber.Unique == 3)
        {
            Two.SetActive(false);
            Zero.SetActive(false);
            One.SetActive(false);
            Three.SetActive(true);
        }
    }
}
