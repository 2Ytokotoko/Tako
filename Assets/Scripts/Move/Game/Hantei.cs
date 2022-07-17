using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hantei : MonoBehaviour
{
    public Material colorA;//変化したときのいろ
    public Material colorB;//もとに戻る色
    bool Fall = true;
    bool ChangeColor = false;
    public string Tag;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(Fall == true && transform.position.y > 0)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y - 1, transform.position.z);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("TAMAGOYAKI") || other.CompareTag("TOMATO") || other.CompareTag("KARAAGE") || other.CompareTag("MIITOBOURU") || other.CompareTag("SYUUMAI") || other.CompareTag("NAPORITANN") || other.CompareTag("HANNBAAGU") || other.CompareTag("BUROKKORII") || other.CompareTag("BUROKKORII2") || other.CompareTag("EBIHURAI") || other.CompareTag("EBIHURAI2") || other.CompareTag("Ground"))
        {
            Fall = false;
            ChangeColor = true;
            gameObject.tag = Tag;
        }
    }

    void OnDisable()
    {
        gameObject.GetComponent<Renderer>().material.color = colorB.color;
    }

    //マウスカーソルがSphereに乗った時の処理
    private void OnMouseOver()
    {
        if(ChangeColor == true)
        {
            //Sphereの色をマテリアルと同じ色に変化させます。
            gameObject.GetComponent<Renderer>().material.color = colorA.color;
        }
    }

    //マウスカーソルがSphereの上から離れた時の処理
    private void OnMouseExit()
    {
        //Sphereの色がに戻ります。
        gameObject.GetComponent<Renderer>().material.color = colorB.color;
    }
}
