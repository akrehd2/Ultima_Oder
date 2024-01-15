using Doublsb.Dialog;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEditor.Rendering;
using UnityEngine;

public class C2_9 : MonoBehaviour
{
    public DialogManager DialogManager;

    public GameObject Teo;

    public GameObject Button;

    public GameObject Printer;

    private void OnEnable()
    {
        if (DialogSystem.instance.day == 8)
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
        Teo.SetActive(true);

        Teo.GetComponent<AudioSource>().Play();

        Invoke("Start6day", 1f);
    }

    public void Start6day()
    {
        if (DialogSystem.instance.Rang == 0)
        {
            var dialogTexts = new List<DialogData>();

            dialogTexts.Add(new DialogData("/size:down/Bon/size:down/jou/size:down/r..", "테오"));

            dialogTexts.Add(new DialogData("Bonjour! \nWe are Mystique Parfume, a perfume maker", "Player_R"));

            dialogTexts.Add(new DialogData("/size:down/I want to make/size:down/perfume.. /size:down/So...", "테오"));

            dialogTexts.Add(new DialogData("Yes, what perfume do you want?", "Player_R"));

            dialogTexts.Add(new DialogData("/size:down/Do I just.. /size:down/have to say the scent /size:down/I want..?", "테오"));

            dialogTexts.Add(new DialogData("Yes, if you set a theme or concept and tell us, we can select the right fragrance for you, or if you simply tell us the feeling of the scent you want, we do our best to make it!", "Player_R"));

            dialogTexts.Add(new DialogData("/size:down/Uh, well, then... /wate:0.5/I'd like to ask for something unusual, /size:down/not something normal.. So..", "테오"));

            dialogTexts.Add(new DialogData("/size:down/When you think of perfume, you think of pleasant scents, right? /size:down/I don't like that typical and stereotypical way of thinking.", "테오"));

            dialogTexts.Add(new DialogData("/size:down/I think the most unusual scent of perfume is the tree scent. It lasts the longest. /size:down/When I approach the tree and smell it, it doesn't smell anything.", "테오"));

            dialogTexts.Add(new DialogData("/size:down/The forest where the trees gather has a unique scent of forest. /size:down/Is it the same reason that individuals are weak, but groups of individuals have a loud voice?", "테오"));

            dialogTexts.Add(new DialogData("/size:down/Yes, anyway.. Unique tree scent. What's the most unusual thing about it? /size:down/Very unique perfume, please..", "테오", () => Show_Button()));

            DialogManager.Show(dialogTexts);
        }
        else
        {
            var dialogTexts = new List<DialogData>();

            dialogTexts.Add(new DialogData("/size:down/안녕하/size:down/세/size:down/요..", "테오"));

            dialogTexts.Add(new DialogData("안녕하세요! \n향수를 만들어주는 가게, 미스틱 파퓸입니다.", "Player_R"));

            dialogTexts.Add(new DialogData("/size:down/향수 만들고싶어서 왔/size:down/는/size:down/데..", "테오"));

            dialogTexts.Add(new DialogData("네, 어떤 향수를 원하시나요?", "Player_R"));

            dialogTexts.Add(new DialogData("/size:down/저.. 그냥 제가 원하는 향을 /size:down/말하면 /size:down/될까요..?", "테오"));

            dialogTexts.Add(new DialogData("네 손님, 원래는 손님께서 주제나 컨셉을 잡아서 말씀해주시면 컨셉에 맞는 향료를 선정해드리기도 하는데, 단순히 원하는 향의 느낌을 말씀해주셔도 최선을 다해서 만들어 드리고 있습니다!", "Player_R"));

            dialogTexts.Add(new DialogData("/size:down/어.. 음 그럼.. 평범한거 말고 /wate:0.5/좀 /size:down/특이한걸로 부탁드리고 싶은데..", "테오"));

            dialogTexts.Add(new DialogData("/size:down/향수를 떠올리면 좋은 향이 떠오르잖아요? 저는 그런 전형적이고 틀에 박힌 사고가 싫어서요.. 저는 향수의 향 중에서 가장 특이한게 나무향이라고 생각해요.. /size:down/향 중에서도 가장 오래 남아있잖아요..", "테오"));

            dialogTexts.Add(new DialogData("/size:down/나무에 다가가서 냄새를 맡아보면 아무런 향기가 안나던데.. 나무가 모인 숲에선 특유의 숲 향이 난단 말이죠.. /size:down/개개인은 힘이 없지만 개인이 모인 집단은 목소리가 큰 것과 같은 이치일까요..", "테오"));

            dialogTexts.Add(new DialogData("/size:down/그래요 어쨌든.. 특이한 나무향. 그중에서도 가장 특이한게 뭘까요..? /size:down/아주 특이한 향수.. /size:down/부탁드려요..", "테오", () => Show_Button()));

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

                dialogTexts.Add(new DialogData("/size:down//size:down/Can't the meaning of being an individual really be a majority? blah blah..", "테오"));

                DialogManager.Show(dialogTexts);
            }
            else
            {
                var dialogTexts = new List<DialogData>();

                dialogTexts.Add(new DialogData("/size:down//size:down/개인이란 것의 의미는 정녕 다수가 될 수 없는가..? 중얼중얼..", "테오"));

                DialogManager.Show(dialogTexts);
            }
        }
    }

    void Show_Button()
    {
        Button.SetActive(true);
    }
}
