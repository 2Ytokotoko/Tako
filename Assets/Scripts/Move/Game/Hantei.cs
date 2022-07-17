using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hantei : MonoBehaviour
{
    public Material colorA;//�ω������Ƃ��̂���
    public Material colorB;//���Ƃɖ߂�F
    bool Fall = true;
    bool ChangeColor = false;
    public string Tag;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(Fall == true && transform.position.y > 0)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y - 1, transform.position.z);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("TAMAGOYAKI") || other.CompareTag("TOMATO") || other.CompareTag("KARAAGE") || other.CompareTag("MIITOBOURU") || other.CompareTag("SYUUMAI") || other.CompareTag("NAPORITANN") || other.CompareTag("HANNBAAGU") || other.CompareTag("BUROKKORII") || other.CompareTag("BUROKKORII2") || other.CompareTag("EBIHURAI") || other.CompareTag("EBIHURAI2") || other.CompareTag("Ground"))
        {
            Fall = false;
            ChangeColor = true;
            gameObject.tag = Tag;
        }
    }

    void OnDisable()
    {
        gameObject.GetComponent<Renderer>().material.color = colorB.color;
    }

    //�}�E�X�J�[�\����Sphere�ɏ�������̏���
    private void OnMouseOver()
    {
        if(ChangeColor == true)
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
