using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HanteiCheck : MonoBehaviour
{
    public float count;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GameObject[] Hantei = GameObject.FindGameObjectsWithTag("One");
        count = Hantei.Length;

        if(count == 0)
        {

        }
    }
}
