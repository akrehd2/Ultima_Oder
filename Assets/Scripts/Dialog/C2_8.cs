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

                    dialogTexts.Add(new DialogData("/emote:Perfect//size:up/Oh my god!!! It's the best!!! It's the best!!!! \nMy grandmother will like it!", "토미"));

                    dialogTexts.Add(new DialogData("/emote:Perfect/I'm glad you liked it. :) Please come again next time!", "Player_T"));

                    dialogTexts.Add(new DialogData("/emote:Perfect/Good bye!! See ya!", "토미"));

                    dialogTexts.Add(new DialogData("/sound:Door/Good bye.", "Player_none", () => Show_Button()));

                    DialogManager.Show(dialogTexts);
                }
                else
                {
                    var dialogTexts = new List<DialogData>();

                    dialogTexts.Add(new DialogData("/emote:Perfect//size:up/우와아!!! 짱이에요 형!!!!! \n할머니가 좋아하시겠당! 헤헤헤", "토미"));

                    dialogTexts.Add(new DialogData("/emote:Perfect/마음에 들어보여서 다행이네요.^^ 다음에 또 오세요!", "Player_T"));

                    dialogTexts.Add(new DialogData("/emote:Perfect/다음에 또 올게요!! 안녕히 계세요!", "토미"));

                    dialogTexts.Add(new DialogData("/sound:Door/조심히 가세요!", "Player_none", () => Show_Button()));

                    DialogManager.Show(dialogTexts);
                }
            }
            else if (DialogSystem.instance.Result == 1)
            {
                if (DialogSystem.instance.Rang == 0)
                {
                    var dialogTexts = new List<DialogData>();

                    dialogTexts.Add(new DialogData("/emote:Great/Hmm… It's a scent that my grandmother might like. Thank you!", "토미"));

                    dialogTexts.Add(new DialogData("/sound:Door/Have a nice day!", "Player_none", () => Show_Button()));

                    DialogManager.Show(dialogTexts);
                }
                else
                {
                    var dialogTexts = new List<DialogData>();

                    dialogTexts.Add(new DialogData("/emote:Great/음… 할머니가 좋아하실 수도 있는 향이네요. 감사합니다!", "토미"));

                    dialogTexts.Add(new DialogData("/sound:Door/좋은 하루 되세요!", "Player_none", () => Show_Button()));

                    DialogManager.Show(dialogTexts);
                }
            }
            else if (DialogSystem.instance.Result == 2 || DialogSystem.instance.Result == 3)
            {
                if (DialogSystem.instance.Rang == 0)
                {
                    var dialogTexts = new List<DialogData>();

                    dialogTexts.Add(new DialogData("/emote:Sad/What is this? It smells weird!! I hate it!!!!/sound:wodang/ Aargh!!!!!!!!", "토미"));

                    dialogTexts.Add(new DialogData("/sound:Door/Oh, my God. Calm down, kid!!", "Player_none", () => Show_Button()));

                    DialogManager.Show(dialogTexts);
                }
                else
                {
                    var dialogTexts = new List<DialogData>();

                    dialogTexts.Add(new DialogData("/emote:Sad/아이.. 이게 뭐에요..! 이상한 냄새나!! 싫어!!!!/sound:wodang/ 으아악!!!!!!!!", "토미"));

                    dialogTexts.Add(new DialogData("/sound:Door/아이고, 세상에. 꼬마야, 진정해!!", "Player_none", () => Show_Button()));

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
