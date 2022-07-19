using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ani : MonoBehaviour
{
    private Animator anime;　//アニメーターを入れる変数を用意します


    // Start is called before the first frame update
    void Start()
    {


        anime = GetComponent<Animator>();   //変数にAnimatorコンポネントを入れます
      //  Debug.Log("ok2");

    }


    void FixedUpdate()
    {

        bool Flag = GameObject.Find("Player").GetComponent<Player>().flag;
     //   Debug.Log("ok3");
        if (Flag == true)
        {
            Debug.Log("ok4");
            anime.SetBool("Ani",true); // "Trigger"にはパラメータ名が入ります
        }
    }
}
