using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tweet : MonoBehaviour
{
    public void OnClickTwitterButton()
    {
        StartCoroutine(TweetWithScreenShot.TweetManager.TweetWithScreenShot("����Ȃ��ٓ����������I"));
    }
}
