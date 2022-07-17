using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colour : MonoBehaviour
{
    //弁当箱の中身の表面にすべてにこいつをいれる必要がある。めんどくさいねごめんね
    //colorAにはTOUMEIをcolorBにはHOZYOのマテリアルを入れる

    public Material colorA;//変化したときのいろ
    public Material colorB;//もとに戻る色

    //マウスカーソルがSphereに乗った時の処理
    private void OnMouseOver()
    {
        //Sphereの色をマテリアルと同じ色に変化させます。
        this.gameObject.GetComponent<Renderer>().material.color = colorA.color;
    }

    //マウスカーソルがSphereの上から離れた時の処理
    private void OnMouseExit()
    {
        //Sphereの色がに戻ります。
        this.gameObject.GetComponent<Renderer>().material.color = colorB.color;
    }

}
