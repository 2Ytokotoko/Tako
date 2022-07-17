using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCamera : MonoBehaviour
{
    //右のマウスボタンを押しながらドラックするとお弁当が回転しているように見えるスクリプト。書いた本人はコピペしただけのためどうやって動いているかは理解してない
    //CanvasのRenderModeがScreenSpaceCameraだとボタン切り替えると後々弁当箱に沈む。でもこの設定じゃないとビルドした後のUIがぐちゃぐちゃになる
    
    public GameObject mainCamera;//MainCameraを突っ込む
    public GameObject fieldObject;//こいつを中心にカメラが回る
    public float rotateSpeed = 1.0f;
    private Vector3 lastMousePosition; //①追記
    private Vector3 newAngle = new Vector3(0, 0, 0); //②追記
    void Start()
    {
    }
    void Update()
    {
        //追記 START
        if (Input.GetMouseButtonDown(1)) //③
        {
            newAngle = mainCamera.transform.localEulerAngles; //④
            lastMousePosition = Input.mousePosition; //⑤
        }
        //追記 END
        else if (Input.GetMouseButton(1))
        {
            rotateCamera();
        }
    }

    private void rotateCamera()
    {
        Vector3 angle = new Vector3(
                Input.GetAxis("Mouse X") * this.rotateSpeed,
                0,
                0
            );
        this.mainCamera.transform.RotateAround(this.fieldObject.transform.position, Vector3.up, angle.x);
    }
}
