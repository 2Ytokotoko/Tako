using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ani : MonoBehaviour
{
    private Animator anime;　//アニメーターを入れる変数を用意します


    // Start is called before the first frame update
    void Start()
    {
        anime = GetComponent<Animator>();　　　//変数にAnimatorコンポネントを入れます
        anime.SetBool("Ani", false);		//Animator内にあるboolフラグ”isShoot”をfalseにしておきます
    }     　

    // Update is called once per frame
    void Update()
    {
        anime.SetTrigger("Ani"); // "Trigger"にはパラメータ名が入ります
    }
}
