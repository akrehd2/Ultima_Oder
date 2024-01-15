using Doublsb.Dialog;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;

public class C2_10 : MonoBehaviour
{
    public DialogManager DialogManager;

    public GameObject Button;

    private void OnEnable()
    {
        if (DialogSystem.instance.day == 9)
        {
            gameObject.SetActive(true);

            if (DialogSystem.instance.Result == 0)
            {
                if (DialogSystem.instance.Rang == 0)
                {
                    var dialogTexts = new List<DialogData>();

                    dialogTexts.Add(new DialogData("/emote:Perfect/SSSP HAH.. What a perfect perfume.. Thank you..", "�׿�"));

                    dialogTexts.Add(new DialogData("/sound:Door/I'm glad you like it! Come again!", "Player_none", () => Show_Button()));

                    DialogManager.Show(dialogTexts);
                }
                else
                {
                    var dialogTexts = new List<DialogData>();

                    dialogTexts.Add(new DialogData("/emote:Perfect/���� ��.. �̷��� ���� ����.. �����մϴ�..", "�׿�"));

                    dialogTexts.Add(new DialogData("/sound:Door/������ ��Ŵٴ� �����̳׿�! �� ������!", "Player_none", () => Show_Button()));

                    DialogManager.Show(dialogTexts);
                }
            }
            else if (DialogSystem.instance.Result == 1)
            {
                if (DialogSystem.instance.Rang == 0)
                {
                    var dialogTexts = new List<DialogData>();

                    dialogTexts.Add(new DialogData("/size:down/Hmm... What is this smell..?", "�׿�"));

                    dialogTexts.Add(new DialogData("Haha.. I'm sorry that I couldn't fully meet your needs.", "Player_R"));

                    dialogTexts.Add(new DialogData("/size:down/Oh, well... no... just a little... I'm sorry to hear that..", "�׿�"));

                    dialogTexts.Add(new DialogData("/sound:Door/Yes, come again, please.", "Player_none", () => Show_Button()));

                    DialogManager.Show(dialogTexts);
                }
                else
                {
                    var dialogTexts = new List<DialogData>();

                    dialogTexts.Add(new DialogData("/size:down/����.. �̰� ���� ������..?", "�׿�"));

                    dialogTexts.Add(new DialogData("����.. �մ� �䱸�� �Ϻ��� �������ѵ帮�� ���� �˼��մϴ�.", "Player_R"));

                    dialogTexts.Add(new DialogData("/size:down/��.. ��.. �ƴմϴ�.. �ٸ� ����.. �ƽ��׿�..", "�׿�"));

                    dialogTexts.Add(new DialogData("/sound:Door/��, �� ������.", "Player_none", () => Show_Button()));

                    DialogManager.Show(dialogTexts);
                }
            }
            else if (DialogSystem.instance.Result == 2 || DialogSystem.instance.Result == 3)
            {
                if (DialogSystem.instance.Rang == 0)
                {
                    var dialogTexts = new List<DialogData>();

                    dialogTexts.Add(new DialogData("This is... /wate:0.5//emote:Sad//size:up/Not the scent /size:up//sound:wodang//speed:0.01/I thought of !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!", "�׿�"));

                    dialogTexts.Add(new DialogData("/sound:Door//size:up/?!?!?? Please calm down!! I'm sorry!! I'll repay you with a better perfume next timeeee!!!!!!!!!", "Player_none", () => Show_Button()));

                    DialogManager.Show(dialogTexts);
                }
                else
                {
                    var dialogTexts = new List<DialogData>();

                    dialogTexts.Add(new DialogData("�̰�.. /wate:0.5//emote:Sad//size:up/���� �����ߴ� ���� /size:up//sound:wodang//speed:0.01/�ƴϾ߾ƾƾƾƾƾ�!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!", "�׿�"));

                    dialogTexts.Add(new DialogData("/sound:Door//size:up/?!?!?? �մ� �����ϼ���!! ���� �˼��ؿ�!! �������� �� ���� ����� �����ϰڽ��ϴپƾ�!!!", "Player_none", () => Show_Button()));

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
