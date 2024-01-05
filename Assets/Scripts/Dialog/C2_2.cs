using Doublsb.Dialog;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;

public class C2_2 : MonoBehaviour
{
    public DialogManager DialogManager;

    public GameObject Button;

    private void OnEnable()
    {
        if (DialogSystem.instance.day == 1)
        {
            gameObject.SetActive(true);

            Button.SetActive(false);

            if (DialogSystem.instance.Rang == 0)
            {
                var dialogTexts = new List<DialogData>();

                dialogTexts.Add(new DialogData("/size:up/You're the best! /size:init/I think you're talented!\r\nWhen customers order perfumes, you have to be able to meet their needs.", "제니퍼"));

                dialogTexts.Add(new DialogData("Look for clues in your order like just now.\r\nYou start working tomorrow. Good luck!", "제니퍼"));

                dialogTexts.Add(new DialogData("What a hectic day..", "Player_none"));

                dialogTexts.Add(new DialogData("From tomorrow, I will make perfume in earnest. Let's cheer up and do well.", "Player_none"));

                DialogManager.Show(dialogTexts);
            }
            else
            {
                var dialogTexts = new List<DialogData>();

                dialogTexts.Add(new DialogData("/size:up/최고야! /size:init/재능이 있는데?\r\n손님이 향수를 주문할 때 넌 지금처럼 손님들의 니즈를 맞출 수 있어야해.", "제니퍼"));

                dialogTexts.Add(new DialogData("손님의 주문에서 단서를 잘 찾아봐.\r\n내일부터 근무 시작이네. 잘 해보도록해!", "제니퍼"));

                dialogTexts.Add(new DialogData("정신없는 하루였다..", "Player_none"));

                dialogTexts.Add(new DialogData("내일부터 본격적으로 향수를 만들게 될거다.. 힘내서 잘 해보자.", "Player_none"));

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
        if (DialogSystem.instance.Rang == 0)
        {
            var dialogTexts = new List<DialogData>();

            dialogTexts.Add(new DialogData("Welcome to Mystique Parfume.", "Player"));

            dialogTexts.Add(new DialogData("/size:up/Well done!", "제니퍼"));

            dialogTexts.Add(new DialogData("Then you have to talk to the customer and understand the scent you want. /wait:0.3/Then let's start making perfume in earnest.", "제니퍼"));

            dialogTexts.Add(new DialogData("There are six types of scents in our store.", "제니퍼"));

            dialogTexts.Add(new DialogData("And if you click on the shelf you want to open it, you'll see the ingredients listed, and if you move up one by one, you'll see the corresponding information.", "제니퍼"));

            dialogTexts.Add(new DialogData("Then let's take the perfume order in earnest. /wait:0.3/I'll pretend to be a customer.", "제니퍼"));

            dialogTexts.Add(new DialogData("I love the scent of flowers./wait:0.3/ \r\nAt first, I hope romanticism will capture you,\r\nNext, flowers that smell like dirt would be good.", "제니퍼"));

            dialogTexts.Add(new DialogData("At the end, I hope you can feel the cool scent naturally.", "제니퍼"));

            DialogManager.Show(dialogTexts);
        }
        else
        {
            var dialogTexts = new List<DialogData>();

            dialogTexts.Add(new DialogData("어서오세요, 미스틱 파퓸입니다.", "Player"));

            dialogTexts.Add(new DialogData("/size:up/잘했어!", "제니퍼"));

            dialogTexts.Add(new DialogData("그럼 이제 손님과 대화하며 원하는 향을 잘 파악해야해. /wait:0.3/자 그럼 본격적으로 향수를 만들어보자.", "제니퍼"));

            dialogTexts.Add(new DialogData("우리 가게에서 향의 종류는 여섯 가지로 분류하고 있어.", "제니퍼"));

            dialogTexts.Add(new DialogData("그리고 원하는 선반을 클릭해서 열어보면, 보다시피 재료들이 나열되있을텐데, 하나하나 마우스를 올려보면 해당하는 정보가 보일거야.", "제니퍼"));

            dialogTexts.Add(new DialogData("그럼 본격적으로 향수 주문을 받아보자. /wait:0.3/내가 손님인 척 해볼게.", "제니퍼"));

            dialogTexts.Add(new DialogData("저는 꽃향기가 너무 좋아요. /wait:0.3/\r\n처음에는 로맨틱함이 사로잡았으면 좋겠고요,\r\n다음으로는 흙 냄새도 풍기는 꽃이면 좋아요.", "제니퍼"));

            dialogTexts.Add(new DialogData("마지막에는 시원한 향이 자연스럽게 느껴지면 좋겠네요.", "제니퍼", () => Show_Button()));

            DialogManager.Show(dialogTexts);
        }
    }
    
    void Show_Button()
    {
        Button.SetActive(true);
    }
}
