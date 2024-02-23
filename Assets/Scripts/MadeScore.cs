using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using static UnityEngine.Rendering.PostProcessing.HistogramMonitor;
using System.Linq;

public class MadeScore : MonoBehaviour
{
    public static MadeScore instance;

    public GameObject[] Beaker;

    public GameObject Fill;
    public GameObject Spoit;

    public TextMeshProUGUI Per;

    public float Timer;
    public float Speed;

    public int Changer;

    public int Amount;

    public int Note;
    public int Oder;

    public int Try;

    public bool isClick;

    public Color[] colors = { new Color(1, 0.9490196f, 0.8f, 1), new Color(0.972549f, 0.7960784f, 0.6784314f, 1), new Color(1, 0.7568628f, 0.8784314f, 1),
        new Color(1, 0.6f, 0.6f, 1), new Color(0.7254902f, 0.9764706f, 0.8941177f, 1), new Color(0.6627451f, 0.8156863f, 0.5568628f, 1) };

    float Percen = 0f;
    Color Rcolor = new Color(0, 0, 0, 0);

    private void Awake()
    {
        instance = this;

        Speed = 0.05f;
    }

    private void Update()
    {
        if(Note == 0)
        {
            Spoit.GetComponent<Image>().color = colors[0];
        }
        else if (Note == 1)
        {
            Spoit.GetComponent<Image>().color = colors[1];
        }
        else if (Note == 2)
        {
            Spoit.GetComponent<Image>().color = colors[2];
        }
        else if (Note == 3)
        {
            Spoit.GetComponent<Image>().color = colors[3];
        }
        else if (Note == 4)
        {
            Spoit.GetComponent<Image>().color = colors[4];
        }
        else if (Note == 5)
        {
            Spoit.GetComponent<Image>().color = colors[5];
        }

        if(DialogSystem.instance.Notelist[0] > 0 && Amount - DialogSystem.instance.Notelist[0] == 0)
        {
            Fill.GetComponent<Image>().color = colors[0];
        }
        else if (DialogSystem.instance.Notelist[1] > 0 && Amount - DialogSystem.instance.Notelist[1] == 0)
        {
            Fill.GetComponent<Image>().color = colors[1];
        }
        else if (DialogSystem.instance.Notelist[2] > 0 && Amount - DialogSystem.instance.Notelist[2] == 0)
        {
            Fill.GetComponent<Image>().color = colors[2];
        }
        else if (DialogSystem.instance.Notelist[3] > 0 && Amount - DialogSystem.instance.Notelist[3] == 0)
        {
            Fill.GetComponent<Image>().color = colors[3];
        }
        else if (DialogSystem.instance.Notelist[4] > 0 && Amount - DialogSystem.instance.Notelist[4] == 0)
        {
            Fill.GetComponent<Image>().color = colors[4];
        }
        else if (DialogSystem.instance.Notelist[5] > 0 && Amount - DialogSystem.instance.Notelist[5] == 0)
        {
            Fill.GetComponent<Image>().color = colors[5];
        }
        else
        {
            Percen = 0f;
            Rcolor = new Color(0, 0, 0, 0);

            for (int i = 0; i < DialogSystem.instance.Notelist.Count; i++)
            {
                if (DialogSystem.instance.Notelist[i] != 0)
                {
                    Percen = (float)DialogSystem.instance.Notelist[i] / (float)Amount;

                    Rcolor += colors[i] * Percen;
                }
            }

            Fill.GetComponent<Image>().color = Rcolor;
        }

        Fill.GetComponent<Image>().fillAmount = (float)Amount / 100;

        Spoit.GetComponent<Image>().fillAmount = 1 - (float)Amount / 100;

        Per.text = Amount + "%";

        if (isClick)
        {
            if(Timer > Speed)
            {
                if (Amount < 100)
                {
                    Amount += 1;
                    DialogSystem.instance.Notelist[Note] += 1;
                    DialogSystem.instance.Oderlist[Oder] += 1;
                }

                Changer += 1;
                Timer = 0;
            }
            Timer += Time.deltaTime;
        }

        if(Changer >= 25)
        {
            Speed = Random.Range(0.01f, 0.05f);
            Changer = 0;
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
            Beaker[Try].GetComponent<Image>().color = Fill.GetComponent<Image>().color;

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
