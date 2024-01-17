using Doublsb.Dialog;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;

public class C2_5 : MonoBehaviour
{
    public DialogManager DialogManager;

    public GameObject Olivia;

    public GameObject Button;

    public GameObject Printer;

    private void OnEnable()
    {
        if (DialogSystem.instance.day == 4)
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
        Olivia.SetActive(true);

        Olivia.GetComponent<AudioSource>().Play();
    }

    public void Start4day()
    {
        if (DialogSystem.instance.Rang == 0)
        {
            var dialogTexts = new List<DialogData>();

            dialogTexts.Add(new DialogData("Bonjour, this is Mystique Parfume.", "Player_O"));

            dialogTexts.Add(new DialogData("Hey, you know who I am, right?", "올리비아"));

            dialogTexts.Add(new DialogData("Yes?", "Player_O"));

            dialogTexts.Add(new DialogData("/emote:Sad/Don't you KNOW me? /wate:0.3/Are you ignoring me right now? ", "올리비아"));

            dialogTexts.Add(new DialogData("/emote:Sad//speed:0.1/Oh... /speed:0.04/no, sir. I'm so sorry.", "Player_O"));

            dialogTexts.Add(new DialogData("/emote:Sad//size:down/ha.. I wonder if you can make the perfume I want..", "올리비아"));

            dialogTexts.Add(new DialogData("/emote:Sad//size:init/Please tell me what you want and we will do our best to meet your expectations.", "Player_O"));

            dialogTexts.Add(new DialogData("/emote:Sad/Yes... well... then I'll give you one chance.", "올리비아"));

            dialogTexts.Add(new DialogData("/emote:Sad/Thank you for trusting me.", "Player_O"));

            dialogTexts.Add(new DialogData("Please make a perfume just like me. What color comes to mind when you see me? \nDoesn't the beautiful purple color come to mind? I think I've given you a lot of hints.", "올리비아"));

            dialogTexts.Add(new DialogData("Oh, that's right... I don't like anything else, I only like flowers. \nSo, I would love it if there was a hint of purple floral scent in the beginning.", "올리비아"));

            dialogTexts.Add(new DialogData("And as I smell the fragrance more, I would like to experience an indescribable feeling, like a contradictory scent... Include many contradictory a lot of scents that match my identity.", "올리비아"));

            dialogTexts.Add(new DialogData("Include many contradictory a lot of scents that match my identity.", "올리비아"));

            dialogTexts.Add(new DialogData("Lastly, I will give you a specific scent: lavender. Make it smell strongly of lavender. Can you do it well? I've helped you a lot, right?", "올리비아", () => Show_Button()));

            DialogManager.Show(dialogTexts);
        }
        else
        {
            var dialogTexts = new List<DialogData>();

            dialogTexts.Add(new DialogData("안녕하세요, 미스틱 파퓸입니다.", "Player_O"));

            dialogTexts.Add(new DialogData("이봐요, 나 누군지 알죠?", "올리비아"));

            dialogTexts.Add(new DialogData("네?", "Player_O"));

            dialogTexts.Add(new DialogData("/emote:Sad/저 모르세요? /wate:0.3/지금 무시하는 건가?", "올리비아"));

            dialogTexts.Add(new DialogData("/emote:Sad//speed:0.1/아... /speed:0.04/죄송합니다, 손님.", "Player_O"));

            dialogTexts.Add(new DialogData("/emote:Sad//size:down/하.. 이래서 내가 원하는 향수를 만들 수나 있으려나..", "올리비아"));

            dialogTexts.Add(new DialogData("/emote:Sad//size:init/원하시는 부분을 말씀해주시면 고객님의 기대에 부응할 수 있도록 최선을 다하겠습니다.", "Player_O"));

            dialogTexts.Add(new DialogData("/emote:Sad/네.. 뭐.. 그럼 한번만 기회를 드리죠.", "올리비아"));

            dialogTexts.Add(new DialogData("/emote:Sad/믿고 맡겨주셔서 감사합니다.", "Player_O"));

            dialogTexts.Add(new DialogData("딱 저 같은 향수를 만들어주세요. \n절 보면 무슨 색이 떠오르나요? \n아름다운 보라색이 떠오르지 않나요? 이정도면 힌트 많이 드린 것 같은데.", "올리비아"));

            dialogTexts.Add(new DialogData("아 맞다.. 전 다른건 싫고 오로지 꽃만 좋아해요. \n그러니까, 제일 처음에는 보라색 꽃 향기가 살짝 났으면 좋겠어요. \n그리고 향기를 맡을 수록 더 알 수 없는 느낌을 엄청 받으면 좋겠는데.", "올리비아"));

            dialogTexts.Add(new DialogData("마치 모순적인 향기.. \n제 정체성에 맞는 모순적인 향도 많이 내주세요.", "올리비아"));

            dialogTexts.Add(new DialogData("마지막으로 나는 향은 딱 정해드릴게요. 라벤더. 라벤더 향이 많이 나게 부탁해요. \n잘 할 수 있겠죠? 편의 많이 봐드린거에요 저?", "올리비아", () => Show_Button()));

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

                dialogTexts.Add(new DialogData("/emote:Sad/What are you doing standing in a daze? Go make it!", "올리비아"));

                DialogManager.Show(dialogTexts);
            }
            else
            {
                var dialogTexts = new List<DialogData>();

                dialogTexts.Add(new DialogData("/emote:Sad/멍하니 서서 뭐해요?! 어서 만들러가요!!", "올리비아"));

                DialogManager.Show(dialogTexts);
            }
        }
    }

    void Show_Button()
    {
        Button.SetActive(true);
    }
}
