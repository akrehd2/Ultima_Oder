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

                    dialogTexts.Add(new DialogData("/emote:Perfect/SSSP HAH.. What a perfect perfume.. Thank you..", "테오"));

                    dialogTexts.Add(new DialogData("/sound:Door/I'm glad you like it! Come again!", "Player_none", () => Show_Button()));

                    DialogManager.Show(dialogTexts);
                }
                else
                {
                    var dialogTexts = new List<DialogData>();

                    dialogTexts.Add(new DialogData("/emote:Perfect/쓰읍 하.. 이렇게 좋을 수가.. 감사합니다..", "테오"));

                    dialogTexts.Add(new DialogData("/sound:Door/마음에 드신다니 다행이네요! 또 오세요!", "Player_none", () => Show_Button()));

                    DialogManager.Show(dialogTexts);
                }
            }
            else if (DialogSystem.instance.Result == 1)
            {
                if (DialogSystem.instance.Rang == 0)
                {
                    var dialogTexts = new List<DialogData>();

                    dialogTexts.Add(new DialogData("/size:down/Hmm... What is this smell..?", "테오"));

                    dialogTexts.Add(new DialogData("Haha.. I'm sorry that I couldn't fully meet your needs.", "Player_R"));

                    dialogTexts.Add(new DialogData("/size:down/Oh, well... no... just a little... I'm sorry to hear that..", "테오"));

                    dialogTexts.Add(new DialogData("/sound:Door/Yes, come again, please.", "Player_none", () => Show_Button()));

                    DialogManager.Show(dialogTexts);
                }
                else
                {
                    var dialogTexts = new List<DialogData>();

                    dialogTexts.Add(new DialogData("/size:down/흐음.. 이게 무슨 냄새지..?", "테오"));

                    dialogTexts.Add(new DialogData("하하.. 손님 요구를 완벽히 충족시켜드리지 못해 죄송합니다.", "Player_R"));

                    dialogTexts.Add(new DialogData("/size:down/아.. 뭐.. 아닙니다.. 다만 조금.. 아쉽네요..", "테오"));

                    dialogTexts.Add(new DialogData("/sound:Door/네, 또 오세요.", "Player_none", () => Show_Button()));

                    DialogManager.Show(dialogTexts);
                }
            }
            else if (DialogSystem.instance.Result == 2 || DialogSystem.instance.Result == 3)
            {
                if (DialogSystem.instance.Rang == 0)
                {
                    var dialogTexts = new List<DialogData>();

                    dialogTexts.Add(new DialogData("This is... /wate:0.5//emote:Sad//size:up/Not the scent /size:up//sound:wodang//speed:0.01/I thought of !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!", "테오"));

                    dialogTexts.Add(new DialogData("/sound:Door//size:up/?!?!?? Please calm down!! I'm sorry!! I'll repay you with a better perfume next timeeee!!!!!!!!!", "Player_none", () => Show_Button()));

                    DialogManager.Show(dialogTexts);
                }
                else
                {
                    var dialogTexts = new List<DialogData>();

                    dialogTexts.Add(new DialogData("이건.. /wate:0.5//emote:Sad//size:up/내가 생각했던 향이 /size:up//sound:wodang//speed:0.01/아니야아아아아아악!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!", "테오"));

                    dialogTexts.Add(new DialogData("/sound:Door//size:up/?!?!?? 손님 진정하세요!! 제가 죄송해요!! 다음번엔 더 좋은 향수로 보답하겠습니다아악!!!", "Player_none", () => Show_Button()));

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
