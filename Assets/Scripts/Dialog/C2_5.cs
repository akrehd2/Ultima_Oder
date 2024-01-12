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

            dialogTexts.Add(new DialogData("Hello, this is Mystique Parfume.", "Player_O"));

            dialogTexts.Add(new DialogData("Hey, you know who I am, right?", "�ø����"));

            dialogTexts.Add(new DialogData("Yes?", "Player_O"));

            dialogTexts.Add(new DialogData("/emote:Sad/I Said Do YOU know me. /wate:0.3/Are you ignoring me right now? ", "�ø����"));

            dialogTexts.Add(new DialogData("/emote:Sad//speed:0.1/Oh... /speed:0.04/no, sir. I'm so sorry.", "Player_O"));

            dialogTexts.Add(new DialogData("/emote:Sad//size:down/ha.. I wonder if you can make the perfume I want..", "�ø����"));

            dialogTexts.Add(new DialogData("/emote:Sad//size:init/Please tell me what you want and we will do our best to meet your expectations.", "Player_O"));

            dialogTexts.Add(new DialogData("/emote:Sad/Yes... well... then I'll give you one chance.", "�ø����"));

            dialogTexts.Add(new DialogData("/emote:Sad/Thank you for trusting me.", "Player_O"));

            dialogTexts.Add(new DialogData("Please make a perfume just like me. What color comes to mind when you see me?\r\nDoesn't the beautiful purple color come to mind? I think I've given you a lot of hints.", "�ø����"));

            dialogTexts.Add(new DialogData("Oh, that's right... I don't like anything else, I only like flowers.\r\nSo, at first, I want it to smell like purple flowers.", "�ø����"));

            dialogTexts.Add(new DialogData("And I want that the more I smell the scent, the more mysterious I feel.", "�ø����"));

            dialogTexts.Add(new DialogData("A contradictory scent...\r\nLastly, I will tell you exactly what scent I like: Lavender, please.\r\nYou can do it well, right? I've helped you a lot, right?", "�ø����", () => Show_Button()));

            DialogManager.Show(dialogTexts);
        }
        else
        {
            var dialogTexts = new List<DialogData>();

            dialogTexts.Add(new DialogData("�ȳ��ϼ���, �̽�ƽ ��Ǿ�Դϴ�.", "Player_O"));

            dialogTexts.Add(new DialogData("�̺���, �� ������ ����?", "�ø����"));

            dialogTexts.Add(new DialogData("��?", "Player_O"));

            dialogTexts.Add(new DialogData("/emote:Sad/�� �ƽóı���, /wate:0.3/���� �����ϴ� �ǰ�?", "�ø����"));

            dialogTexts.Add(new DialogData("/emote:Sad//speed:0.1/��... /speed:0.04/�˼��մϴ�, �մ�.", "Player_O"));

            dialogTexts.Add(new DialogData("/emote:Sad//size:down/��.. �̷��� ���� ���ϴ� ����� ���� ���� ��������..", "�ø����"));

            dialogTexts.Add(new DialogData("/emote:Sad//size:init/���Ͻô� �κ��� �������ֽø� ������ ��뿡 ������ �� �ֵ��� �ּ��� ���ϰڽ��ϴ�.", "Player_O"));

            dialogTexts.Add(new DialogData("/emote:Sad/��.. ��.. �׷� �ѹ��� ��ȸ�� �帮��.", "�ø����"));

            dialogTexts.Add(new DialogData("/emote:Sad/�ϰ� �ð��ּż� �����մϴ�.", "Player_O"));

            dialogTexts.Add(new DialogData("�� �� ���� ��� ������ּ���. \r\n�� ���� ���� ���� ����������? \r\n�Ƹ��ٿ� ������� �������� �ʳ���? �������� ��Ʈ ���� �帰 �� ������.", "�ø����"));

            dialogTexts.Add(new DialogData("�� �´�.. �� �ٸ��� �Ȱ� ������ �ɸ� �����ؿ�. \r\n�׷��ϱ�, ���� ó������ ����� �� ��Ⱑ ������ ���ھ��.\r\n�׸��� ��⸦ ���� ���� �� �� �� ���� ������ ������ ���ڴµ�.", "�ø����"));

            dialogTexts.Add(new DialogData("��ġ ������� ���.. ���������� ���� ���� �� ���ص帱�Կ�. �󺥴�. ��Ź�ؿ�.\r\n�� �� �� �ְ���? ���� ���� ���帰�ſ��� ��?", "�ø����", () => Show_Button()));

            DialogManager.Show(dialogTexts);
        }
    }

    void Show_Button()
    {
        Button.SetActive(true);
    }
}
