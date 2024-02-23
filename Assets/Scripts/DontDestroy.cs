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
    public Texture2D cursorTextureC;

    public bool cursorC;

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
        if(Camera.main.orthographicSize != 3)
        {
            cursorC = false;
        }

        if (Input.GetMouseButton(0) && cursorC == false)
        {
            Cursor.SetCursor(cursorTextureB, hotSpot, cursorMode);
        }
        else if (Input.GetMouseButton(0) && cursorC == true)
        {
            hotSpot.x = cursorTextureC.width / 2;
            hotSpot.y = cursorTextureC.height / 2.4f;

            Cursor.SetCursor(cursorTextureC, hotSpot, cursorMode);
        }
        else if(cursorC)
        {
            hotSpot.x = cursorTextureC.width / 2;
            hotSpot.y = cursorTextureC.height / 2;

            Cursor.SetCursor(cursorTextureC, hotSpot, cursorMode);
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

    public void Con()
    {
        cursorC = true;
    }

    public void Coff()
    {
        cursorC = false;
    }

    public void Des()
    {
        Destroy(gameObject);
    }
}
