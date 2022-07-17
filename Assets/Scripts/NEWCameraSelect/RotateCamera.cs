using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCamera : MonoBehaviour
{
    //�E�̃}�E�X�{�^���������Ȃ���h���b�N����Ƃ��ٓ�����]���Ă���悤�Ɍ�����X�N���v�g�B�������{�l�̓R�s�y���������̂��߂ǂ�����ē����Ă��邩�͗������ĂȂ�
    //Canvas��RenderMode��ScreenSpaceCamera���ƃ{�^���؂�ւ���ƌ�X�ٓ����ɒ��ށB�ł����̐ݒ肶��Ȃ��ƃr���h�������UI�������Ⴎ����ɂȂ�
    
    public GameObject mainCamera;//MainCamera��˂�����
    public GameObject fieldObject;//�����𒆐S�ɃJ���������
    public float rotateSpeed = 1.0f;
    private Vector3 lastMousePosition; //�@�ǋL
    private Vector3 newAngle = new Vector3(0, 0, 0); //�A�ǋL
    void Start()
    {
    }
    void Update()
    {
        //�ǋL START
        if (Input.GetMouseButtonDown(1)) //�B
        {
            newAngle = mainCamera.transform.localEulerAngles; //�C
            lastMousePosition = Input.mousePosition; //�D
        }
        //�ǋL END
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
