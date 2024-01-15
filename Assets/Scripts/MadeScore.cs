using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.Experimental.GraphView;
using UnityEngine.UI;

public class MadeScore : MonoBehaviour
{
    public static MadeScore instance;

    public GameObject[] Beaker;

    public GameObject Fill;
    public GameObject Spoit;

    public float Timer;

    public int Amount;

    public int Note;
    public int Oder;

    public int Try;

    public bool isClick;

    private void Awake()
    {
        instance = this;
    }

    private void Update()
    {
        Fill.GetComponent<Image>().fillAmount = (float)Amount / 100;

        Spoit.GetComponent<Image>().fillAmount = 1 - (float)Amount / 100;

        if(isClick)
        {
            if(Timer > 0.05f)
            {
                if (Amount < 100)
                {
                    Amount += 1;
                    DialogSystem.instance.Notelist[Note] += 1;
                    DialogSystem.instance.Oderlist[Oder] += 1;
                }

                Timer = 0;
            }
            Timer += Time.deltaTime;
        }
    }

    public void Retry()
    {
        if(Try < 3)
        {
            Amount = 0;
            DialogSystem.instance.Notelist = new List<int>() { 0, 0, 0, 0, 0, 0 };
            DialogSystem.instance.Oderlist = new List<int>() { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

            Beaker[Try].SetActive(true);

            Try++;
        }
    }

    public void Down()
    {
        isClick = true;
    }

    public void up()
    {
        isClick = false;
    }
}
