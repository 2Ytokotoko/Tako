using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSet : MonoBehaviour
{
    public GameObject Guzai;
    public GameObject GameUI;
    public GameObject ClearUI;
    public GameObject Sonota;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Hantei"))
        {
            Invoke("Result", 1.0f);
        }
    }

    void Result()
    {
        ClearUI.SetActive(true);
        GameUI.SetActive(false);
        Guzai.SetActive(false);
        Sonota.SetActive(false);
    }
}
