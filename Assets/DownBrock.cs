using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 public class DownBrock : MonoBehaviour{
    public float moveSpeed;
    private Rigidbody rb;
    private Vector3 pos;
    void Start(){
        rb = GetComponent<Rigidbody>();
    }
    void Update(){
        pos = rb.position;
        float moveH = Input.GetAxis("Horizontal");
        float moveV = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(moveH, 0, moveV);
        if (pos.y >= 0 || pos.y <= -1f){
            rb.AddForce(movement * moveSpeed);
        }else{
            rb.velocity = new Vector3(0, -2f, 0);
        }
    }
}