using Doublsb.Dialog;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEditor.Rendering;
using UnityEngine;
using static UnityEditor.ShaderData;

public class C2_1 : MonoBehaviour
{
    public DialogManager DialogManager;

    public GameObject Button;

    public GameObject Printer;

    private void Start()
    {
        if (DialogSystem.instance.day == 0)
        {
            gameObject.SetActive(true);

            if (DialogSystem.instance.Rang == 0)
            {
                var dialogTexts = new List<DialogData>();

                dialogTexts.Add(new DialogData("/size:up/Hi, /size:init/welcome to Mystique Parfume.", "제니퍼"));

                dialogTexts.Add(new DialogData("You can intern here for the next 5 days. /wait:0.3/When the 6th day after the 5th day, you will face different results depending on your actions.", "제니퍼"));

                dialogTexts.Add(new DialogData("It's going to be quite busy today. /wait:0.3/You're going to have to learn to work like crazy.", "제니퍼"));

                dialogTexts.Add(new DialogData("Now, first, you have to respond to customers when they come. /wait:0.3/Here's how to do it: You can click on them. \nI'll pretend to be a customer, so respond well.", "제니퍼_C"));

                DialogManager.Show(dialogTexts);
            }
            else
            {
                var dialogTexts = new List<DialogData>();

                dialogTexts.Add(new DialogData("/size:up/안녕?, /size:init/우리 미스틱 파퓸(Mystique Parfume)에 온 걸 환영해.", "제니퍼"));

                dialogTexts.Add(new DialogData("넌 앞으로 여기서 5일간 인턴 생활을 하면 돼. /wait:0.3/5일이 지나고 6일째가 되는 날, 그동안 네가 한 행동에 따라 다른 결과를 맞이하게 될거야.", "제니퍼"));

                dialogTexts.Add(new DialogData("오늘 하루는 꽤 바쁘게 흘러갈거야. /wait:0.3/정신없이 일을 배워야 할 거거든.", "제니퍼"));

                dialogTexts.Add(new DialogData("자, 먼저 손님이 오면 응대를 해야해. /wait:0.3/어떻게 하냐고? 그냥 손님을 클릭하면 돼! \n내가 손님인 척 해볼테니까 잘 응대해봐.", "제니퍼_C"));

                DialogManager.Show(dialogTexts);
            }
        }
        else
        {
            gameObject.SetActive(false);
        }
    }

    public void Event1()
    {
        if (Printer.activeSelf == false)
        {
            if (DialogSystem.instance.Rang == 0)
            {
                var dialogTexts = new List<DialogData>();

                dialogTexts.Add(new DialogData("Welcome to Mystique Parfume.", "Player"));

                dialogTexts.Add(new DialogData("/size:up/Well done!", "제니퍼"));

                dialogTexts.Add(new DialogData("Now, let’s learn how to make perfume.", "제니퍼"));

                dialogTexts.Add(new DialogData("There are six types of scents in our store. There are a total of 24 ingredients, but we generally use 3 ingredients.", "제니퍼"));

                dialogTexts.Add(new DialogData("If you click on the shelf divided by type to open it, the ingredients will be listed. If you look closely at each item, you will see the corresponding information.", "제니퍼"));

                dialogTexts.Add(new DialogData("Now, let’s take perfume orders in earnest. You need to understand the desired scent through conversation with the customer. \nI'll pretend I'm a customer.", "제니퍼"));

                dialogTexts.Add(new DialogData("I really like the scent of flowers./wait:0.3/ \r\nAt first, I hope romanticism will capture you,\r\nNext, it would be good if it was a flower that also had an earthy smell.", "제니퍼"));

                dialogTexts.Add(new DialogData("I hope you can feel the cool scent naturally at the end. \nI wish all scents had the same amount.", "제니퍼", () => Show_Button()));

                DialogManager.Show(dialogTexts);
            }
            else
            {
                var dialogTexts = new List<DialogData>();

                dialogTexts.Add(new DialogData("어서오세요, 미스틱 파퓸입니다.", "Player"));

                dialogTexts.Add(new DialogData("/size:up/잘했어!", "제니퍼"));

                dialogTexts.Add(new DialogData("자 그럼 향수를 만드는 법에 대해 배워보자.", "제니퍼"));

                dialogTexts.Add(new DialogData("우리 가게에서 노트의 종류는 여섯 가지로 분류하고 있어. 시트러스, 프루티, 플로럴, 스파이스, 그린, 우드. 재료는 훨씬 많지만 주로 세 종류만 써.", "제니퍼"));

                dialogTexts.Add(new DialogData("종류별로 나뉘어진 선반을 클릭해서 열어보면 재료들이 나열되어있을텐데, 하나하나 자세히 살펴보면 해당하는 정보가 보일거야.", "제니퍼"));

                dialogTexts.Add(new DialogData("그럼 본격적으로 향수 주문을 받아보자. 손님과의 대화를 통해 원하는 향을 잘 파악해야해. \n내가 손님인 척 해볼게.", "제니퍼"));

                dialogTexts.Add(new DialogData("저는 꽃향기가 너무 좋아요. /wait:0.3/\r\n처음에는 로맨틱함이 사로잡았으면 좋겠고요,\r\n다음으로는 흙 냄새도 풍기는 꽃이면 좋아요.", "제니퍼"));

                dialogTexts.Add(new DialogData("마지막에는 시원한 향이 자연스럽게 느껴지면 좋겠네요. \n모든 향이 비슷하게 났으면 좋겠어요.", "제니퍼", () => Show_Button()));

                DialogManager.Show(dialogTexts);
            }
        }
    }

    public void click()
    {
        if(Printer.activeSelf == false)
        {
            if (DialogSystem.instance.Rang == 0)
            {
                var dialogTexts = new List<DialogData>();

                dialogTexts.Add(new DialogData("Umm? You didn't make perfume yet?", "제니퍼"));

                DialogManager.Show(dialogTexts);
            }
            else
            {
                var dialogTexts = new List<DialogData>();

                dialogTexts.Add(new DialogData("응? 향수는 아직이야?", "제니퍼"));

                DialogManager.Show(dialogTexts);
            }
        }
    }

    void Show_Button()
    {
        Button.SetActive(true);
    }
}
