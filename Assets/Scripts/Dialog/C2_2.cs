using Doublsb.Dialog;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;

public class C2_2 : MonoBehaviour
{
    public DialogManager DialogManager;

    public GameObject Button;
    public GameObject NextButton;
    public GameObject RoseE;
    public GameObject RoseK;

    private void OnEnable()
    {
        if (DialogSystem.instance.day == 1)
        {
            gameObject.SetActive(true);

            Button.SetActive(false);

            if (DialogSystem.instance.Result == 0)
            {
                Zoom.instance.Shaking = true;

                if (DialogSystem.instance.Rang == 0)
                {
                    var dialogTexts = new List<DialogData>();

                    dialogTexts.Add(new DialogData("/emote:Happy//size:up/You're the best! /size:init/I think you're talented!\r\nWhen customers order perfumes, you have to be able to meet their needs.", "������"));

                    dialogTexts.Add(new DialogData("Look for clues in your order like just now.\r\nYou start working tomorrow. Good luck!", "������"));

                    dialogTexts.Add(new DialogData("/sound:Door/What a hectic day..", "Player_none"));

                    dialogTexts.Add(new DialogData("From tomorrow, I will make perfume in earnest. Let's cheer up and do well.", "Player_none", () => Show_NextButton()));

                    DialogManager.Show(dialogTexts);
                }
                else
                {
                    var dialogTexts = new List<DialogData>();

                    dialogTexts.Add(new DialogData("/emote:Happy//size:up/�ְ��! /size:init/����� �ִµ�?\r\n�մ��� ����� �ֹ��� �� �� ����ó�� �մԵ��� ��� ���� �� �־����.", "������"));

                    dialogTexts.Add(new DialogData("�մ��� �ֹ����� �ܼ��� �� ã�ƺ�.\r\n���Ϻ��� �ٹ� �����̳�. �� �غ�������!", "������"));

                    dialogTexts.Add(new DialogData("/sound:Door/���ž��� �Ϸ翴��..", "Player_none"));

                    dialogTexts.Add(new DialogData("���Ϻ��� ���������� ����� ����� �ɰŴ�.. ������ �� �غ���.", "Player_none", () => Show_NextButton()));

                    DialogManager.Show(dialogTexts);
                }
            }
            else if (DialogSystem.instance.Result == 1)
            {
                if (DialogSystem.instance.Rang == 0)
                {
                    var dialogTexts = new List<DialogData>();

                    dialogTexts.Add(new DialogData("It's Not Bad. You have an understanding of perfumes.\r\nBut, when the customer order perfume, you have to cater to customers' needs.", "������"));

                    dialogTexts.Add(new DialogData("To do that, we need to be able to find clues in your order, right?\r\nLet's take a good look at the order I just made.", "������"));

                    dialogTexts.Add(new DialogData("\"At first, I hope it's romantic,\" what's the closest ingredient we have in this spell?", "������", () => Show_RoseE()));

                    dialogTexts.Add(new DialogData("As you can see, it's a rose. You should be able to understand your intentions as well as you are now. Try your best!", "������", () => Hide_RoseE()));

                    dialogTexts.Add(new DialogData("/sound:Door/What a hectic day..", "Player_none"));

                    dialogTexts.Add(new DialogData("From tomorrow, I will make perfume in earnest. Let's cheer up and do well.", "Player_none", () => Show_NextButton()));

                    DialogManager.Show(dialogTexts);
                }
                else
                {
                    var dialogTexts = new List<DialogData>();

                    dialogTexts.Add(new DialogData("������ �ʾ�, ����� ���� ���ص��� �־�.\r\n������, �մ��� ����� �ֹ��� �� �� �մԵ��� ��� �������.", "������"));

                    dialogTexts.Add(new DialogData("�׷����� �մ��� �ֹ����� �ܼ��� �� ã�� �� �־�߰���?\r\n��� ���� �� �ֹ��� �� ���캸��.", "������"));

                    dialogTexts.Add(new DialogData("\"ó������ �θ�ƽ���� ���������� ���ڰ��,\" �� �ֹ����� �츮�� �����ִ� ��� �߿� ���� ������ ��ᰡ ����?", "������", () => Show_RoseK()));

                    dialogTexts.Add(new DialogData("���ٽ��� ����� �� �� �� �����ž�. ����ó�� �մ��� �ǵ��� �� �ľ��� �� �־����. �� �غ����� ��!", "������", () => Hide_RoseK()));

                    dialogTexts.Add(new DialogData("/sound:Door/���ž��� �Ϸ翴��..", "Player_none"));

                    dialogTexts.Add(new DialogData("���Ϻ��� ���������� ����� ����� �ɰŴ�.. ������ �� �غ���.", "Player_none", () => Show_NextButton()));

                    DialogManager.Show(dialogTexts);
                }
            }
            else if (DialogSystem.instance.Result == 2 || DialogSystem.instance.Result == 3)
            {
                if (DialogSystem.instance.Rang == 0)
                {
                    var dialogTexts = new List<DialogData>();

                    dialogTexts.Add(new DialogData("..What are you doing? You just pressed it, right?\r\nNow, when the customer order perfume, you have to cater to customers' needs.", "������"));

                    dialogTexts.Add(new DialogData("To do that, we need to be able to find clues in your order, right?\r\nLet's take a good look at the order I just made.", "������"));

                    dialogTexts.Add(new DialogData("\"At first, I hope it's romantic,\" what's the closest ingredient we have in this spell?", "������", () => Show_RoseE()));

                    dialogTexts.Add(new DialogData("As you can see, it's a rose. You should be able to understand your intentions as well as you are now. Try your best!", "������", () => Hide_RoseE()));

                    dialogTexts.Add(new DialogData("/sound:Door/What a hectic day..", "Player_none"));

                    dialogTexts.Add(new DialogData("From tomorrow, I will make perfume in earnest. Let's cheer up and do well.", "Player_none", () => Show_NextButton()));

                    DialogManager.Show(dialogTexts);
                }
                else
                {
                    var dialogTexts = new List<DialogData>();

                    dialogTexts.Add(new DialogData("..���ϴ�? �� ������?\r\n��, �մ��� ����� �ֹ��� �� �� �մԵ��� ��� �������.", "������"));

                    dialogTexts.Add(new DialogData("�׷����� �մ��� �ֹ����� �ܼ��� �� ã�� �� �־�߰���?\r\n��� ���� �� �ֹ��� �� ���캸��.", "������"));

                    dialogTexts.Add(new DialogData("\"ó������ �θ�ƽ���� ���������� ���ڰ��,\" �� �ֹ����� �츮�� �����ִ� ��� �߿� ���� ������ ��ᰡ ����?", "������", () => Show_RoseK()));

                    dialogTexts.Add(new DialogData("���ٽ��� ����� �� �� �� �����ž�. ����ó�� �մ��� �ǵ��� �� �ľ��� �� �־����. �� �غ����� ��!", "������", () => Hide_RoseK()));

                    dialogTexts.Add(new DialogData("/sound:Door/���ž��� �Ϸ翴��..", "Player_none"));

                    dialogTexts.Add(new DialogData("���Ϻ��� ���������� ����� ����� �ɰŴ�.. ������ �� �غ���.", "Player_none", () => Show_NextButton()));

                    DialogManager.Show(dialogTexts);
                }
            }
        }
        else
        {
            gameObject.SetActive(false);
        }
    }

    private void Show_NextButton()
    {
        NextButton.SetActive(true);
    }
    private void Show_RoseE()
    {
        RoseE.SetActive(true);
    }

    private void Hide_RoseE()
    {
        RoseE.SetActive(false);
    }

    private void Show_RoseK()
    {
        RoseK.SetActive(true);
    }

    private void Hide_RoseK()
    {
        RoseK.SetActive(false);
    }
}
