using System.Collections;
using System.Collections.Generic;
using System.Text;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class DialogSystem : MonoBehaviour
{
    public static DialogSystem instance;

    public int Rang; //��� 0�� ����, 1�� �ѱ���

    public int day; //���° ������

    public int index;

    //public Vector3 clickPos;

    private void Awake()
    {
        instance = this;
    }

    private void Update()
    {
        ////����ĳ��Ʈ

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
