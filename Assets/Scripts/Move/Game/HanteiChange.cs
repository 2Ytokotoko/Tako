using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HanteiChange : MonoBehaviour
{
    public Material colorA;//変化したときのいろ
    public Material colorB;//もとに戻る色
    public string Tag;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnDisable()
    {
        gameObject.GetComponent<Renderer>().material.color = colorB.color;
    }

    //マウスカーソルがSphereに乗った時の処理
    private void OnMouseOver()
    {
        if (gameObject.tag == Tag)
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
