using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colour : MonoBehaviour
{
    //�ٓ����̒��g�̕\�ʂɂ��ׂĂɂ����������K�v������B�߂�ǂ������˂��߂��
    //colorA�ɂ�TOUMEI��colorB�ɂ�HOZYO�̃}�e���A��������

    public Material colorA;//�ω������Ƃ��̂���
    public Material colorB;//���Ƃɖ߂�F

    //�}�E�X�J�[�\����Sphere�ɏ�������̏���
    private void OnMouseOver()
    {
        //Sphere�̐F���}�e���A���Ɠ����F�ɕω������܂��B
        this.gameObject.GetComponent<Renderer>().material.color = colorA.color;
    }

    //�}�E�X�J�[�\����Sphere�̏ォ�痣�ꂽ���̏���
    private void OnMouseExit()
    {
        //Sphere�̐F���ɖ߂�܂��B
        this.gameObject.GetComponent<Renderer>().material.color = colorB.color;
    }

}
