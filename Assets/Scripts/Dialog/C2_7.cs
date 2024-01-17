using Doublsb.Dialog;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEditor.Rendering;
using UnityEngine;

public class C2_7 : MonoBehaviour
{
    public DialogManager DialogManager;

    public GameObject Tommy;

    public GameObject Button;

    public GameObject Printer;

    private void OnEnable()
    {
        if (DialogSystem.instance.day == 6)
        {
            gameObject.SetActive(true);

            Invoke("Show_C", 3f);
        }
        else
        {
            gameObject.SetActive(false);
        }
    }

    public void Show_C()
    {
        Tommy.SetActive(true);

        Tommy.GetComponent<AudioSource>().Play();

        Start5day();
    }

    public void Start5day()
    {
        if (DialogSystem.instance.Rang == 0)
        {
            var dialogTexts = new List<DialogData>();

            dialogTexts.Add(new DialogData("/sound:Door/Bonjour! This is the place that makes perfumes, right??", "토미"));

            dialogTexts.Add(new DialogData("/emote:Great/Oui, bonjour, sir. we are Mystique Parfume, the store that makes perfumes.", "Player_T"));

            dialogTexts.Add(new DialogData("/emote:Perfect/Wow! It smells good in here! Awesome!!!!", "토미"));

            dialogTexts.Add(new DialogData("You Know What? Aroma therapy using aroma oil is popular among friends these days! \nBut I'm a trendsetter!", "토미"));

            dialogTexts.Add(new DialogData("I'm going to go beyond oil and fashion perfume like a grown-up! My first perfume... I'm going to give it to my grandmother.", "토미"));

            dialogTexts.Add(new DialogData("/emote:Great/That's very thoughtful of you.", "Player_T"));

            dialogTexts.Add(new DialogData("My grandmother recently got burned while making carrot soup for me. If there are ingredients that are good for burns, please add them generously, generously!!", "토미"));

            dialogTexts.Add(new DialogData("Oh! And my grandmother is very worried because she's been losing a lot of hair lately. It would be great if you could add a scent that helps with hair care enough!", "토미"));

            dialogTexts.Add(new DialogData("And finally, please give it a soft woody fragrance as a finishing touch! Because she likes woody smell.", "토미"));

            dialogTexts.Add(new DialogData("But I don't like it when it smells too much like wood from my grandmother.. It's like a dead person.. So please add just a tiny bit, just a tiny bit!/emote:Great/", "토미", () => Show_Button()));

            DialogManager.Show(dialogTexts);
        }
        else
        {
            var dialogTexts = new List<DialogData>();

            dialogTexts.Add(new DialogData("/sound:Door/안녕하세요! 여기 향수 만들어주는데 맞죠??", "토미"));

            dialogTexts.Add(new DialogData("/emote:Great/네, 어서오세요, 손님. \n향수를 만들어주는 가게, 미스틱 파퓸입니다.", "Player_T"));

            dialogTexts.Add(new DialogData("/emote:Perfect/우와!! 향기 좋다아!! 대박!!!!", "토미"));

            dialogTexts.Add(new DialogData("그거 아세요?? 요즘 친구들 사이에서 아로마 오일을 이용하는 아로마 테라피가 유행이에요! \n하지만 전 유행을 선도하는 사람이죠!", "토미"));

            dialogTexts.Add(new DialogData("저는 오일을 넘어서서 어른스럽게 향수를 유행시킬거에요! 제 첫 향수는.. 할머니께 드릴거에요.", "토미"));

            dialogTexts.Add(new DialogData("/emote:Great/사려깊으시네요.", "Player_T"));

            dialogTexts.Add(new DialogData("최근에 할머니가 저를 위한 당근 스프를 만드시다가 화상을 입으셨어요.. 화상에 좋은 재료가 있으면 팍팍 넣어주세요, 팍팍!!", "토미"));

            dialogTexts.Add(new DialogData("아! 그리고 할머니가 요즘 머리카락이 많이 빠지셔서 걱정이 많으신데 머리를 관리해주는 향도 적당히 넣으면 좋겠어요!", "토미"));

            dialogTexts.Add(new DialogData("그리고 마무리로는 부드러운 나무 향기가 나게 해주세요! 할머니가 나무 향을 좋아하세요.", "토미"));

            dialogTexts.Add(new DialogData("근데 전 할머니한테서 나무향기가 나는게 싫어요.. 죽은 사람 같잖아요.. 그러니 완전 쪼끔만 넣어주세요, 쪼끔만!!/emote:Great/", "토미", () => Show_Button()));

            DialogManager.Show(dialogTexts);
        }
    }

    public void click()
    {
        if (Printer.activeSelf == false)
        {
            if (DialogSystem.instance.Rang == 0)
            {
                var dialogTexts = new List<DialogData>();

                dialogTexts.Add(new DialogData("I hope it comes out soon... hehe/emote:Great/", "토미"));

                DialogManager.Show(dialogTexts);
            }
            else
            {
                var dialogTexts = new List<DialogData>();

                dialogTexts.Add(new DialogData("빨리 나왔으면 좋겠다.. 헤헤/emote:Great/", "토미"));

                DialogManager.Show(dialogTexts);
            }
        }
    }

    void Show_Button()
    {
        Button.SetActive(true);
    }
}
