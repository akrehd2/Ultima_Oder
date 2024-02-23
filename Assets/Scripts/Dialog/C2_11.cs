using Doublsb.Dialog;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEditor.Rendering;
using UnityEngine;

public class C2_11 : MonoBehaviour
{
    public DialogManager DialogManager;

    public GameObject Cleo;

    public GameObject Ending;

    public GameObject Button;

    public GameObject[] Charic;

    public GameObject perfect;

    public GameObject hmm;

    private void OnEnable()
    {
        if (DialogSystem.instance.day == 10)
        {
            gameObject.SetActive(true);

            Cleo.SetActive(true);

            Invoke("StartEnd", 3f);
        }
        else
        {
            gameObject.SetActive(false);
        }
    }

    public void StartEnd()
    {
        if (DialogSystem.instance.Rang == 0)
        {
            var dialogTexts = new List<DialogData>();

            dialogTexts.Add(new DialogData("/speed:0.1/...", "End"));

            dialogTexts.Add(new DialogData("It's already been six days since you worked here.", "End"));

            dialogTexts.Add(new DialogData("/emote:Perfect/How was your week here? Did you get used to work?", "End"));

            dialogTexts.Add(new DialogData("/emote:Perfect/You must have experienced guests of various personalities,", "End"));

            dialogTexts.Add(new DialogData("/emote:Perfect/There must have been some unusual people among them.", "End"));

            dialogTexts.Add(new DialogData("Of course, there must have been some annoying things, right?", "End"));

            dialogTexts.Add(new DialogData("/emote:Perfect/But don't hate them too much. \nIt's our perfume store's job to embrace those people.", "End"));

            dialogTexts.Add(new DialogData("/emote:Perfect/Just as people hate someone for no reason, we love someone for no reason.", "End"));

            dialogTexts.Add(new DialogData("/emote:Perfect/If we give them a place to rest one by one, they'll try harder.", "End"));

            dialogTexts.Add(new DialogData("Anyway, today I'm going to make sure you have enough competence in the perfumer. \nI'll see if I can appoint you as a full-time employee and leave you with more work.", "End"));

            dialogTexts.Add(new DialogData("First of all, what are the scores so far?", "End", () => Show_EndScore()));

            DialogManager.Show(dialogTexts);
        }
        else
        {
            var dialogTexts = new List<DialogData>();

            dialogTexts.Add(new DialogData("/speed:0.1/...", "End"));

            dialogTexts.Add(new DialogData("���� �װ� ���⼭ ������ 6��°��.", "End"));

            dialogTexts.Add(new DialogData("/emote:Perfect/���? �̰������� �� �ְ���? ���� ����� �ͼ�������?", "End"));

            dialogTexts.Add(new DialogData("/emote:Perfect/�������� ������ �մԵ��� �޾����װ�,", "End"));

            dialogTexts.Add(new DialogData("/emote:Perfect/�� �߿��� Ư���� �е鵵 �־�����.", "End"));

            dialogTexts.Add(new DialogData("���� ¥������ �ϵ� �־����ž�, ��ġ?", "End"));

            dialogTexts.Add(new DialogData("/emote:Perfect/�׷����� �ʹ� �̿������� ��. \n�׷��е鵵 ǰ���ִ°� �츮 ��������� ���̴ϱ�.", "End"));

            dialogTexts.Add(new DialogData("/emote:Perfect/������� �������� �������� �̿��ϵ���, �츰 �������� ����غ��°ž�.", "End"));

            dialogTexts.Add(new DialogData("/emote:Perfect/�� �� �� �� ��� �� �ִ� �Ƚ�ó�� �Ǿ��ָ�, �׺е鵵 �� ������״ϱ�.", "End"));

            dialogTexts.Add(new DialogData("�ƹ�ư ������ �װ� ����翡 ���� ����� ������ ���� �ִ��� üũ �Ұž�. \n�ʸ� ���������� �Ӹ��ؼ� �װ� �� ���� ���� �ðܵ� ���� ���°���.", "End"));

            dialogTexts.Add(new DialogData("�ϴ� ���ݱ����� ������?", "End", () => Show_EndScore()));

            DialogManager.Show(dialogTexts);
        }
    }

    void Show_EndScore()
    {
        Invoke("Show_button", 0.1f);

        int s = 0;

        for (int i = 0; i < DialogSystem.instance.MadePf.Length; i++)
        {
            if(DialogSystem.instance.MadePf[i] == true)
            {
                s++;
            }
        }

        if(s >= 5)
        {
            Zoom.instance.ShakP = 1f;
            Zoom.instance.Shaking = true;
            perfect.SetActive(true);

            if (DialogSystem.instance.Rang == 0)
            {
                var dialogTexts = new List<DialogData>();

                dialogTexts.Add(new DialogData("/emote:Perfect//size:up/Perfect score! /size:init/You did a good job! I didn't teach you much, but I'm very proud. You can start working as a full-time employee tomorrow!", "End", () => Show_button()));

                DialogManager.Show(dialogTexts);
            }
            else
            {
                var dialogTexts = new List<DialogData>();

                dialogTexts.Add(new DialogData("/emote:Perfect//size:up/�����̳�! /size:init/�����ᱸ��! ���� �������� �͵� ���µ� ������ �ѵ��ϳ�. ���Ϻ��� �ٷ� ���������� ���ص� �ǰھ�!", "End", () => Show_button()));

                DialogManager.Show(dialogTexts);
            }
        }
        else if(s >= 3) 
        {
            if (DialogSystem.instance.Rang == 0)
            {
                var dialogTexts = new List<DialogData>();

                dialogTexts.Add(new DialogData("It's more than half, If you work a little more, \nyour skills will improve, right? \nI'll keep an eye on you a little longer, so try your best.", "End", () => Show_button()));

                DialogManager.Show(dialogTexts);
            }
            else
            {
                var dialogTexts = new List<DialogData>();

                dialogTexts.Add(new DialogData("������ �Ѿ���, ���ݸ� �� ���ϸ� �Ƿ��� �ðڴµ�? \n���� �� ���Ѻ��״ϱ� ������ �غ�.", "End", () => Show_button()));

                DialogManager.Show(dialogTexts);
            }
        }
        else
        {
            Zoom.instance.ShakP = 1f;
            Zoom.instance.Shaking = true;
            hmm.SetActive(true);

            if (DialogSystem.instance.Rang == 0)
            {
                var dialogTexts = new List<DialogData>();

                dialogTexts.Add(new DialogData("I can't believe it's less than half... You should work harder. \nThere will be another opportunity to hire full-time employees someday, so work hard until then.", "End", () => Show_button()));

                DialogManager.Show(dialogTexts);
            }
            else
            {
                var dialogTexts = new List<DialogData>();

                dialogTexts.Add(new DialogData("���ݵ� ���Ѵٴ�... �� ������ �ؾ߰ڱ���. \n������ ������ ä�� ��ȸ�� �� �����״� �׶����� ������ ���غ���.", "End", () => Show_button()));

                DialogManager.Show(dialogTexts);
            }
        }
    }

    public void Show_button()
    {
        Button.SetActive(true);
    }

        public void ShowEnding()
    {
        god.instance.Ending = true;

        Ending.SetActive(true);

        for (int i = 0; i < DialogSystem.instance.MadePf.Length - 1; i++)
        {
            if (DialogSystem.instance.MadePf[i] == true)
            {
                Charic[i].SetActive(true);
            }
        }

        Invoke("Fal", 2f);
    }

    void Fal()
    {
        perfect.SetActive(false);
        hmm.SetActive(false);
    }
}
