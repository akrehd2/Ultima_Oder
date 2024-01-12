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

            dialogTexts.Add(new DialogData("Hello, this is Mystique Parfume.", "Player_O"));

            dialogTexts.Add(new DialogData("Hey, you know who I am, right?", "올리비아"));

            dialogTexts.Add(new DialogData("Yes?", "Player_O"));

            dialogTexts.Add(new DialogData("/emote:Sad/I Said Do YOU know me. /wate:0.3/Are you ignoring me right now? ", "올리비아"));

            dialogTexts.Add(new DialogData("/emote:Sad//speed:0.1/Oh... /speed:0.04/no, sir. I'm so sorry.", "Player_O"));

            dialogTexts.Add(new DialogData("/emote:Sad//size:down/ha.. I wonder if you can make the perfume I want..", "올리비아"));

            dialogTexts.Add(new DialogData("/emote:Sad//size:init/Please tell me what you want and we will do our best to meet your expectations.", "Player_O"));

            dialogTexts.Add(new DialogData("/emote:Sad/Yes... well... then I'll give you one chance.", "올리비아"));

            dialogTexts.Add(new DialogData("/emote:Sad/Thank you for trusting me.", "Player_O"));

            dialogTexts.Add(new DialogData("Please make a perfume just like me. What color comes to mind when you see me?\r\nDoesn't the beautiful purple color come to mind? I think I've given you a lot of hints.", "올리비아"));

            dialogTexts.Add(new DialogData("Oh, that's right... I don't like anything else, I only like flowers.\r\nSo, at first, I want it to smell like purple flowers.", "올리비아"));

            dialogTexts.Add(new DialogData("And I want that the more I smell the scent, the more mysterious I feel.", "올리비아"));

            dialogTexts.Add(new DialogData("A contradictory scent...\r\nLastly, I will tell you exactly what scent I like: Lavender, please.\r\nYou can do it well, right? I've helped you a lot, right?", "올리비아", () => Show_Button()));

            DialogManager.Show(dialogTexts);
        }
        else
        {
            var dialogTexts = new List<DialogData>();

            dialogTexts.Add(new DialogData("안녕하세요, 미스틱 파퓸입니다.", "Player_O"));

            dialogTexts.Add(new DialogData("이봐요, 나 누군지 알죠?", "올리비아"));

            dialogTexts.Add(new DialogData("네?", "Player_O"));

            dialogTexts.Add(new DialogData("/emote:Sad/저 아시냐구요, /wate:0.3/지금 무시하는 건가?", "올리비아"));

            dialogTexts.Add(new DialogData("/emote:Sad//speed:0.1/아... /speed:0.04/죄송합니다, 손님.", "Player_O"));

            dialogTexts.Add(new DialogData("/emote:Sad//size:down/하.. 이래서 내가 원하는 향수를 만들 수나 있으려나..", "올리비아"));

            dialogTexts.Add(new DialogData("/emote:Sad//size:init/원하시는 부분을 말씀해주시면 고객님의 기대에 부응할 수 있도록 최선을 다하겠습니다.", "Player_O"));

            dialogTexts.Add(new DialogData("/emote:Sad/네.. 뭐.. 그럼 한번만 기회를 드리죠.", "올리비아"));

            dialogTexts.Add(new DialogData("/emote:Sad/믿고 맡겨주셔서 감사합니다.", "Player_O"));

            dialogTexts.Add(new DialogData("딱 저 같은 향수 만들어주세요. \r\n절 보면 무슨 색이 떠오르나요? \r\n아름다운 보라색이 떠오르지 않나요? 이정도면 힌트 많이 드린 것 같은데.", "올리비아"));

            dialogTexts.Add(new DialogData("아 맞다.. 전 다른건 싫고 오로지 꽃만 좋아해요. \r\n그러니까, 제일 처음에는 보라색 꽃 향기가 났으면 좋겠어요.\r\n그리고 향기를 맡을 수록 더 알 수 없는 느낌을 받으면 좋겠는데.", "올리비아"));

            dialogTexts.Add(new DialogData("마치 모순적인 향기.. 마지막으로 나는 향은 딱 정해드릴게요. 라벤더. 부탁해요.\r\n잘 할 수 있겠죠? 편의 많이 봐드린거에요 저?", "올리비아", () => Show_Button()));

            DialogManager.Show(dialogTexts);
        }
    }

    void Show_Button()
    {
        Button.SetActive(true);
    }
}
