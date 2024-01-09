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

                    dialogTexts.Add(new DialogData("/emote:Perfect//size:up/This is it! This is it!", "앤"));

                    dialogTexts.Add(new DialogData("Do you like it, ma,am?", "Player_A"));

                    dialogTexts.Add(new DialogData("/emote:Perfect//size:up/Of course I do!", "앤"));

                    dialogTexts.Add(new DialogData("/emote:Perfect//speed:0.06/I'll definitely come back!", "앤"));

                    dialogTexts.Add(new DialogData("/sound:Door/Thank you ma'am, come again next time!", "Player_none", () => Show_Button()));

                    DialogManager.Show(dialogTexts);
                }
                else
                {
                    var dialogTexts = new List<DialogData>();

                    dialogTexts.Add(new DialogData("/emote:Perfect//size:up/바로 이거에요, 이거!", "앤"));

                    dialogTexts.Add(new DialogData("마음에 드시나요?", "Player_A"));

                    dialogTexts.Add(new DialogData("/emote:Perfect//size:up/들다마다!", "앤"));

                    dialogTexts.Add(new DialogData("/emote:Perfect//speed:0.06/내 꼭 다시 오리다!", "앤"));

                    dialogTexts.Add(new DialogData("/sound:Door/감사합니다! 또 오세요!", "Player_none", () => Show_Button()));

                    DialogManager.Show(dialogTexts);
                }
            }
            else if (DialogSystem.instance.Result == 1)
            {
                if (DialogSystem.instance.Rang == 0)
                {
                    var dialogTexts = new List<DialogData>();

                    dialogTexts.Add(new DialogData("/emote:Great//speed:0.06/Um~ It's good.", "앤"));

                    dialogTexts.Add(new DialogData("Do you like it, ma,am?", "Player_A"));

                    dialogTexts.Add(new DialogData("/emote:Great//speed:0.06/I can feel your sincerity, thank you.", "앤"));

                    dialogTexts.Add(new DialogData("/sound:Door/Thank you ma'am! Good bye.", "Player_none", () => Show_Button()));

                    DialogManager.Show(dialogTexts);
                }
                else
                {
                    var dialogTexts = new List<DialogData>();

                    dialogTexts.Add(new DialogData("/emote:Great//speed:0.06/음~ 좋아요.", "앤"));

                    dialogTexts.Add(new DialogData("마음에 드시나요?", "Player_A"));

                    dialogTexts.Add(new DialogData("/emote:Great//speed:0.06/정성이 느껴지네요. 고맙습니다.", "앤"));

                    dialogTexts.Add(new DialogData("/sound:Door/감사합니다! 안녕히 가세요.", "Player_none", () => Show_Button()));

                    DialogManager.Show(dialogTexts);
                }
            }
            else if (DialogSystem.instance.Result == 2)
            {
                if (DialogSystem.instance.Rang == 0)
                {
                    var dialogTexts = new List<DialogData>();

                    dialogTexts.Add(new DialogData("/emote:Sad//speed:0.06/I don't think I can fix my grandson's picky eating with this..", "앤"));

                    dialogTexts.Add(new DialogData("I don't think I understood the order well. I'm sorry.", "Player_A"));

                    dialogTexts.Add(new DialogData("/speed:0.06/No, you don't have to be sorry.", "앤"));

                    dialogTexts.Add(new DialogData("/speed:0.06/Anyway, I had a good experience.", "앤"));

                    dialogTexts.Add(new DialogData("/sound:Door/Goodbye, ma,am.", "Player_none", () => Show_Button()));

                    DialogManager.Show(dialogTexts);
                }
                else
                {
                    var dialogTexts = new List<DialogData>();

                    dialogTexts.Add(new DialogData("/emote:Sad//speed:0.06/이걸로 손주 편식 고치긴 힘들 것 같네요..", "앤"));

                    dialogTexts.Add(new DialogData("제가 주문 이해를 잘 못한 것 같네요. 죄송합니다.", "Player_A"));

                    dialogTexts.Add(new DialogData("/speed:0.06/아니에요. 죄송할 것 까지야.", "앤"));

                    dialogTexts.Add(new DialogData("/speed:0.06/어쨌든 좋은 경험 했수다.", "앤"));

                    dialogTexts.Add(new DialogData("/sound:Door/안녕히 가세요.", "Player_none", () => Show_Button()));

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
