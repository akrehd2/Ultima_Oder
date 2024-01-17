using Doublsb.Dialog;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;

public class C2_8 : MonoBehaviour
{
    public DialogManager DialogManager;

    public GameObject Button;

    public GameObject perfect;

    public GameObject hmm;

    public Animator Rui;

    private void OnEnable()
    {
        if (DialogSystem.instance.day == 7)
        {
            gameObject.SetActive(true);

            if (DialogSystem.instance.Result == 0)
            {
                Zoom.instance.ShakP = 1f;
                Zoom.instance.Shaking = true;
                perfect.SetActive(true);

                if (DialogSystem.instance.Rang == 0)
                {
                    var dialogTexts = new List<DialogData>();

                    dialogTexts.Add(new DialogData("/sound:Perfect2//emote:Perfect//size:up/Oh my god!!! It's the best!!! It's the best!!!! \nMy grandmother will like it!", "���"));

                    dialogTexts.Add(new DialogData("/emote:Perfect/I'm glad you liked it. :) Please come again next time!", "Player_T"));

                    dialogTexts.Add(new DialogData("/emote:Perfect/Good bye!! See ya!", "���"));

                    dialogTexts.Add(new DialogData("/sound:Door/Good bye.", "Player_none", () => Show_Button()));

                    DialogManager.Show(dialogTexts);
                }
                else
                {
                    var dialogTexts = new List<DialogData>();

                    dialogTexts.Add(new DialogData("/sound:Perfect2//emote:Perfect//size:up/��;�!!! ¯�̿��� ��!!!!! \n�ҸӴϰ� �����Ͻðڴ�! ������", "���"));

                    dialogTexts.Add(new DialogData("/emote:Perfect/������ ������ �����̳׿�.^^ ������ �� ������!", "Player_T"));

                    dialogTexts.Add(new DialogData("/emote:Perfect/������ �� �ðԿ�!! �ȳ��� �輼��!", "���"));

                    dialogTexts.Add(new DialogData("/sound:Door/������ ������!", "Player_none", () => Show_Button()));

                    DialogManager.Show(dialogTexts);
                }
            }
            else if (DialogSystem.instance.Result == 1)
            {
                if (DialogSystem.instance.Rang == 0)
                {
                    var dialogTexts = new List<DialogData>();

                    dialogTexts.Add(new DialogData("/sound:Great2//emote:Great/Hmm�� It's a scent that my grandmother might like. Thank you!", "���"));

                    dialogTexts.Add(new DialogData("/sound:Door/Have a nice day!", "Player_none", () => Show_Button()));

                    DialogManager.Show(dialogTexts);
                }
                else
                {
                    var dialogTexts = new List<DialogData>();

                    dialogTexts.Add(new DialogData("/sound:Great2//emote:Great/���� �ҸӴϰ� �����Ͻ� ���� �ִ� ���̳׿�. �����մϴ�!", "���"));

                    dialogTexts.Add(new DialogData("/sound:Door/���� �Ϸ� �Ǽ���!", "Player_none", () => Show_Button()));

                    DialogManager.Show(dialogTexts);
                }
            }
            else if (DialogSystem.instance.Result == 2 || DialogSystem.instance.Result == 3)
            {
                Zoom.instance.ShakP = 2f;
                Zoom.instance.Shaking = true;
                hmm.SetActive(true);
                Rui.SetBool("Up2", true);

                if (DialogSystem.instance.Rang == 0)
                {
                    var dialogTexts = new List<DialogData>();

                    dialogTexts.Add(new DialogData("/sound:woo//emote:Sad/Ugh.. What is this..! /wait:0.3/It smells weird!!/sound:wodang/ I hate it!!!! Aargh!!!!!!!!", "���"));

                    dialogTexts.Add(new DialogData("/sound:Door/Oh, my God. Calm down, kid!!", "Player_none", () => Show_Button()));

                    DialogManager.Show(dialogTexts);
                }
                else
                {
                    var dialogTexts = new List<DialogData>();

                    dialogTexts.Add(new DialogData("/sound:woo//emote:Sad/����.. �̰� ������..! /wait:0.3/�̻��� ������!!/sound:wodang/ �Ⱦ�!!!! ���ƾ�!!!!!!!!", "���"));

                    dialogTexts.Add(new DialogData("/sound:Door/���̰�, ����. ������, ������!!", "Player_none", () => Show_Button()));

                    DialogManager.Show(dialogTexts);
                }
            }
        }
        else
        {
            gameObject.SetActive(false);
        }
    }

    void Show_Button()
    {
        Button.SetActive(true);
        perfect.SetActive(false);
        hmm.SetActive(false);
        Rui.SetBool("Up2", false);
    }
}
