using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SeitchCamera : MonoBehaviour
{
    //回転するMainCameraと真上からを写すUpCameraを切り替えるスクリプト。ボタンの文字(画像)は切り替わらないためそこが課題。
    //Buttonに付けてあげる

    public Camera Camera;// MainCameraを突っ込む
    public Camera subCamera;//UpCameraを突っ込む

    //キャンバスを格納
    public GameObject Canvas;//Canvasを突っ込む

    // Use this for initialization
    void Start()
    {

        //初めはサブカメラをオフにしておく
        subCamera.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {

    }

    //ボタンを押した時の処理
    public void PushButton()
    {
        //もしサブカメラがオフだったら
        if (!subCamera.enabled)
        {
            //サブカメラをオンにして
            subCamera.enabled = true;

            //カメラをオフにする
            Camera.enabled = false;

            //キャンバスを映すカメラをサブカメラオブジェクトにする
            Canvas.GetComponent<Canvas>().worldCamera = subCamera;

        }
        //もしサブカメラがオンだったら
        else
        {
            //サブカメラをオフにして
            subCamera.enabled = false;

            //カメラをオンにする
            Camera.enabled = true;

            //キャンバスを映すカメラをカメラオブジェクトにする
            Canvas.GetComponent<Canvas>().worldCamera = Camera;
        }
    }
}

