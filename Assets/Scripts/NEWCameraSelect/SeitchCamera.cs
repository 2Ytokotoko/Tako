using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SeitchCamera : MonoBehaviour
{
    //��]����MainCamera�Ɛ^�ォ����ʂ�UpCamera��؂�ւ���X�N���v�g�B�{�^���̕���(�摜)�͐؂�ւ��Ȃ����߂������ۑ�B
    //Button�ɕt���Ă�����

    public Camera Camera;// MainCamera��˂�����
    public Camera subCamera;//UpCamera��˂�����

    //�L�����o�X���i�[
    public GameObject Canvas;//Canvas��˂�����

    // Use this for initialization
    void Start()
    {

        //���߂̓T�u�J�������I�t�ɂ��Ă���
        subCamera.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {

    }

    //�{�^�������������̏���
    public void PushButton()
    {
        //�����T�u�J�������I�t��������
        if (!subCamera.enabled)
        {
            //�T�u�J�������I���ɂ���
            subCamera.enabled = true;

            //�J�������I�t�ɂ���
            Camera.enabled = false;

            //�L�����o�X���f���J�������T�u�J�����I�u�W�F�N�g�ɂ���
            Canvas.GetComponent<Canvas>().worldCamera = subCamera;

        }
        //�����T�u�J�������I����������
        else
        {
            //�T�u�J�������I�t�ɂ���
            subCamera.enabled = false;

            //�J�������I���ɂ���
            Camera.enabled = true;

            //�L�����o�X���f���J�������J�����I�u�W�F�N�g�ɂ���
            Canvas.GetComponent<Canvas>().worldCamera = Camera;
        }
    }
}

