using Doublsb.Dialog;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;

public class C2_3 : MonoBehaviour
{
    public DialogManager DialogManager;

    public GameObject Grandma;

    public GameObject Button;

    public GameObject Printer;

    private void OnEnable()
    {
        if (DialogSystem.instance.day == 2)
        {
            gameObject.SetActive(true);

            Invoke("Show_C", 3f);
        }
        else
        {
            gameObject.SetActive(false);
        }
    }

    public void Show_C()
    {
        Grandma.SetActive(true);

        Grandma.GetComponent<AudioSource>().Play();
    }

    public void Start3day()
    {
        if (DialogSystem.instance.Rang == 0)
        {
            var dialogTexts = new List<DialogData>();

            dialogTexts.Add(new DialogData("Bonjour, this is Mystique Parfume, we make perfumes with the scent you want.", "Player_A"));

            dialogTexts.Add(new DialogData("/speed:0.06/Hello. I stopped by once while passing by.. \nYou make perfumes according to the scent whatever I want..? Ho-ho.", "��"));

            dialogTexts.Add(new DialogData("/speed:0.06/Reminds me of the first time I bought a perfume... when I was a girl, I used it a lot because of my husband now..", "��"));

            dialogTexts.Add(new DialogData("What a romantic story.", "Player_A"));

            dialogTexts.Add(new DialogData("/speed:0.06/I want to make a gift for my grandchild. I'm worried because my grandchild has a very poor appetite. I don't know much about perfumes,", "��"));

            dialogTexts.Add(new DialogData("/speed:0.06/but are there cases where food fragrances are used? It would be great if there could be strong scents of carrots and cucumbers.", "��"));

            dialogTexts.Add(new DialogData("/speed:0.06/And maybe adding a scent that stimulates the appetite and makes the body feel more relaxed slightly??", "��", () => Show_Button()));

            DialogManager.Show(dialogTexts);
        }
        else
        {
            var dialogTexts = new List<DialogData>();

            dialogTexts.Add(new DialogData("�ȳ��ϼ���, ���ϴ� ������ ����� ������ִ� ����, �̽�ƽ ��Ǿ�Դϴ�.", "Player_A"));

            dialogTexts.Add(new DialogData("/speed:0.06/�ȳ��ϽŰ���. �������ٰ� �� �� �鷶�׸�.. \n���ϴ´�� ���� ����� ������شٰ��.. ȣȣ.", "��"));

            dialogTexts.Add(new DialogData("/speed:0.06/ù ����� ���� ���� �������׿�.. ó�� ���� ��, ���� ������ ���� ����߾��µ�..", "��"));

            dialogTexts.Add(new DialogData("�������� �̾߱ⱺ��.", "Player_A"));

            dialogTexts.Add(new DialogData("/speed:0.06/���ֿ��� �� ������ ����� �ͳ׿�. ���ְ� �Ŀ��� �ʹ� ��� �����ε�.. ���� ����� ���� �� �𸨴ϴٸ�..", "��"));

            dialogTexts.Add(new DialogData("/speed:0.06/���̰� ��ٰ� ���̸� ����ؼ� ����ϴµ� ���� ��⸦ �ִ� ��쵵 �ֳ���? ��ٰ� ���� ���� ���� ���� ���ڱ��տ�..", "��"));

            dialogTexts.Add(new DialogData("/speed:0.06/�Ŀ��� �� ������ ���� ����ϰ� ���ִ� �⵵ ��¦ �־����� �ʰھ��?", "��", () => Show_Button()));

            DialogManager.Show(dialogTexts);
        }
    }

    public void click()
    {
        if (Printer.activeSelf == false)
        {
            if (DialogSystem.instance.Rang == 0)
            {
                var dialogTexts = new List<DialogData>();

                dialogTexts.Add(new DialogData("Oh, is there anything old man can do for you?", "��"));

                DialogManager.Show(dialogTexts);
            }
            else
            {
                var dialogTexts = new List<DialogData>();

                dialogTexts.Add(new DialogData("��, �����̰� ����� �ֳ���?", "��"));

                DialogManager.Show(dialogTexts);
            }
        }
    }

    void Show_Button()
    {
        Button.SetActive(true);
    }
}
