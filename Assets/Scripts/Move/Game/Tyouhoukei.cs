using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tyouhoukei : MonoBehaviour
{
    private KaitenNumber kaitenNumber;
    public GameObject Tate;
    public GameObject Yoko;
    // Start is called before the first frame update
    void Start()
    {
        kaitenNumber = FindObjectOfType<KaitenNumber>();
    }

    // Update is called once per frame
    void Update()
    {
        if (kaitenNumber.Tyouhoukei ==  0)
        {
            Tate.SetActive(true);
            Yoko.SetActive(false);
        }

        else if (kaitenNumber.Tyouhoukei == 1)
        {
            Tate.SetActive(false);
            Yoko.SetActive(true);
        }
    }
}
