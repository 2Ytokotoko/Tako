using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ani : MonoBehaviour
{
    private Animator anime;�@//�A�j���[�^�[������ϐ���p�ӂ��܂�


    // Start is called before the first frame update
    void Start()
    {
        anime = GetComponent<Animator>();�@�@�@//�ϐ���Animator�R���|�l���g�����܂�
        anime.SetBool("Ani", false);		//Animator���ɂ���bool�t���O�hisShoot�h��false�ɂ��Ă����܂�
    }     �@

    // Update is called once per frame
    void Update()
    {
        anime.SetTrigger("Ani"); // "Trigger"�ɂ̓p�����[�^��������܂�
    }
}
