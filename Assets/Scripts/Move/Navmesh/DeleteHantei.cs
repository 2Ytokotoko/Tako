using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteHantei : MonoBehaviour
{
    public string Tag;
    public Material colorA;//�ω������Ƃ��̂���
    public Material colorB;//���Ƃɖ߂�F
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Finish"))
        {
            gameObject.tag = "Ground";
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Finish"))
        {
            gameObject.tag = Tag;
        }
    }

    //�}�E�X�J�[�\����Sphere�ɏ�������̏���
    private void OnMouseOver()
    {
        if(gameObject.tag == Tag)
        {
            //Sphere�̐F���}�e���A���Ɠ����F�ɕω������܂��B
            gameObject.GetComponent<Renderer>().material.color = colorA.color;
        }
    }

    //�}�E�X�J�[�\����Sphere�̏ォ�痣�ꂽ���̏���
    private void OnMouseExit()
    {
        //Sphere�̐F���ɖ߂�܂��B
        gameObject.GetComponent<Renderer>().material.color = colorB.color;
    }
}
