using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdjustCamera : MonoBehaviour
{
    public GameObject targetObj;
    Vector3 targetPos;
    public float rotateSpeed = 1.0f;

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

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(2))
        {
            transform.position += targetObj.transform.position - targetPos;
            targetPos = targetObj.transform.position;

            float mouseInputX = Input.GetAxis("Mouse X");
            float mouseInputY = Input.GetAxis("Mouse Y");

            float deltaAngleH = mouseInputX * rotateSpeed;
            float deltaAngleV = -mouseInputY * rotateSpeed;

            //float clampedAngleH = Mathf.Clamp(angleH, -50, 50);
            float clampedAngleV = Mathf.Clamp(angleV, MinY, MaxY);

            //float overshootH = angleH - clampedAngleH;
            float overshootV = angleV - clampedAngleV;

            //  deltaAngleH -= overshootH;
            deltaAngleV -= overshootV;
            //angleH = clampedAngleH;
            angleV = clampedAngleV;

            transform.RotateAround(targetPos, Vector3.up, deltaAngleH);

            transform.RotateAround(targetPos, transform.right, deltaAngleV);
        }

    }
}
