using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class NEWCAMERA : MonoBehaviour
{
    //MaxY��MinY�͏����̃J�����̊p�x��45�Ƃ��čl�����Ƃ���Y=90����T=20 �ӂ�܂ŉ�]����

    public GameObject targetObj; //�J�����͂��̃I�u�W�F�N�g�𒆐S��180�x���炢��]����
    Vector3 targetPos;
    public float rotateSpeed = 1.0f;
    // �t�B�[���h��ǉ����āA�ώZ��]�p��ʓr�o���Ă�����悤�ɂ��Ă���
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
            // target�̈ړ��ʕ��A�����i�J�����j���ړ�����
            transform.position += targetObj.transform.position - targetPos;
            targetPos = targetObj.transform.position;

            // �}�E�X�̈ړ���
            float mouseInputX = Input.GetAxis("Mouse X");
            float mouseInputY = Input.GetAxis("Mouse Y");

            // �}�E�X�ړ��ʂ��狁�߂������E������]�p�i������҂���̃R�[�h�́ARotateAround�̑�3�����Ɠ����j
            float deltaAngleH = mouseInputX * rotateSpeed;
            float deltaAngleV = -mouseInputY * rotateSpeed;

            // �p�x��ώZ����
            angleH += deltaAngleH;
            angleV += deltaAngleV;

            // �ώZ�p�x�𐧌����ɃN�����v����
            //float clampedAngleH = Mathf.Clamp(angleH, -50, 50);
            float clampedAngleV = Mathf.Clamp(angleV, MinY, MaxY);

            // �N�����v�O�̐ώZ�p����N�����v��̐ώZ�p�������āA�ǂꂾ�������͈͂𒴂����������߂�
            // ���������͈͓��Ȃ獷��0�ɂȂ邪�A�}�C�i�X���ɉz����΃}�C�i�X�́A�v���X���Ȃ�v���X�̊p�x����������
            //float overshootH = angleH - clampedAngleH;
            float overshootV = angleV - clampedAngleV;

            // �p�x����������]�ʂ𒲐����āA�����𒴂��Ȃ��悤�ɂ��Ă��
            // �ώZ�p�x��������̒l�ɏ㏑������
            //  deltaAngleH -= overshootH;
            deltaAngleV -= overshootV;
            //angleH = clampedAngleH;
            angleV = clampedAngleV;

            // target�̈ʒu��Y���𒆐S�ɁA��]�i���]�j����
            transform.RotateAround(targetPos, Vector3.up, deltaAngleH);

            // �J�����̐����ړ�
            transform.RotateAround(targetPos, transform.right, deltaAngleV);
        }
    }
}

