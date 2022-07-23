using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HyouziKirikae : MonoBehaviour
{
    public GameObject Terms;
    public GameObject Offer;

    public GameObject Terms2;
    int counter = 0;


    // Start is called before the first frame update
    void Start()
    {
        Terms2.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {

            counter++;

            if (counter == 1)
            {
                Terms.SetActive(false);
                Offer.SetActive(true);
            }
            if (counter == 2)
            {
                Terms.SetActive(true);
                Offer.SetActive(false);
            }
            if (counter == 3)
            {
                Terms.SetActive(false);
                Offer.SetActive(false);
            }
            if (counter == 4)
            {
                Terms.SetActive(true);
                Offer.SetActive(true);
                counter = 0; // ’Ç‰Á
            }
        }

    }
}
