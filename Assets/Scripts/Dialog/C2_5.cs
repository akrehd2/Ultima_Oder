using Doublsb.Dialog;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;

public class C2_5 : MonoBehaviour
{
    public DialogManager DialogManager;

    public GameObject Olivia;

    public GameObject Button;

    public GameObject Printer;

    private void OnEnable()
    {
        if (DialogSystem.instance.day == 4)
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
        Olivia.SetActive(true);

        Olivia.GetComponent<AudioSource>().Play();
    }

    public void Start4day()
    {
        if (DialogSystem.instance.Rang == 0)
        {
            var dialogTexts = new List<DialogData>();

            dialogTexts.Add(new DialogData("Bonjour, this is Mystique Parfume.", "Player_O"));

            dialogTexts.Add(new DialogData("Hey, you know who I am, right?", "�ø����"));

            dialogTexts.Add(new DialogData("Yes?", "Player_O"));

            dialogTexts.Add(new DialogData("/emote:Sad/Don't you KNOW me? /wate:0.3/Are you ignoring me right now? ", "�ø����"));

            dialogTexts.Add(new DialogData("/emote:Sad//speed:0.1/Oh... /speed:0.04/no, sir. I'm so sorry.", "Player_O"));

            dialogTexts.Add(new DialogData("/emote:Sad//size:down/ha.. I wonder if you can make the perfume I want..", "�ø����"));

            dialogTexts.Add(new DialogData("/emote:Sad//size:init/Please tell me what you want and we will do our best to meet your expectations.", "Player_O"));

            dialogTexts.Add(new DialogData("/emote:Sad/Yes... well... then I'll give you one chance.", "�ø����"));

            dialogTexts.Add(new DialogData("/emote:Sad/Thank you for trusting me.", "Player_O"));

            dialogTexts.Add(new DialogData("Please make a perfume just like me. What color comes to mind when you see me? \nDoesn't the beautiful purple color come to mind? I think I've given you a lot of hints.", "�ø����"));

            dialogTexts.Add(new DialogData("Oh, that's right... I don't like anything else, I only like flowers. \nSo, I would love it if there was a hint of purple floral scent in the beginning.", "�ø����"));

            dialogTexts.Add(new DialogData("And as I smell the fragrance more, I would like to experience an indescribable feeling, like a contradictory scent...", "�ø����"));

            dialogTexts.Add(new DialogData("Lastly, I will give you a specific scent: lavender. Make it smell strongly of lavender. Can you do it well? I've helped you a lot, right?", "�ø����", () => Show_Button()));

            DialogManager.Show(dialogTexts);
        }
        else
        {
            var dialogTexts = new List<DialogData>();

            dialogTexts.Add(new DialogData("�ȳ��ϼ���, �̽�ƽ ��Ǿ�Դϴ�.", "Player_O"));

            dialogTexts.Add(new DialogData("�̺���, �� ������ ����?", "�ø����"));

            dialogTexts.Add(new DialogData("��?", "Player_O"));

            dialogTexts.Add(new DialogData("/emote:Sad/�� �𸣼���? /wate:0.3/���� �����ϴ� �ǰ�?", "�ø����"));

            dialogTexts.Add(new DialogData("/emote:Sad//speed:0.1/��... /speed:0.04/�˼��մϴ�, �մ�.", "Player_O"));

            dialogTexts.Add(new DialogData("/emote:Sad//size:down/��.. �̷��� ���� ���ϴ� ����� ���� ���� ��������..", "�ø����"));

            dialogTexts.Add(new DialogData("/emote:Sad//size:init/���Ͻô� �κ��� �������ֽø� ������ ��뿡 ������ �� �ֵ��� �ּ��� ���ϰڽ��ϴ�.", "Player_O"));

            dialogTexts.Add(new DialogData("/emote:Sad/��.. ��.. �׷� �ѹ��� ��ȸ�� �帮��.", "�ø����"));

            dialogTexts.Add(new DialogData("/emote:Sad/�ϰ� �ð��ּż� �����մϴ�.", "Player_O"));

            dialogTexts.Add(new DialogData("�� �� ���� ����� ������ּ���. \n�� ���� ���� ���� ����������? \n�Ƹ��ٿ� ������� �������� �ʳ���? �������� ��Ʈ ���� �帰 �� ������.", "�ø����"));

            dialogTexts.Add(new DialogData("�� �´�.. �� �ٸ��� �Ȱ� ������ �ɸ� �����ؿ�. \n�׷��ϱ�, ���� ó������ ����� �� ��Ⱑ ��¦ ������ ���ھ��. \n�׸��� ��⸦ ���� ���� �� �� �� ���� ������ ��û ������ ���ڴµ�.", "�ø����"));

            dialogTexts.Add(new DialogData("��ġ ������� ���.. ���������� ���� ���� �� ���ص帱�Կ�. �󺥴�. �󺥴� ���� ���� ���� ��Ź�ؿ�. \n�� �� �� �ְ���? ���� ���� ���帰�ſ��� ��?", "�ø����", () => Show_Button()));

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

                dialogTexts.Add(new DialogData("/emote:Sad/What are you doing standing in a daze? Go make it!", "�ø����"));

                DialogManager.Show(dialogTexts);
            }
            else
            {
                var dialogTexts = new List<DialogData>();

                dialogTexts.Add(new DialogData("/emote:Sad/���ϴ� ���� ���ؿ�?! � ���鷯����!!", "�ø����"));

                DialogManager.Show(dialogTexts);
            }
        }
    }

    void Show_Button()
    {
        Button.SetActive(true);
    }
}
