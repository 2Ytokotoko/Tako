using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class NEWCAMERA : MonoBehaviour
{
    //MaxYとMinYは初期のカメラの角度を45として考えたときにY=90からT=20 辺りまで回転する

    public GameObject targetObj; //カメラはこのオブジェクトを中心に180度くらい回転する
    Vector3 targetPos;
    public float rotateSpeed = 1.0f;
    // フィールドを追加して、積算回転角を別途覚えておけるようにしておく
    float angleH;
    float angleV;

    public float MaxY = 45;
    public float MinY = -30;

    public Slider slider;
    void Start()
    {
    }
    public void SSSS()
    {
        float SS = slider.value;
        rotateSpeed = SS;
    }


    void Update()
    {
        if (Input.GetMouseButton(2))
        {
            // targetの移動量分、自分（カメラ）も移動する
            transform.position += targetObj.transform.position - targetPos;
            targetPos = targetObj.transform.position;

            // マウスの移動量
            float mouseInputX = Input.GetAxis("Mouse X");
            float mouseInputY = Input.GetAxis("Mouse Y");

            // マウス移動量から求めた水平・垂直回転角（ご質問者さんのコードの、RotateAroundの第3引数と同じ）
            float deltaAngleH = mouseInputX * rotateSpeed;
            float deltaAngleV = -mouseInputY * rotateSpeed;

            // 角度を積算する
            angleH += deltaAngleH;
            angleV += deltaAngleV;

            // 積算角度を制限内にクランプする
            //float clampedAngleH = Mathf.Clamp(angleH, -50, 50);
            float clampedAngleV = Mathf.Clamp(angleV, MinY, MaxY);

            // クランプ前の積算角からクランプ後の積算角を引いて、どれだけ制限範囲を超えたかを求める
            // もし制限範囲内なら差は0になるが、マイナス側に越えればマイナスの、プラス側ならプラスの角度差が得られる
            //float overshootH = angleH - clampedAngleH;
            float overshootV = angleV - clampedAngleV;

            // 角度差分だけ回転量を調整して、制限を超えないようにしてやる
            // 積算角度も調整後の値に上書きする
            //  deltaAngleH -= overshootH;
            deltaAngleV -= overshootV;
            //angleH = clampedAngleH;
            angleV = clampedAngleV;

            // targetの位置のY軸を中心に、回転（公転）する
            transform.RotateAround(targetPos, Vector3.up, deltaAngleH);

            // カメラの垂直移動
            transform.RotateAround(targetPos, transform.right, deltaAngleV);
        }
    }
}

