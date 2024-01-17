using Doublsb.Dialog;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;

public class C2_10 : MonoBehaviour
{
    public DialogManager DialogManager;

    public GameObject Button;

    public GameObject perfect;

    public GameObject hmm;

    public Animator TEO; 

    private void OnEnable()
    {
        if (DialogSystem.instance.day == 9)
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

                    dialogTexts.Add(new DialogData("/sound:Perfect2//emote:Perfect/SSSP HAH.. What a perfect perfume.. Thank you..", "테오"));

                    dialogTexts.Add(new DialogData("/sound:Door/I'm glad you like it! Come again!", "Player_none", () => Show_Button()));

                    DialogManager.Show(dialogTexts);
                }
                else
                {
                    var dialogTexts = new List<DialogData>();

                    dialogTexts.Add(new DialogData("/sound:Perfect2//emote:Perfect/쓰읍 하.. 이렇게 좋을 수가.. 감사합니다..", "테오"));

                    dialogTexts.Add(new DialogData("/sound:Door/마음에 드신다니 다행이네요! 또 오세요!", "Player_none", () => Show_Button()));

                    DialogManager.Show(dialogTexts);
                }
            }
            else if (DialogSystem.instance.Result == 1)
            {
                if (DialogSystem.instance.Rang == 0)
                {
                    var dialogTexts = new List<DialogData>();

                    dialogTexts.Add(new DialogData("/sound:Great2//size:down/Hmm... What is this smell..?", "테오"));

                    dialogTexts.Add(new DialogData("Haha.. I'm sorry that I couldn't fully meet your needs.", "Player_R"));

                    dialogTexts.Add(new DialogData("/size:down/Oh, well... no... just a little... I'm sorry to hear that..", "테오"));

                    dialogTexts.Add(new DialogData("/sound:Door/Yes, come again, please.", "Player_none", () => Show_Button()));

                    DialogManager.Show(dialogTexts);
                }
                else
                {
                    var dialogTexts = new List<DialogData>();

                    dialogTexts.Add(new DialogData("/sound:Great2//size:down/흐음.. 이게 무슨 냄새지..?", "테오"));

                    dialogTexts.Add(new DialogData("하하.. 손님 요구를 완벽히 충족시켜드리지 못해 죄송합니다.", "Player_R"));

                    dialogTexts.Add(new DialogData("/size:down/아.. 뭐.. 아닙니다.. 다만 조금.. 아쉽네요..", "테오"));

                    dialogTexts.Add(new DialogData("/sound:Door/네, 또 오세요.", "Player_none", () => Show_Button()));

                    DialogManager.Show(dialogTexts);
                }
            }
            else if (DialogSystem.instance.Result == 2 || DialogSystem.instance.Result == 3)
            {
                Invoke("Shack", 2f);

                if (DialogSystem.instance.Rang == 0)
                {
                    var dialogTexts = new List<DialogData>();

                    dialogTexts.Add(new DialogData("/sound:woo/This is... /wait:1.3//size:up/Not the scent /emote:Sad//size:up//speed:0.01/I thought of /sound:wodang/!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!", "테오"));

                    dialogTexts.Add(new DialogData("/sound:Door//size:up/?!?!?? Please calm down!! I'm sorry!! I'll repay you with a better perfume next timeeee!!!!!!!!!", "Player_none", () => Show_Button()));

                    DialogManager.Show(dialogTexts);
                }
                else
                {
                    var dialogTexts = new List<DialogData>();

                    dialogTexts.Add(new DialogData("/sound:woo/이건.. /wait:1.3//size:up/내가 생각했던 향이 /emote:Sad//size:up//speed:0.01/아니야아아아아아악/sound:wodang/!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!", "테오"));

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

    void Shack()
    {
        Zoom.instance.ShakP = 2f;
        Zoom.instance.Shaking = true;
        hmm.SetActive(true);
        TEO.SetBool("Up", true);
    }

    void Show_Button()
    {
        Button.SetActive(true);
        perfect.SetActive(false);
        hmm.SetActive(false);

        TEO.SetBool("Up", false);
    }
}
