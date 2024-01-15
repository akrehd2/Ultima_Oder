using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class OderText : MonoBehaviour
{
    [TextArea]
    public string[] Oders;
    public TextMeshProUGUI Otext;
    public TextMeshProUGUI Ttext;

    private void Update()
    {
        if (DialogSystem.instance.Rang == 0)
        {
            Ttext.text = "Order details";
        }
        else
        {
            Ttext.text = "주문 내용";
        }

        if (DialogSystem.instance.day == 0)
        {
            if(DialogSystem.instance.Rang == 0)
            {
                Otext.text = Oders[0];
            }
            else
            {
                Otext.text = Oders[1];
            }
        }
        else if (DialogSystem.instance.day == 2)
        {
            if (DialogSystem.instance.Rang == 0)
            {
                Otext.text = Oders[2];
            }
            else
            {
                Otext.text = Oders[3];
            }
        }
        else if (DialogSystem.instance.day == 4)
        {
            if (DialogSystem.instance.Rang == 0)
            {
                Otext.text = Oders[4];
            }
            else
            {
                Otext.text = Oders[5];
            }
        }
        else if (DialogSystem.instance.day == 6)
        {
            if (DialogSystem.instance.Rang == 0)
            {
                Otext.text = Oders[6];
            }
            else
            {
                Otext.text = Oders[7];
            }
        }
        else if (DialogSystem.instance.day == 8)
        {
            if (DialogSystem.instance.Rang == 0)
            {
                Otext.text = Oders[8];
            }
            else
            {
                Otext.text = Oders[9];
            }
        }
        else if (DialogSystem.instance.day == 10)
        {
            if (DialogSystem.instance.Rang == 0)
            {
                Otext.text = Oders[10];
            }
            else
            {
                Otext.text = Oders[11];
            }
        }
    }
}
