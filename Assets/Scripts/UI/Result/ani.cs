using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ani : MonoBehaviour
{
    private Animator anime;�@//�A�j���[�^�[������ϐ���p�ӂ��܂�


    // Start is called before the first frame update
    void Start()
    {


        anime = GetComponent<Animator>();   //�ϐ���Animator�R���|�l���g�����܂�
      //  Debug.Log("ok2");

    }


    void FixedUpdate()
    {

        bool Flag = GameObject.Find("Player").GetComponent<Player>().flag;
     //   Debug.Log("ok3");
        if (Flag == true)
        {
            Debug.Log("ok4");
            anime.SetBool("Ani",true); // "Trigger"�ɂ̓p�����[�^��������܂�
        }
    }
}
