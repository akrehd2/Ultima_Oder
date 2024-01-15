using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class AddDay : MonoBehaviour
{
    public GameObject[] Parfumes;
    public GameObject[] Hmms;
    public GameObject[] mades;

    public GameObject Poop;

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
        int Answer1 = 0, Answer2 = 0, Answer3 = 0;
        int R;

        if (DialogSystem.instance.day < 2)
        {
            //ÆÛÆåÆ®
            if (DialogSystem.instance.Oderlist[7] >= 23 && DialogSystem.instance.Oderlist[7] <= 43)
            {
                Answer1 = 1;
            }

            if (DialogSystem.instance.Oderlist[7] >= 57 && DialogSystem.instance.Oderlist[7] <= 77)
            {
                Answer1 = 1;
                Answer2 = 1;
            }

            if (DialogSystem.instance.Oderlist[8] >= 23 && DialogSystem.instance.Oderlist[8] <= 43)
            {
                Answer2 = 1;
            }

            if (DialogSystem.instance.Oderlist[10] >= 24 && DialogSystem.instance.Oderlist[10] <= 44)
            {
                Answer3 = 1;
            }
        }
        else if (DialogSystem.instance.day < 4)
        {
            //ÆÛÆåÆ®
            if (DialogSystem.instance.Oderlist[8] >= 30 && DialogSystem.instance.Oderlist[8] <= 50)
            {
                Answer1 = 1;
            }

            if (DialogSystem.instance.Oderlist[17] >= 30 && DialogSystem.instance.Oderlist[17] <= 50)
            {
                Answer2 = 1;
            }

            if (DialogSystem.instance.Oderlist[14] >= 10 && DialogSystem.instance.Oderlist[14] <= 30)
            {
                Answer3 = 1;
            }
        }
        else if (DialogSystem.instance.day < 6)
        {
            //ÆÛÆåÆ®
            if (DialogSystem.instance.Oderlist[8] >= 10 && DialogSystem.instance.Oderlist[8] <= 30)
            {
                Answer1 = 1;
            }

            if (DialogSystem.instance.Oderlist[7] >= 30 && DialogSystem.instance.Oderlist[7] <= 50)
            {
                Answer2 = 1;
            }

            if (DialogSystem.instance.Oderlist[9] >= 30 && DialogSystem.instance.Oderlist[9] <= 50)
            {
                Answer3 = 1;
            }
        }
        else if (DialogSystem.instance.day < 8)
        {
            //ÆÛÆåÆ®
            if (DialogSystem.instance.Oderlist[18] >= 50 && DialogSystem.instance.Oderlist[18] <= 70)
            {
                Answer1 = 1;
            }

            if (DialogSystem.instance.Oderlist[17] >= 20 && DialogSystem.instance.Oderlist[17] <= 40)
            {
                Answer2 = 1;
            }

            if (DialogSystem.instance.Oderlist[20] >= 1 && DialogSystem.instance.Oderlist[20] <= 20)
            {
                Answer3 = 1;
            }
        }
        else if (DialogSystem.instance.day < 10)
        {
            //ÆÛÆåÆ®
            if (DialogSystem.instance.Oderlist[21] > 0)
            {
                Answer1 = 1;
                Answer2 = 1;
                Answer3 = 1;
            }

            if (DialogSystem.instance.Oderlist[20] > 0)
            {
                Answer2 = 1;
            }

            if (DialogSystem.instance.Oderlist[19] > 0)
            {
                Answer3 = 1;
            }
        }

        R = Answer1 + Answer2 + Answer3;

        if (R == 3)
        {
            DialogSystem.instance.Result = 0;
        }
        else if (R >= 1)
        {
            DialogSystem.instance.Result = 1;
        }
        else if (R == 0)
        {
            DialogSystem.instance.Result = 2;
        }
        else
        {
            DialogSystem.instance.Result = 3;
        }
}

    public void ResultPf()
    {
        int maxValue = DialogSystem.instance.Notelist.Max();
        int maxIndex = DialogSystem.instance.Notelist.IndexOf(maxValue);

        Debug.Log(maxIndex);

        if (maxValue == 0)
        {
            Poop.SetActive(true);

            return;
        }

        if (DialogSystem.instance.day == 0 && DialogSystem.instance.Result == 0)    //Jeniffer
        {
            Parfumes[0].SetActive(true);
            DialogSystem.instance.MadePf[0] = true;
        }
        else if(DialogSystem.instance.day == 0 && DialogSystem.instance.Result != 0 && DialogSystem.instance.Result != 3)
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
        else if (DialogSystem.instance.day == 4 && DialogSystem.instance.Result == 0)   //Olivia
        {
            Parfumes[3].SetActive(true);
            DialogSystem.instance.MadePf[2] = true;
        }
        else if (DialogSystem.instance.day == 4 && DialogSystem.instance.Result == 1)
        {
            Parfumes[4].SetActive(true);
        }
        else if (DialogSystem.instance.day == 4 && DialogSystem.instance.Result == 2)
        {
            Hmms[maxIndex].SetActive(true);
        }
        else if (DialogSystem.instance.day == 6 && DialogSystem.instance.Result == 0)   //Tommy
        {
            Parfumes[5].SetActive(true);
            DialogSystem.instance.MadePf[3] = true;
        }
        else if (DialogSystem.instance.day == 6 && DialogSystem.instance.Result == 1)
        {
            Parfumes[6].SetActive(true);
        }
        else if (DialogSystem.instance.day == 6 && DialogSystem.instance.Result == 2)
        {
            Hmms[maxIndex].SetActive(true);
        }
        else if (DialogSystem.instance.day == 8 && DialogSystem.instance.Result == 0)   //Riam
        {
            Parfumes[7].SetActive(true);
            DialogSystem.instance.MadePf[4] = true;
        }
        else if (DialogSystem.instance.day == 8 && DialogSystem.instance.Result == 1)
        {
            Parfumes[8].SetActive(true);
        }
        else if (DialogSystem.instance.day == 8 && DialogSystem.instance.Result == 2)
        {
            Hmms[maxIndex].SetActive(true);
        }
        else if(DialogSystem.instance.Result == 3)
        {
            Poop.SetActive(true);
        }

        DialogSystem.instance.Notelist.Clear();
        DialogSystem.instance.Oderlist.Clear();

        DialogSystem.instance.Notelist = new List<int>() { 0, 0, 0, 0, 0, 0 };
        DialogSystem.instance.Oderlist = new List<int>() { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
    }
}
