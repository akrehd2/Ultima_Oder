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

                    dialogTexts.Add(new DialogData("/emote:Perfect//size:up/Oh my gosh!! It smells like me!", "올리비아"));

                    dialogTexts.Add(new DialogData("/emote:Perfect/I guess you liked it.", "Player_O"));

                    dialogTexts.Add(new DialogData("hmm,hmm... Well... it's better than I thought.\r\nWell then, I'm busy, so bye~", "올리비아"));

                    dialogTexts.Add(new DialogData("/sound:Door/Thank you. Please come again.", "Player_none", () => Show_Button()));

                    DialogManager.Show(dialogTexts);
                }
                else
                {
                    var dialogTexts = new List<DialogData>();

                    dialogTexts.Add(new DialogData("/emote:Perfect//size:up/세상에!! 딱 나 같은 향이잖아!", "올리비아"));

                    dialogTexts.Add(new DialogData("/emote:Perfect/마음에 드셨나보네요.", "Player_O"));

                    dialogTexts.Add(new DialogData("흠,흠... 뭐... 생각보단... 괜찮네요.\r\n그럼 바빠서 이만, 안녕~", "올리비아"));

                    dialogTexts.Add(new DialogData("/sound:Door/감사합니다. 또 오세요.", "Player_none", () => Show_Button()));

                    DialogManager.Show(dialogTexts);
                }
            }
            else if (DialogSystem.instance.Result == 1)
            {
                if (DialogSystem.instance.Rang == 0)
                {
                    var dialogTexts = new List<DialogData>();

                    dialogTexts.Add(new DialogData("/emote:Great/…Ahh.", "올리비아"));

                    dialogTexts.Add(new DialogData("/emote:Great/Do you like it?", "Player_O"));

                    dialogTexts.Add(new DialogData("/emote:Great/Yeah.. well.. it's Soso. I don't think I'll have to come back here again.", "올리비아"));

                    dialogTexts.Add(new DialogData("(I should've done better..) I'm sorry to do it well.", "Player_O"));

                    dialogTexts.Add(new DialogData("It looks like you should try haaaaaaaarder~", "올리비아"));

                    dialogTexts.Add(new DialogData("/sound:Door/Good bye.", "Player_none", () => Show_Button()));

                    DialogManager.Show(dialogTexts);
                }
                else
                {
                    var dialogTexts = new List<DialogData>();

                    dialogTexts.Add(new DialogData("/emote:Great/…아.", "올리비아"));

                    dialogTexts.Add(new DialogData("/emote:Great/마음에 드시나요?", "Player_O"));

                    dialogTexts.Add(new DialogData("/emote:Great/네.. 뭐.. Soso하네요. 다시 여기 올 일은 없을 것 같네요.", "올리비아"));

                    dialogTexts.Add(new DialogData("(더 잘 했어야 했는데..) 만족시켜드리지 못 해 죄송합니다.", "Player_O"));

                    dialogTexts.Add(new DialogData("좀 더 노력하는게 좋아보이네요~", "올리비아"));

                    dialogTexts.Add(new DialogData("/sound:Door/안녕히 가세요.", "Player_none", () => Show_Button()));

                    DialogManager.Show(dialogTexts);
                }
            }
            else if (DialogSystem.instance.Result == 2 || DialogSystem.instance.Result == 3)
            {
                if (DialogSystem.instance.Rang == 0)
                {
                    var dialogTexts = new List<DialogData>();

                    dialogTexts.Add(new DialogData("/emote:Sad/what.. What's this? I've taught you almost everything.. haa..", "올리비아"));

                    dialogTexts.Add(new DialogData("/emote:Sad/Sorry for that..", "Player_O"));

                    dialogTexts.Add(new DialogData("/emote:Sad/phew, I knew it would be like this.", "올리비아"));

                    dialogTexts.Add(new DialogData("/sound:Door/I ruined it..", "Player_none", () => Show_Button()));

                    DialogManager.Show(dialogTexts);
                }
                else
                {
                    var dialogTexts = new List<DialogData>();

                    dialogTexts.Add(new DialogData("/emote:Sad/이.. 이게 뭐죠? 거의 다 가르쳐드렸는데.. 하아..", "올리비아"));

                    dialogTexts.Add(new DialogData("/emote:Sad/죄송합니다..", "Player_O"));

                    dialogTexts.Add(new DialogData("/emote:Sad/흥, 이럴 줄 알았어.", "올리비아"));

                    dialogTexts.Add(new DialogData("/sound:Door/내가 다 망쳐버렸네..", "Player_none", () => Show_Button()));

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
