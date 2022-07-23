using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HanteiChange : MonoBehaviour
{
    public Material colorA;//�ω������Ƃ��̂���
    public Material colorB;//���Ƃɖ߂�F
    public string Tag;
    GameObject child;
    // Start is called before the first frame update
    void Start()
    {
        child = gameObject.transform.GetChild(0).gameObject;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnDisable()
    {
        child.GetComponent<Renderer>().material.color = colorB.color;
    }

    //�}�E�X�J�[�\����Sphere�ɏ�������̏���
    private void OnMouseOver()
    {
        if (gameObject.tag == Tag)
        {
            //Sphere�̐F���}�e���A���Ɠ����F�ɕω������܂��B
            child.GetComponent<Renderer>().material.color = colorA.color;
        }
    }

    //�}�E�X�J�[�\����Sphere�̏ォ�痣�ꂽ���̏���
    private void OnMouseExit()
    {
        //Sphere�̐F���ɖ߂�܂��B
        child.GetComponent<Renderer>().material.color = colorB.color;
    }
}
