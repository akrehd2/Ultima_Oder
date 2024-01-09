using Doublsb.Dialog;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;

public class C2_4 : MonoBehaviour
{
    public DialogManager DialogManager;

    public GameObject Button;

    private void OnEnable()
    {
        if (DialogSystem.instance.day == 3)
        {
            gameObject.SetActive(true);

            if (DialogSystem.instance.Result == 0)
            {
                if (DialogSystem.instance.Rang == 0)
                {
                    var dialogTexts = new List<DialogData>();

                    dialogTexts.Add(new DialogData("/emote:Perfect//size:up/This is it! This is it!", "��"));

                    dialogTexts.Add(new DialogData("Do you like it, ma,am?", "Player_A"));

                    dialogTexts.Add(new DialogData("/emote:Perfect//size:up/Of course I do!", "��"));

                    dialogTexts.Add(new DialogData("/emote:Perfect//speed:0.06/I'll definitely come back!", "��"));

                    dialogTexts.Add(new DialogData("/sound:Door/Thank you ma'am, come again next time!", "Player_none", () => Show_Button()));

                    DialogManager.Show(dialogTexts);
                }
                else
                {
                    var dialogTexts = new List<DialogData>();

                    dialogTexts.Add(new DialogData("/emote:Perfect//size:up/�ٷ� �̰ſ���, �̰�!", "��"));

                    dialogTexts.Add(new DialogData("������ ��ó���?", "Player_A"));

                    dialogTexts.Add(new DialogData("/emote:Perfect//size:up/��ٸ���!", "��"));

                    dialogTexts.Add(new DialogData("/emote:Perfect//speed:0.06/�� �� �ٽ� ������!", "��"));

                    dialogTexts.Add(new DialogData("/sound:Door/�����մϴ�! �� ������!", "Player_none", () => Show_Button()));

                    DialogManager.Show(dialogTexts);
                }
            }
            else if (DialogSystem.instance.Result == 1)
            {
                if (DialogSystem.instance.Rang == 0)
                {
                    var dialogTexts = new List<DialogData>();

                    dialogTexts.Add(new DialogData("/emote:Great//speed:0.06/Um~ It's good.", "��"));

                    dialogTexts.Add(new DialogData("Do you like it, ma,am?", "Player_A"));

                    dialogTexts.Add(new DialogData("/emote:Great//speed:0.06/I can feel your sincerity, thank you.", "��"));

                    dialogTexts.Add(new DialogData("/sound:Door/Thank you ma'am! Good bye.", "Player_none", () => Show_Button()));

                    DialogManager.Show(dialogTexts);
                }
                else
                {
                    var dialogTexts = new List<DialogData>();

                    dialogTexts.Add(new DialogData("/emote:Great//speed:0.06/��~ ���ƿ�.", "��"));

                    dialogTexts.Add(new DialogData("������ ��ó���?", "Player_A"));

                    dialogTexts.Add(new DialogData("/emote:Great//speed:0.06/������ �������׿�. �����ϴ�.", "��"));

                    dialogTexts.Add(new DialogData("/sound:Door/�����մϴ�! �ȳ��� ������.", "Player_none", () => Show_Button()));

                    DialogManager.Show(dialogTexts);
                }
            }
            else if (DialogSystem.instance.Result == 2)
            {
                if (DialogSystem.instance.Rang == 0)
                {
                    var dialogTexts = new List<DialogData>();

                    dialogTexts.Add(new DialogData("/emote:Sad//speed:0.06/I don't think I can fix my grandson's picky eating with this..", "��"));

                    dialogTexts.Add(new DialogData("I don't think I understood the order well. I'm sorry.", "Player_A"));

                    dialogTexts.Add(new DialogData("/speed:0.06/No, you don't have to be sorry.", "��"));

                    dialogTexts.Add(new DialogData("/speed:0.06/Anyway, I had a good experience.", "��"));

                    dialogTexts.Add(new DialogData("/sound:Door/Goodbye, ma,am.", "Player_none", () => Show_Button()));

                    DialogManager.Show(dialogTexts);
                }
                else
                {
                    var dialogTexts = new List<DialogData>();

                    dialogTexts.Add(new DialogData("/emote:Sad//speed:0.06/�̰ɷ� ���� ��� ��ġ�� ���� �� ���׿�..", "��"));

                    dialogTexts.Add(new DialogData("���� �ֹ� ���ظ� �� ���� �� ���׿�. �˼��մϴ�.", "Player_A"));

                    dialogTexts.Add(new DialogData("/speed:0.06/�ƴϿ���. �˼��� �� ������.", "��"));

                    dialogTexts.Add(new DialogData("/speed:0.06/��·�� ���� ���� �߼���.", "��"));

                    dialogTexts.Add(new DialogData("/sound:Door/�ȳ��� ������.", "Player_none", () => Show_Button()));

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
