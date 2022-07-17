using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mugen : MonoBehaviour
{
    public string name;
    public GameObject Guzai;
    public float z;
    public Vector3 Okibaasyo;
    public GameObject Parent;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Seisei()
    {
        GameObject guzai = Instantiate(Guzai, new Vector3(Okibaasyo.x, Okibaasyo.y, Okibaasyo.z), Quaternion.Euler(0f, 0f, z)) as GameObject;
        guzai.transform.parent = Parent.transform;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag(name))
        {
            Okibaasyo = other.transform.position;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag(name))
        {
            Invoke("Seisei", 0.5f);
        }
    }
}


