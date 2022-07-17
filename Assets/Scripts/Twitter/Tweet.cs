using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tweet : MonoBehaviour
{
    public void OnClickTwitterButton()
    {
        StartCoroutine(TweetWithScreenShot.TweetManager.TweetWithScreenShot("‚±‚ñ‚È‚¨•Ù“–‚ğì‚Á‚½‚æI"));
    }
}
