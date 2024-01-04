using Doublsb.Dialog;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;

public class C2_1 : MonoBehaviour
{
    public DialogManager DialogManager;

    private void Start()
    {
        if (DialogSystem.instance.day == 0)
        {
            gameObject.SetActive(true);

            if (DialogSystem.instance.Rang == 0)
            {
                var dialogTexts = new List<DialogData>();

                dialogTexts.Add(new DialogData("/size:up/Hi, /size:init/welcome to Mystique Parfume.", "제니퍼"));

                dialogTexts.Add(new DialogData("It's going to be quite busy today. /wait:0.3/You're going to have to learn to work like crazy.\n/wait:1/Of course I'll help you until you get used to it.", "제니퍼"));

                dialogTexts.Add(new DialogData("Now, first, we have to respond to customers when they come. /wait:0.3/You can click on them. \nI'll pretend to be a customer, so respond well.", "제니퍼_C"));

                DialogManager.Show(dialogTexts);
            }
            else
            {
                var dialogTexts = new List<DialogData>();

                dialogTexts.Add(new DialogData("/size:up/안녕?, /size:init/우리 미스틱 파퓸(Mystique Parfume)에 온 걸 환영해.", "제니퍼"));

                dialogTexts.Add(new DialogData("오늘 하루는 꽤 바쁘게 흘러갈거야. /wait:0.3/정신없이 일을 배워야 할 거거든. \n/wait:1/일이 익숙해질 때까지 물론 내가 도와줄거지만 말야.", "제니퍼"));

                dialogTexts.Add(new DialogData("자, 먼저 손님이 오면 손님 응대를 해야해. /wait:0.3/손님을 클릭하면 돼. \n내가 손님인 척 해볼테니까 잘 응대해봐.", "제니퍼_C"));

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

            dialogTexts.Add(new DialogData("/size:init/Then you have to talk to the customer and understand the scent you want. /wait:0.3/Then let's start making perfume in earnest.", "제니퍼"));

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

            dialogTexts.Add(new DialogData("/size:init/그럼 이제 손님과 대화하며 원하는 향을 잘 파악해야해. /wait:0.3/자 그럼 본격적으로 향수를 만들어보자.", "제니퍼"));

            dialogTexts.Add(new DialogData("우리 가게에서 향의 종류는 여섯 가지로 분류하고 있어.", "제니퍼"));

            dialogTexts.Add(new DialogData("그리고 원하는 선반을 클릭해서 열어보면, 보다시피 재료들이 나열되있을텐데, 하나하나 마우스를 올려보면 해당하는 정보가 보일거야.", "제니퍼"));

            dialogTexts.Add(new DialogData("그럼 본격적으로 향수 주문을 받아보자. /wait:0.3/내가 손님인 척 해볼게.", "제니퍼"));

            dialogTexts.Add(new DialogData("저는 꽃향기가 너무 좋아요. /wait:0.3/\r\n처음에는 로맨틱함이 사로잡았으면 좋겠고요,\r\n다음으로는 흙 냄새도 풍기는 꽃이면 좋아요.", "제니퍼"));

            dialogTexts.Add(new DialogData("마지막에는 시원한 향이 자연스럽게 느껴지면 좋겠네요.", "제니퍼"));

            DialogManager.Show(dialogTexts);
        }
    }
}
