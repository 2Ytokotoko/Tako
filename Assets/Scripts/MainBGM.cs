using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MainBGM : MonoBehaviour
{
    public static MainBGM instance;

    /*private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }

        else
        {
            Destroy(gameObject);
        }
    }*/

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (SceneManager.GetActiveScene().name == "Game")
        {
            Destroy(gameObject);
        }
    }
}
