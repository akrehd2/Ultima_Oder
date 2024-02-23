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
        if (DialogSystem.instance.day == 0)
        {
            if(DialogSystem.instance.Rang == 0)
            {
                Otext.text = Oders[0];
                Ttext.text = "Order details            <size=30>Recommended Number of ingredients: 2~3</size>";
            }
            else
            {
                Otext.text = Oders[1];
                Ttext.text = "�ֹ� ����                                                          <size=30>��õ ��� ����: 2~3</size>";
            }
        }
        else if (DialogSystem.instance.day == 2)
        {
            if (DialogSystem.instance.Rang == 0)
            {
                Otext.text = Oders[2];
                Ttext.text = "Order details               <size=30>Recommended Number of ingredients: 3</size>";
            }
            else
            {
                Otext.text = Oders[3];
                Ttext.text = "�ֹ� ����                                                             <size=30>��õ ��� ����: 3</size>";
            }
        }
        else if (DialogSystem.instance.day == 4)
        {
            if (DialogSystem.instance.Rang == 0)
            {
                Otext.text = Oders[4];
                Ttext.text = "Order details               <size=30>Recommended Number of ingredients: 3</size>";
            }
            else
            {
                Otext.text = Oders[5];
                Ttext.text = "�ֹ� ����                                                             <size=30>��õ ��� ����: 3</size>";
            }
        }
        else if (DialogSystem.instance.day == 6)
        {
            if (DialogSystem.instance.Rang == 0)
            {
                Otext.text = Oders[6];
                Ttext.text = "Order details               <size=30>Recommended Number of ingredients: 3</size>";
            }
            else
            {
                Otext.text = Oders[7];
                Ttext.text = "�ֹ� ����                                                             <size=30>��õ ��� ����: 3</size>";
            }
        }
        else if (DialogSystem.instance.day == 8)
        {
            if (DialogSystem.instance.Rang == 0)
            {
                Otext.text = Oders[8];
                Ttext.text = "Order details               <size=30>Recommended Number of ingredients: 1</size>";
            }
            else
            {
                Otext.text = Oders[9];
                Ttext.text = "�ֹ� ����                                                             <size=30>��õ ��� ����: 1</size>";
            }
        }
        else if (DialogSystem.instance.day == 10)
        {
            if (DialogSystem.instance.Rang == 0)
            {
                Otext.text = Oders[10];
                Ttext.text = "Order details               <size=30>Recommended Number of ingredients: 1</size>";
            }
            else
            {
                Otext.text = Oders[11];
                Ttext.text = "�ֹ� ����                                                             <size=30>��õ ��� ����: 1</size>";
            }
        }
    }
}
