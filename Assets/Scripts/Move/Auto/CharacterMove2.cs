using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMove2 : MonoBehaviour
{
    public bool MaeCheck = true;
    public bool HidariCheck = true;
    public bool MigiCheck = true;
    public bool UsiroCheck = true;
    public bool Zensin = false;
    public bool Sasin = false;
    public bool Usin = false;
    public bool Kousin = false;
    public bool select = false;

    public GameObject Front;
    public GameObject Left;
    public GameObject Right;
    public GameObject Back;
    public GameObject Mae;
    public GameObject Hidari;
    public GameObject Migi;
    public GameObject Usiro;
    public float DistanceF;
    public float DistanceL;
    public float DistanceR;
    public float DistanceB;
    float speed = 0.1f;

    public Camera Camera;
    public GameObject Guzai;
    public GameObject Goal;
    private RaycastHit hit;
    int count = 0;
    private Property property;
    // Start is called before the first frame update
    void Start()
    {
        property = FindObjectOfType<Property>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Goal != null && transform.position == Goal.transform.position)
        {
            ZenGoSaYuuCheck();
            Goal = null;
        }

        if(Goal == null)
        {
            ZenGoSaYuuCheck();
        }

        //ゴールについていなければ繰り返す
        if (Goal != null && transform.position != Goal.transform.position)
        {
            if(Zensin == true)
            {
                //前に進む
                transform.position = Vector3.MoveTowards(transform.position, Mae.transform.position, speed);
                if (property.LeftFront == 0 && property.RightFront == 0)
                {
                    Zensin = false;
                    ZenGoSaYuuCheck();
                }
            }

            if(Sasin == true)
            {
                //左に進む
                transform.position = Vector3.MoveTowards(transform.position, Hidari.transform.position, speed);
                if (property.FrontLeft == 0 && property.BackLeft == 0)
                {
                    Sasin = false;
                    ZenGoSaYuuCheck();
                }
            }

            if (Usin == true)
            {
                //右に進む
                transform.position = Vector3.MoveTowards(transform.position, Migi.transform.position, speed);
                if (property.FrontRight == 0 && property.BackRight == 0)
                {
                    Usin = false;
                    ZenGoSaYuuCheck();
                }
            }

            if (Kousin == true)
            {
                //後ろに進む
                transform.position = Vector3.MoveTowards(transform.position, Usiro.transform.position, speed);
                if (property.LeftBack == 0 && property.RightBack == 0)
                {
                    Kousin = false;
                    ZenGoSaYuuCheck();
                }
            }

            //前と左、前と右が同じ距離のとき
            if ((DistanceF == DistanceL && DistanceF < DistanceR && DistanceF < DistanceB) || (DistanceF == DistanceR && DistanceF < DistanceL && DistanceF < DistanceB))
            {
                //前に進む
                transform.position = Vector3.MoveTowards(transform.position, Front.transform.position, speed);
                if (transform.position == Front.transform.position)
                {
                    ZenGoSaYuuCheck();
                }
            }

            //後ろと左、後ろと右が同じ距離のとき
            if ((DistanceB == DistanceL && DistanceB < DistanceR && DistanceB < DistanceF) || (DistanceB == DistanceR && DistanceB < DistanceL && DistanceB < DistanceF))
            {
                //後ろに進む
                transform.position = Vector3.MoveTowards(transform.position, Back.transform.position, speed);
                if (transform.position == Back.transform.position)
                {
                    ZenGoSaYuuCheck();
                }
            }

            //前と後ろが同じ距離のとき
            if (DistanceF == DistanceB && DistanceF < DistanceL && DistanceF < DistanceR)
            {
                if(Left != null && Right != null && Zensin == false && Kousin == false)
                {
                    //前に進む
                    transform.position = Vector3.MoveTowards(transform.position, Front.transform.position, speed);
                    if (transform.position == Front.transform.position)
                    {
                        ZenGoSaYuuCheck();
                    }
                }

                if(Left == null && Right != null)
                {
                    if (property.LeftFront == property.LeftBack)
                    {
                        Zensin = true;
                    }

                    else if (property.LeftFront < property.LeftBack)
                    {
                        Zensin = true;
                    }

                    else if(property.LeftBack < property.LeftFront)
                    {
                        Kousin = true;
                    }
                }

                if(Right == null && Left != null)
                {
                    if (property.RightFront == property.RightBack)
                    {
                        Zensin = true;
                    }

                    else if (property.RightFront < property.RightBack)
                    {
                        Zensin = true;
                    }

                    else if (property.RightBack < property.RightFront)
                    {
                        Kousin = true;
                    }
                }
            }

            //左と右が同じ距離のとき
            if (DistanceL == DistanceR && DistanceL < DistanceF && DistanceL < DistanceB)
            {
                if(Front != null && Back != null && Sasin == false && Usin == false)
                {
                    //左に進む
                    transform.position = Vector3.MoveTowards(transform.position, Left.transform.position, speed);
                    if (transform.position == Left.transform.position)
                    {
                        ZenGoSaYuuCheck();
                    }
                }

                if(Front == null && Back != null)
                {
                    if (property.FrontLeft == property.FrontRight)
                    {
                        Sasin = true;
                    }

                    else if (property.FrontLeft < property.FrontRight)
                    {
                        Sasin = true;
                    }

                    else if (property.FrontRight < property.FrontLeft)
                    {
                        Usin = true;
                    }
                }

                if(Back == null && Front != null)
                {
                    if (property.BackLeft == property.BackRight)
                    {
                        Sasin = true;
                    }

                    else if (property.BackLeft < property.BackRight)
                    {
                        Sasin = true;
                    }

                    else if (property.BackRight < property.BackLeft)
                    {
                        Usin = true;
                    }
                }
            }

            //前が最小値のとき
            if (DistanceF < DistanceL && DistanceF < DistanceR && DistanceF < DistanceB)
            {
                //前に進む
                transform.position = Vector3.MoveTowards(transform.position, Front.transform.position, speed);
                if (transform.position == Front.transform.position)
                {
                    ZenGoSaYuuCheck();
                }
            }

            //左が最小値のとき
            if (DistanceL < DistanceF && DistanceL < DistanceR && DistanceL < DistanceB)
            {
                //左に進む
                transform.position = Vector3.MoveTowards(transform.position, Left.transform.position, speed);
                if (transform.position == Left.transform.position)
                {
                    ZenGoSaYuuCheck();
                }
            }

            //右が最小値のとき
            if (DistanceR < DistanceF && DistanceR < DistanceL && DistanceR < DistanceB)
            {
                //右に進む
                transform.position = Vector3.MoveTowards(transform.position, Right.transform.position, speed);
                if (transform.position == Right.transform.position)
                {
                    ZenGoSaYuuCheck();
                }
            }

            //後ろが最小値のとき
            if (DistanceB < DistanceF && DistanceB < DistanceL && DistanceB < DistanceR)
            {
                //後ろに進む
                transform.position = Vector3.MoveTowards(transform.position, Back.transform.position, speed);
                if (transform.position == Back.transform.position)
                {
                    ZenGoSaYuuCheck();
                }
            }
        }

        if(select == false)
        {
            if (Input.GetMouseButtonDown(0))
            {
                Ray Fray = Camera.ScreenPointToRay(Input.mousePosition);

                if (Physics.Raycast(Fray, out hit))
                {
                    //具材を選択、具材を運ぶ位置に移動
                    if (hit.collider.gameObject.tag == "Guzai")
                    {
                        hit.collider.gameObject.GetComponent<GuzaiMove>().GuzaiSelect();
                        select = true;
                    }
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

    void ZenGoSaYuuCheck()
    {
        MaeCheck = true;
        HidariCheck = true;
        MigiCheck = true;
        UsiroCheck = true;
    }
}
