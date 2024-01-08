using Doublsb.Dialog;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;

public class C2_2 : MonoBehaviour
{
    public DialogManager DialogManager;

    public GameObject Button;
    public GameObject Rose;

    private void OnEnable()
    {
        if (DialogSystem.instance.day == 1)
        {
            gameObject.SetActive(true);

            Button.SetActive(false);

            if (DialogSystem.instance.Result == 0)
            {
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
            else if (DialogSystem.instance.Result == 1)
            {
                if (DialogSystem.instance.Rang == 0)
                {
                    var dialogTexts = new List<DialogData>();

                    dialogTexts.Add(new DialogData("It's Not Bad. You have an understanding of perfumes.\r\nBut, when the customer order perfume, you have to cater to customers' needs.", "제니퍼"));

                    dialogTexts.Add(new DialogData("To do that, we need to be able to find clues in your order, right?\r\nLet's take a good look at the order I just made.", "제니퍼"));

                    dialogTexts.Add(new DialogData("\"At first, I hope it's romantic,\" what's the closest ingredient we have in this spell?", "제니퍼", () => Show_Rose()));

                    dialogTexts.Add(new DialogData("As you can see, it's a rose. You should be able to understand your intentions as well as you are now. Try your best!", "제니퍼", null));

                    dialogTexts.Add(new DialogData("What a hectic day..", "Player_none"));

                    dialogTexts.Add(new DialogData("From tomorrow, I will make perfume in earnest. Let's cheer up and do well.", "Player_none"));

                    DialogManager.Show(dialogTexts);
                }
                else
                {
                    var dialogTexts = new List<DialogData>();

                    dialogTexts.Add(new DialogData("나쁘진 않아, 향수에 대한 이해도가 있어.\r\n하지만, 손님이 향수를 주문할 때 넌 손님들의 니즈를 맞춰야해.", "제니퍼"));

                    dialogTexts.Add(new DialogData("그러려면 손님의 주문에서 단서를 잘 찾을 수 있어야겠지?\r\n방금 내가 한 주문을 잘 살펴보자.", "제니퍼"));

                    dialogTexts.Add(new DialogData("\"처음에는 로맨틱함이 사로잡았으면 좋겠고요,\" 이 주문에서 우리가 갖고있는 향들 중에 제일 근접한 재료가 뭘까?", "제니퍼", () => Show_Rose()));

                    dialogTexts.Add(new DialogData("보다시피 장미인 걸 알 수 있을거야. 지금처럼 손님의 의도를 잘 파악할 수 있어야해. 잘 해보도록 해!", "제니퍼", null));

                    dialogTexts.Add(new DialogData("정신없는 하루였다..", "Player_none"));

                    dialogTexts.Add(new DialogData("내일부터 본격적으로 향수를 만들게 될거다.. 힘내서 잘 해보자.", "Player_none"));

                    DialogManager.Show(dialogTexts);
                }
            }
            else if (DialogSystem.instance.Result == 2)
            {
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
        }
        else
        {
            gameObject.SetActive(false);
        }
    }
    
    void Show_Rose()
    {
        Rose.SetActive(true);
    }
}
