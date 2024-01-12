using Doublsb.Dialog;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;

public class C2_6 : MonoBehaviour
{
    public DialogManager DialogManager;

    public GameObject Button;

    private void OnEnable()
    {
        if (DialogSystem.instance.day == 5)
        {
            gameObject.SetActive(true);

            if (DialogSystem.instance.Result == 0)
            {
                if (DialogSystem.instance.Rang == 0)
                {
                    var dialogTexts = new List<DialogData>();

                    dialogTexts.Add(new DialogData("/emote:Perfect//size:up/Oh my gosh!! It smells like me!", "�ø����"));

                    dialogTexts.Add(new DialogData("/emote:Perfect/I guess you liked it.", "Player_O"));

                    dialogTexts.Add(new DialogData("hmm,hmm... Well... it's better than I thought.\r\nWell then, I'm busy, so bye~", "�ø����"));

                    dialogTexts.Add(new DialogData("/sound:Door/Thank you. Please come again.", "Player_none", () => Show_Button()));

                    DialogManager.Show(dialogTexts);
                }
                else
                {
                    var dialogTexts = new List<DialogData>();

                    dialogTexts.Add(new DialogData("/emote:Perfect//size:up/����!! �� �� ���� �����ݾ�!", "�ø����"));

                    dialogTexts.Add(new DialogData("/emote:Perfect/������ ��̳����׿�.", "Player_O"));

                    dialogTexts.Add(new DialogData("��,��... ��... ��������... �����׿�.\r\n�׷� �ٺ��� �̸�, �ȳ�~", "�ø����"));

                    dialogTexts.Add(new DialogData("/sound:Door/�����մϴ�. �� ������.", "Player_none", () => Show_Button()));

                    DialogManager.Show(dialogTexts);
                }
            }
            else if (DialogSystem.instance.Result == 1)
            {
                if (DialogSystem.instance.Rang == 0)
                {
                    var dialogTexts = new List<DialogData>();

                    dialogTexts.Add(new DialogData("/emote:Great/��Ahh.", "�ø����"));

                    dialogTexts.Add(new DialogData("/emote:Great/Do you like it?", "Player_O"));

                    dialogTexts.Add(new DialogData("/emote:Great/Yeah.. well.. it's Soso. I don't think I'll have to come back here again.", "�ø����"));

                    dialogTexts.Add(new DialogData("(I should've done better..) I'm sorry to do it well.", "Player_O"));

                    dialogTexts.Add(new DialogData("It looks like you should try haaaaaaaarder~", "�ø����"));

                    dialogTexts.Add(new DialogData("/sound:Door/Good bye.", "Player_none", () => Show_Button()));

                    DialogManager.Show(dialogTexts);
                }
                else
                {
                    var dialogTexts = new List<DialogData>();

                    dialogTexts.Add(new DialogData("/emote:Great/����.", "�ø����"));

                    dialogTexts.Add(new DialogData("/emote:Great/������ ��ó���?", "Player_O"));

                    dialogTexts.Add(new DialogData("/emote:Great/��.. ��.. Soso�ϳ׿�. �ٽ� ���� �� ���� ���� �� ���׿�.", "�ø����"));

                    dialogTexts.Add(new DialogData("(�� �� �߾�� �ߴµ�..) �������ѵ帮�� �� �� �˼��մϴ�.", "Player_O"));

                    dialogTexts.Add(new DialogData("�� �� ����ϴ°� ���ƺ��̳׿�~", "�ø����"));

                    dialogTexts.Add(new DialogData("/sound:Door/�ȳ��� ������.", "Player_none", () => Show_Button()));

                    DialogManager.Show(dialogTexts);
                }
            }
            else if (DialogSystem.instance.Result == 2 || DialogSystem.instance.Result == 3)
            {
                if (DialogSystem.instance.Rang == 0)
                {
                    var dialogTexts = new List<DialogData>();

                    dialogTexts.Add(new DialogData("/emote:Sad/what.. What's this? I've taught you almost everything.. haa..", "�ø����"));

                    dialogTexts.Add(new DialogData("/emote:Sad/Sorry for that..", "Player_O"));

                    dialogTexts.Add(new DialogData("/emote:Sad/phew, I knew it would be like this.", "�ø����"));

                    dialogTexts.Add(new DialogData("/sound:Door/I ruined it..", "Player_none", () => Show_Button()));

                    DialogManager.Show(dialogTexts);
                }
                else
                {
                    var dialogTexts = new List<DialogData>();

                    dialogTexts.Add(new DialogData("/emote:Sad/��.. �̰� ����? ���� �� �����ĵ�ȴµ�.. �Ͼ�..", "�ø����"));

                    dialogTexts.Add(new DialogData("/emote:Sad/�˼��մϴ�..", "Player_O"));

                    dialogTexts.Add(new DialogData("/emote:Sad/��, �̷� �� �˾Ҿ�.", "�ø����"));

                    dialogTexts.Add(new DialogData("/sound:Door/���� �� ���Ĺ��ȳ�..", "Player_none", () => Show_Button()));

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
