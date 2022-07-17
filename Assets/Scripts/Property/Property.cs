using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Property : MonoBehaviour
{
    private int frontleft;
    private int frontright;
    private int leftfront;
    private int leftback;
    private int rightfront;
    private int rightback;
    private int backleft;
    private int backright;

    public int FrontLeft
    {
        get { return frontleft;}
        set { frontleft = value; }
    }

    public int FrontRight
    {
        get { return frontright; }
        set { frontright = value; }
    }

    public int LeftFront
    {
        get { return leftfront; }
        set { leftfront = value; }
    }

    public int LeftBack
    {
        get { return leftback; }
        set { leftback = value; }
    }

    public int RightFront
    {
        get { return rightfront; }
        set { rightfront = value; }
    }

    public int RightBack
    {
        get { return rightback; }
        set { rightback = value; }
    }

    public int BackLeft
    {
        get { return backleft; }
        set { backleft = value; }
    }

    public int BackRight
    {
        get { return backright; }
        set { backright = value; }
    }
}
