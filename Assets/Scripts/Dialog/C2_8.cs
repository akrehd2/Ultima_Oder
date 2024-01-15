using Doublsb.Dialog;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;

public class C2_8 : MonoBehaviour
{
    public DialogManager DialogManager;

    public GameObject Button;

    private void OnEnable()
    {
        if (DialogSystem.instance.day == 7)
        {
            gameObject.SetActive(true);

            if (DialogSystem.instance.Result == 0)
            {
                if (DialogSystem.instance.Rang == 0)
                {
                    var dialogTexts = new List<DialogData>();

                    dialogTexts.Add(new DialogData("/emote:Perfect//size:up/Oh my god!!! It's the best!!! It's the best!!!! \nMy grandmother will like it!", "���"));

                    dialogTexts.Add(new DialogData("/emote:Perfect/I'm glad you liked it. :) Please come again next time!", "Player_T"));

                    dialogTexts.Add(new DialogData("/emote:Perfect/Good bye!! See ya!", "���"));

                    dialogTexts.Add(new DialogData("/sound:Door/Good bye.", "Player_none", () => Show_Button()));

                    DialogManager.Show(dialogTexts);
                }
                else
                {
                    var dialogTexts = new List<DialogData>();

                    dialogTexts.Add(new DialogData("/emote:Perfect//size:up/��;�!!! ¯�̿��� ��!!!!! \n�ҸӴϰ� �����Ͻðڴ�! ������", "���"));

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

                    dialogTexts.Add(new DialogData("/emote:Great/Hmm�� It's a scent that my grandmother might like. Thank you!", "���"));

                    dialogTexts.Add(new DialogData("/sound:Door/Have a nice day!", "Player_none", () => Show_Button()));

                    DialogManager.Show(dialogTexts);
                }
                else
                {
                    var dialogTexts = new List<DialogData>();

                    dialogTexts.Add(new DialogData("/emote:Great/���� �ҸӴϰ� �����Ͻ� ���� �ִ� ���̳׿�. �����մϴ�!", "���"));

                    dialogTexts.Add(new DialogData("/sound:Door/���� �Ϸ� �Ǽ���!", "Player_none", () => Show_Button()));

                    DialogManager.Show(dialogTexts);
                }
            }
            else if (DialogSystem.instance.Result == 2 || DialogSystem.instance.Result == 3)
            {
                if (DialogSystem.instance.Rang == 0)
                {
                    var dialogTexts = new List<DialogData>();

                    dialogTexts.Add(new DialogData("/emote:Sad/What is this? It smells weird!! I hate it!!!!/sound:wodang/ Aargh!!!!!!!!", "���"));

                    dialogTexts.Add(new DialogData("/sound:Door/Oh, my God. Calm down, kid!!", "Player_none", () => Show_Button()));

                    DialogManager.Show(dialogTexts);
                }
                else
                {
                    var dialogTexts = new List<DialogData>();

                    dialogTexts.Add(new DialogData("/emote:Sad/����.. �̰� ������..! �̻��� ������!! �Ⱦ�!!!!/sound:wodang/ ���ƾ�!!!!!!!!", "���"));

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
    }
}
