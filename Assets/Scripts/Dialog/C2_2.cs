using Doublsb.Dialog;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;

public class C2_2 : MonoBehaviour
{
    public DialogManager DialogManager;

    public GameObject Button;

    private void OnEnable()
    {
        if (DialogSystem.instance.day == 1)
        {
            gameObject.SetActive(true);

            Button.SetActive(false);

            if (DialogSystem.instance.Rang == 0)
            {
                var dialogTexts = new List<DialogData>();

                dialogTexts.Add(new DialogData("/size:up/You're the best! /size:init/I think you're talented!\r\nWhen customers order perfumes, you have to be able to meet their needs.", "������"));

                dialogTexts.Add(new DialogData("Look for clues in your order like just now.\r\nYou start working tomorrow. Good luck!", "������"));

                dialogTexts.Add(new DialogData("What a hectic day..", "Player_none"));

                dialogTexts.Add(new DialogData("From tomorrow, I will make perfume in earnest. Let's cheer up and do well.", "Player_none"));

                DialogManager.Show(dialogTexts);
            }
            else
            {
                var dialogTexts = new List<DialogData>();

                dialogTexts.Add(new DialogData("/size:up/�ְ��! /size:init/����� �ִµ�?\r\n�մ��� ����� �ֹ��� �� �� ����ó�� �մԵ��� ��� ���� �� �־����.", "������"));

                dialogTexts.Add(new DialogData("�մ��� �ֹ����� �ܼ��� �� ã�ƺ�.\r\n���Ϻ��� �ٹ� �����̳�. �� �غ�������!", "������"));

                dialogTexts.Add(new DialogData("���ž��� �Ϸ翴��..", "Player_none"));

                dialogTexts.Add(new DialogData("���Ϻ��� ���������� ����� ����� �ɰŴ�.. ������ �� �غ���.", "Player_none"));

                DialogManager.Show(dialogTexts);
            }
        }
        else
        {
            gameObject.SetActive(false);
        }
    }

    public void Event1()
    {
        if (DialogSystem.instance.Rang == 0)
        {
            var dialogTexts = new List<DialogData>();

            dialogTexts.Add(new DialogData("Welcome to Mystique Parfume.", "Player"));

            dialogTexts.Add(new DialogData("/size:up/Well done!", "������"));

            dialogTexts.Add(new DialogData("Then you have to talk to the customer and understand the scent you want. /wait:0.3/Then let's start making perfume in earnest.", "������"));

            dialogTexts.Add(new DialogData("There are six types of scents in our store.", "������"));

            dialogTexts.Add(new DialogData("And if you click on the shelf you want to open it, you'll see the ingredients listed, and if you move up one by one, you'll see the corresponding information.", "������"));

            dialogTexts.Add(new DialogData("Then let's take the perfume order in earnest. /wait:0.3/I'll pretend to be a customer.", "������"));

            dialogTexts.Add(new DialogData("I love the scent of flowers./wait:0.3/ \r\nAt first, I hope romanticism will capture you,\r\nNext, flowers that smell like dirt would be good.", "������"));

            dialogTexts.Add(new DialogData("At the end, I hope you can feel the cool scent naturally.", "������"));

            DialogManager.Show(dialogTexts);
        }
        else
        {
            var dialogTexts = new List<DialogData>();

            dialogTexts.Add(new DialogData("�������, �̽�ƽ ��Ǿ�Դϴ�.", "Player"));

            dialogTexts.Add(new DialogData("/size:up/���߾�!", "������"));

            dialogTexts.Add(new DialogData("�׷� ���� �մ԰� ��ȭ�ϸ� ���ϴ� ���� �� �ľ��ؾ���. /wait:0.3/�� �׷� ���������� ����� ������.", "������"));

            dialogTexts.Add(new DialogData("�츮 ���Կ��� ���� ������ ���� ������ �з��ϰ� �־�.", "������"));

            dialogTexts.Add(new DialogData("�׸��� ���ϴ� ������ Ŭ���ؼ� �����, ���ٽ��� ������ �����������ٵ�, �ϳ��ϳ� ���콺�� �÷����� �ش��ϴ� ������ ���ϰž�.", "������"));

            dialogTexts.Add(new DialogData("�׷� ���������� ��� �ֹ��� �޾ƺ���. /wait:0.3/���� �մ��� ô �غ���.", "������"));

            dialogTexts.Add(new DialogData("���� ����Ⱑ �ʹ� ���ƿ�. /wait:0.3/\r\nó������ �θ�ƽ���� ���������� ���ڰ��,\r\n�������δ� �� ������ ǳ��� ���̸� ���ƿ�.", "������"));

            dialogTexts.Add(new DialogData("���������� �ÿ��� ���� �ڿ������� �������� ���ڳ׿�.", "������", () => Show_Button()));

            DialogManager.Show(dialogTexts);
        }
    }
    
    void Show_Button()
    {
        Button.SetActive(true);
    }
}
