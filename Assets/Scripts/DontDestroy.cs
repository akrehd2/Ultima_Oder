using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DontDestroy : MonoBehaviour
{
    public static DontDestroy instance;

    public GameObject all;

    public GameObject Some;

    public Texture2D cursorTextureA;
    public Texture2D cursorTextureB;

    public CursorMode cursorMode = CursorMode.Auto;
    public Vector2 hotSpot = Vector2.zero;

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
        if(Input.GetMouseButton(0))
        {
            Cursor.SetCursor(cursorTextureB, hotSpot, cursorMode);
        }
        else
        {
            hotSpot.x = cursorTextureA.width / 2;

            Cursor.SetCursor(cursorTextureA, hotSpot, cursorMode);
        }

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
