using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Skip : MonoBehaviour
{
    public Text texts;

    public GameObject MoveB;
    public GameObject DayB;

    public GameObject End;

    public GameObject[] Cha;

    public void SkipS()
    {
        texts.text = "";

        if (DialogSystem.instance.day % 2 == 0)
        {
            Chafalse();
            MoveB.SetActive(true);

            if(DialogSystem.instance.day == 0)
            {
                Cha[6].SetActive(true);
            }
            else if (DialogSystem.instance.day == 2)
            {
                Cha[9].SetActive(true);
            }
            else if (DialogSystem.instance.day == 4)
            {
                Cha[11].SetActive(true);
            }
            else if (DialogSystem.instance.day == 6)
            {
                Cha[12].SetActive(true);
            }
            else if (DialogSystem.instance.day == 8)
            {
                Cha[13].SetActive(true);
            }
            else if (DialogSystem.instance.day == 10)
            {
                Cha[15].SetActive(true);
                End.SetActive(true);
                MoveB.SetActive(false);
            }
        }
        else
        {
            Chafalse();
            DayB.SetActive(true);
        }
    }
    public void Chafalse()
    {
        for(int i = 0; i < Cha.Length; i++)
        {
            Cha[i].SetActive(false);
        }
    }
}
