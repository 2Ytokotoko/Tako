using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Touch : MonoBehaviour{
    MeshRenderer mesh;
    void Start(){
        mesh = GetComponent<MeshRenderer>();
        mesh.material.color = mesh.material.color - new Color32(0, 0, 0, 0);
    }
    void OnMouseOver()
    {
            float level = Mathf.Abs(Mathf.Sin((Time.time) * 10));
        GetComponent<Renderer>().material.color = new Color(255f, 0f, 0f, level);
    }
    void OnMouseExit(){
        GetComponent<Renderer>().material.color = Color.red;
    }
}
