using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tweet : MonoBehaviour
{
    public void OnClickTwitterButton()
    {
        StartCoroutine(TweetWithScreenShot.TweetManager.TweetWithScreenShot("こんなお弁当を作ったよ！"));
    }
}
