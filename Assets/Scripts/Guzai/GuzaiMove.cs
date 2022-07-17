using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuzaiMove : MonoBehaviour
{
    public GameObject Player;
    public GameObject FrontCheck;
    public GameObject LeftCheck;
    public GameObject RightCheck;
    public GameObject BackCheck;
    public float DistancegF;
    public float DistancegL;
    public float DistancegR;
    public float DistancegB;
    public bool selected = false;
    public bool gMaeCheck = true;
    public bool gHidariCheck = true;
    public bool gMigiCheck = true;
    public bool gUsiroCheck = true;
    public GameObject Destination = null;
    private Rigidbody rb;
    float Speed = 0.05f;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        //具材が選択され、配置についたとき
        if (selected == true && Destination == null)
        {
            gameObject.tag = "Player";
            transform.parent = Player.transform;

            if (Input.GetKeyDown(KeyCode.W))
            {
                if (Player.transform.position == BackCheck.transform.position && Player.GetComponent<CharacterMove2>().Front != null)
                {
                    Destination = Player.GetComponent<CharacterMove2>().Front;
                }

                if (Player.transform.position != BackCheck.transform.position && BackCheck != null)
                {
                    transform.parent = null;
                    Destination = BackCheck;
                    gameObject.tag = "Ground";
                }
            }

            if (Input.GetKeyDown(KeyCode.A))
            {
                if (Player.transform.position == RightCheck.transform.position && Player.GetComponent<CharacterMove2>().Left != null)
                {
                    Destination = Player.GetComponent<CharacterMove2>().Left;
                }

                if (Player.transform.position != RightCheck.transform.position && RightCheck != null)
                {
                    transform.parent = null;
                    Destination = RightCheck;
                    gameObject.tag = "Ground";
                }
            }

            if (Input.GetKeyDown(KeyCode.S))
            {
                if (Player.transform.position == FrontCheck.transform.position && Player.GetComponent<CharacterMove2>().Back != null)
                {
                    Destination = Player.GetComponent<CharacterMove2>().Back;
                }

                if (Player.transform.position != FrontCheck.transform.position && FrontCheck != null)
                {
                    transform.parent = null;
                    Destination = FrontCheck;
                    gameObject.tag = "Ground";
                }
            }

            if (Input.GetKeyDown(KeyCode.D))
            {
                if (Player.transform.position == LeftCheck.transform.position && Player.GetComponent<CharacterMove2>().Right != null)
                {
                    Destination = Player.GetComponent<CharacterMove2>().Right;
                }

                if (Player.transform.position != LeftCheck.transform.position && LeftCheck != null)
                {
                    transform.parent = null;
                    Destination = LeftCheck;
                    gameObject.tag = "Ground";
                }
            }

            //親子関係解除
            if (Input.GetMouseButtonDown(2))
            {
                Player.GetComponent<CharacterMove2>().select = false;
                selected = false;
                gameObject.tag = "Guzai";
                transform.parent = null;
            }
        }

        if (Player.GetComponent<CharacterMove2>().Goal == null && Destination != null && Player.transform.position != Destination.transform.position)
        {
            Player.GetComponent<CharacterMove2>().Goal = Destination;
        }

        if (Destination != null && Player.transform.position == Destination.transform.position)
        {
            Destination = null;
            gMaeCheck = true;
            gHidariCheck = true;
            gMigiCheck = true;
            gUsiroCheck = true;
        }

        if(transform.position.y < 0)
        {
            Player.GetComponent<CharacterMove2>().select = false;
            selected = false;
            transform.parent = null;
            rb.velocity = new Vector3(0, -2f, 0);
        }
    }

    public void GuzaiSelect()
    {
        selected = true;
        if((DistancegF == DistancegL && DistancegF > DistancegR) || (DistancegF == DistancegR && DistancegF > DistancegL) && DistancegF > DistancegB)
        {
            Destination = FrontCheck;
        }

        if ((DistancegB == DistancegL && DistancegB > DistancegR) || (DistancegB == DistancegR && DistancegB > DistancegL) && DistancegB > DistancegF)
        {
            Destination = BackCheck;
        }

        if(DistancegF > DistancegL && DistancegF > DistancegR && DistancegF > DistancegB)
        {
            Destination = FrontCheck;
        }

        if (DistancegL > DistancegF && DistancegL > DistancegR && DistancegL > DistancegB)
        {
            Destination = LeftCheck;
        }

        if (DistancegR > DistancegF && DistancegR > DistancegL && DistancegR > DistancegB)
        {
            Destination = RightCheck;
        }

        if (DistancegB > DistancegF && DistancegB > DistancegL && DistancegB > DistancegR)
        {
            Destination = BackCheck;
        }
    }
}
