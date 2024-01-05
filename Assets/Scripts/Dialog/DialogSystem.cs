using System.Collections;
using System.Collections.Generic;
using System.Text;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class DialogSystem : MonoBehaviour
{
    public static DialogSystem instance;

    public int Rang; //언어 0은 영어, 1은 한국어

    public int day; //몇번째 날인지

    public int index;

    //public Vector3 clickPos;

    private void Awake()
    {
        instance = this;
    }

    private void Update()
    {
        ////레이캐스트

        //if (Input.GetMouseButtonDown(0))
        //{
        //    clickPos = Input.mousePosition;


        //    Vector3 pos = Camera.main.ScreenToWorldPoint(clickPos);

        //    RaycastHit hit;

        //    if (Physics.Raycast(pos, transform.forward, out hit))
        //    {
        //        Debug.Log(hit.collider.name);

        //        if (panel.activeSelf == false)
        //        {
        //            if (hit.collider.gameObject.CompareTag("Character"))
        //            {
        //                nowCharacter.GetComponent<Dialog>().number++;
        //            }
        //        }
        //    }
        //}
    }

    public void Korean()
    {
        Rang = 1;
    }

    public void English()
    {
        Rang = 0;
    }
}
