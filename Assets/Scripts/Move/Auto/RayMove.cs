using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayMove : MonoBehaviour
{
    public GameObject MaeHantei;
    public GameObject HidariHantei;
    public GameObject MigiHantei;
    public GameObject UsiroHantei;
    public bool MaeCheck = true;
    public bool HidariCheck = true;
    public bool MigiCheck = true;
    public bool UsiroCheck = true;
    RaycastHit Maehit;
    RaycastHit Hidarihit;
    RaycastHit Migihit;
    RaycastHit Usirohit;
    float kyori = 1.0f;

    public GameObject Front;
    public GameObject Left;
    public GameObject Right;
    public GameObject Back;
    public float DistanceF;
    public float DistanceL;
    public float DistanceR;
    public float DistanceB;
    float speed = 0.1f;

    public Camera Camerafront;
    public GameObject Guzai;
    public GameObject Goal;
    private RaycastHit hit;
    int count = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        var Fdirection = transform.forward;
        var Ldirection = -transform.right;
        var Rdirection = transform.right;
        var Bdirection = -transform.forward;

        if (Goal != null && transform.position == Goal.transform.position)
        {
            Goal = null;
        }

        if (Goal != null && transform.position != Goal.transform.position)
        {
            if (MaeCheck == true)
            {
                Vector3 FrayPosition = transform.position + new Vector3(0.0f, 0.0f, 0.0f);
                Ray Maeray = new Ray(FrayPosition, Fdirection);
                if (Physics.Raycast(Maeray,out Maehit, kyori))
                {
                    if(Maehit.collider.tag == "Ground")
                    {
                        Front = Maehit.collider.gameObject;
                        DistanceF = Vector3.Distance(Front.transform.position, Goal.transform.position);
                        MaeCheck = false;
                    }

                    if(Maehit.collider.tag == "Dontgo")
                    {
                        Front = null;
                        DistanceF = 99f;
                        MaeCheck = false;
                    }
                }
            }

            if(HidariCheck == true)
            {
                Vector3 LrayPosition = transform.position + new Vector3(0.0f, 0.0f, 0.0f);
                Ray Hidariray = new Ray(LrayPosition, Ldirection);
                if (Physics.Raycast(Hidariray, out Hidarihit, kyori))
                {
                    if(Hidarihit.collider.tag == "Ground")
                    {
                        Left = Hidarihit.collider.gameObject;
                        DistanceL = Vector3.Distance(Left.transform.position, Goal.transform.position);
                        HidariCheck = false;
                    }

                    if (Hidarihit.collider.tag == "Dontgo")
                    {
                        Left = null;
                        DistanceL = 99f;
                        HidariCheck = false;
                    }
                }
            }

            if(MigiCheck == true)
            {
                Vector3 RrayPosition = transform.position + new Vector3(0.0f, 0.0f, 0.0f);
                Ray Migiray = new Ray(RrayPosition, Rdirection);
                if (Physics.Raycast(Migiray, out Migihit, kyori))
                {
                    if(Migihit.collider.tag == "Ground")
                    {
                        Right = Migihit.collider.gameObject;
                        DistanceR = Vector3.Distance(Right.transform.position, Goal.transform.position);
                        MigiCheck = false;
                    }

                    if (Migihit.collider.tag == "Dontgo")
                    {
                        Right = null;
                        DistanceR = 99f;
                        MigiCheck = false;
                    }
                }
            }

            if(UsiroCheck == true)
            {
                Vector3 BrayPosition = transform.position + new Vector3(0.0f, 0.0f, 0.0f);
                Ray Usiroray = new Ray(BrayPosition, Bdirection);
                if (Physics.Raycast(Usiroray, out Usirohit, kyori))
                {
                    if(Usirohit.collider.tag == "Ground")
                    {
                        Back = Usirohit.collider.gameObject;
                        DistanceB = Vector3.Distance(Back.transform.position, Goal.transform.position);
                        UsiroCheck = false;
                    }

                    if (Usirohit.collider.tag == "Dontgo")
                    {
                        Back = null;
                        DistanceB = 99f;
                        UsiroCheck = false;
                    }
                }
            }

            if (DistanceF < DistanceL && DistanceF < DistanceR && DistanceF < DistanceB)
            {
                transform.position = Vector3.MoveTowards(transform.position, Front.transform.position, speed);
                if (transform.position == Front.transform.position)
                {
                    MaeCheck = true;
                    MigiCheck = true;
                    HidariCheck = true;
                    UsiroCheck = true;
                }
            }

            if (DistanceL < DistanceF && DistanceL < DistanceR && DistanceL < DistanceB)
            {
                transform.position = Vector3.MoveTowards(transform.position, Left.transform.position, speed);
                if (transform.position == Left.transform.position)
                {
                    MaeCheck = true;
                    MigiCheck = true;
                    HidariCheck = true;
                    UsiroCheck = true;
                }
            }

            if (DistanceR < DistanceF && DistanceR < DistanceL && DistanceR < DistanceB)
            {
                transform.position = Vector3.MoveTowards(transform.position, Right.transform.position, speed);
                if (transform.position == Right.transform.position)
                {
                    MaeCheck = true;
                    MigiCheck = true;
                    HidariCheck = true;
                    UsiroCheck = true;
                }
            }

            if (DistanceB < DistanceF && DistanceB < DistanceL && DistanceB < DistanceR)
            {
                transform.position = Vector3.MoveTowards(transform.position, Back.transform.position, speed);
                if (transform.position == Back.transform.position)
                {
                    MaeCheck = true;
                    MigiCheck = true;
                    HidariCheck = true;
                    UsiroCheck = true;
                }
            }

            if ((DistanceF == DistanceL && DistanceF < DistanceR && DistanceF < DistanceB) || (DistanceF == DistanceR && DistanceF < DistanceL && DistanceF < DistanceB))
            {
                transform.position = Vector3.MoveTowards(transform.position, Front.transform.position, speed);
                if (transform.position == Front.transform.position)
                {
                    MaeCheck = true;
                    MigiCheck = true;
                    HidariCheck = true;
                    UsiroCheck = true;
                }
            }

            if ((DistanceB == DistanceL && DistanceB < DistanceR && DistanceB < DistanceF) || (DistanceB == DistanceR && DistanceB < DistanceL && DistanceB < DistanceF))
            {
                transform.position = Vector3.MoveTowards(transform.position, Back.transform.position, speed);
                if (transform.position == Back.transform.position)
                {
                    MaeCheck = true;
                    MigiCheck = true;
                    HidariCheck = true;
                    UsiroCheck = true;
                }
            }
        }

        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camerafront.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.gameObject.tag == "Guzai")
                {
                    Guzai = hit.collider.gameObject;
                    Goal = null;
                }

                else if (hit.collider.gameObject.tag == "Ground")
                {
                    Goal = hit.collider.gameObject;
                }
            }
        }

        if (Guzai != null && Input.GetMouseButtonDown(1))
        {
            count += 1;
        }

        if (Guzai != null && Guzai.transform.rotation.y != -90 * count)
        {
            Guzai.transform.rotation = Quaternion.RotateTowards(Guzai.transform.rotation, Quaternion.Euler(0, Guzai.transform.rotation.y - 90 * count, 0), 5f);
        }
    }
}
