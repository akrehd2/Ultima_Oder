using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DontDestroy : MonoBehaviour
{
    public static DontDestroy instance;

    public GameObject all;

    public GameObject Some;

    private void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);
            return;
        }
        instance = this;
        DontDestroyOnLoad(gameObject);
    }

    private void Update()
    {
        if (SceneManager.GetActiveScene().name == ("GameScene"))
        {
            all.gameObject.SetActive(true);
        }
        else
        {
            all.gameObject.SetActive(false);
        }

        if (SceneManager.GetActiveScene().name == ("TitleScene"))
        {
            Some.gameObject.SetActive(false);
        }
        else
        {
            Some.gameObject.SetActive(true);
        }
    }

    public void Des()
    {
        Destroy(gameObject);
    }
}
