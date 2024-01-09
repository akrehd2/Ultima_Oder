using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class AddDay : MonoBehaviour
{
    public GameObject[] Parfumes;
    public GameObject[] Hmms;
    public GameObject[] mades;

    private void Update()
    {
        for (int i = 0; i < DialogSystem.instance.MadePf.Length; i++)
        {
            if (DialogSystem.instance.MadePf[i] == true)
            {
                mades[i].SetActive(true);
            }
        }
    }

    public void AddDay1()
    {
        DialogSystem.instance.day += 1;
    }

    public void CheakScore() 
    {
        if(DragImage.totalScore >= 3)
        {
            DialogSystem.instance.Result = 0;
        }
        else if (DragImage.totalScore >= 1)
        {
            DialogSystem.instance.Result = 1;
        }
        else
        {
            DialogSystem.instance.Result = 2;
        }

        DragImage.totalScore = 0;
        DragImage.dragCount = 0;
    }

    public void ResultPf()
    {
        int maxValue = DialogSystem.instance.Notelist.Max();
        int maxIndex = DialogSystem.instance.Notelist.IndexOf(maxValue);

        Debug.Log(maxIndex);

        //if(maxValue == 0)
        //{
        //    return;
        //}

        if (DialogSystem.instance.day == 0 && DialogSystem.instance.Result == 0)    //Jeniffer
        {
            Parfumes[0].SetActive(true);
            DialogSystem.instance.MadePf[0] = true;
        }
        else if(DialogSystem.instance.day == 0 && DialogSystem.instance.Result != 0)
        {
            Hmms[maxIndex].SetActive(true);
        }
        else if (DialogSystem.instance.day == 2 && DialogSystem.instance.Result == 0)   //Anne
        {
            Parfumes[1].SetActive(true);
            DialogSystem.instance.MadePf[1] = true;
        }
        else if (DialogSystem.instance.day == 2 && DialogSystem.instance.Result == 1)
        {
            Parfumes[2].SetActive(true);
        }
        else if (DialogSystem.instance.day == 2 && DialogSystem.instance.Result == 2)
        {
            Hmms[maxIndex].SetActive(true);
        }
    }
}
