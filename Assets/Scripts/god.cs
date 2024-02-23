using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class god : MonoBehaviour
{
    public static god instance;

    public bool Ending;

    public bool Clicker;

    public GameObject[] CheckPoints;

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
        Checker();
    }

    public void Checker()
    {
        if(Ending)
        {
            if (SceneManager.GetActiveScene().name == "TitleScene" && Clicker)
            {
                for (int i = 0; i < CheckPoints.Length; i++)
                {
                    CheckPoints[i].SetActive(true);
                }
            }
            else
            {
                for (int i = 0; i < CheckPoints.Length; i++)
                {
                    CheckPoints[i].SetActive(false);
                }
            }
        }
    }

    public void Load1()
    {
        DialogSystem.instance.day = 0;
        DialogSystem.instance.Result = 0;

        DialogSystem.instance.SaveDay();
    }

    public void Load2()
    {
        DialogSystem.instance.day = 2;
        DialogSystem.instance.Result = 0;

        DialogSystem.instance.MadePf[0] = true;

        DialogSystem.instance.SaveDay();
    }

    public void Load3()
    {
        DialogSystem.instance.day = 4;
        DialogSystem.instance.Result = 0;

        DialogSystem.instance.MadePf[0] = true;
        DialogSystem.instance.MadePf[1] = true;

        DialogSystem.instance.SaveDay();
    }

    public void Load4()
    {
        DialogSystem.instance.day = 6;
        DialogSystem.instance.Result = 0;

        DialogSystem.instance.MadePf[0] = true;
        DialogSystem.instance.MadePf[1] = true;
        DialogSystem.instance.MadePf[2] = true;

        DialogSystem.instance.SaveDay();
    }

    public void Load5()
    {
        DialogSystem.instance.day = 8;
        DialogSystem.instance.Result = 0;

        DialogSystem.instance.MadePf[0] = true;
        DialogSystem.instance.MadePf[1] = true;
        DialogSystem.instance.MadePf[2] = true;
        DialogSystem.instance.MadePf[3] = true;

        DialogSystem.instance.SaveDay();
    }

    public void Load6()
    {
        DialogSystem.instance.day = 10;
        DialogSystem.instance.Result = 0;

        DialogSystem.instance.MadePf[0] = true;
        DialogSystem.instance.MadePf[1] = true;
        DialogSystem.instance.MadePf[2] = true;
        DialogSystem.instance.MadePf[3] = true;
        DialogSystem.instance.MadePf[4] = true;

        DialogSystem.instance.SaveDay();
    }
}
