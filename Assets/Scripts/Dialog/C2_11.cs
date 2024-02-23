using Doublsb.Dialog;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEditor.Rendering;
using UnityEngine;

public class C2_11 : MonoBehaviour
{
    public DialogManager DialogManager;

    public GameObject Cleo;

    public GameObject Ending;

    public GameObject Button;

    public GameObject[] Charic;

    public GameObject perfect;

    public GameObject hmm;

    private void OnEnable()
    {
        if (DialogSystem.instance.day == 10)
        {
            gameObject.SetActive(true);

            Cleo.SetActive(true);

            Invoke("StartEnd", 3f);
        }
        else
        {
            gameObject.SetActive(false);
        }
    }

    public void StartEnd()
    {
        if (DialogSystem.instance.Rang == 0)
        {
            var dialogTexts = new List<DialogData>();

            dialogTexts.Add(new DialogData("/speed:0.1/...", "End"));

            dialogTexts.Add(new DialogData("It's already been six days since you worked here.", "End"));

            dialogTexts.Add(new DialogData("/emote:Perfect/How was your week here? Did you get used to work?", "End"));

            dialogTexts.Add(new DialogData("/emote:Perfect/You must have experienced guests of various personalities,", "End"));

            dialogTexts.Add(new DialogData("/emote:Perfect/There must have been some unusual people among them.", "End"));

            dialogTexts.Add(new DialogData("Of course, there must have been some annoying things, right?", "End"));

            dialogTexts.Add(new DialogData("/emote:Perfect/But don't hate them too much. \nIt's our perfume store's job to embrace those people.", "End"));

            dialogTexts.Add(new DialogData("/emote:Perfect/Just as people hate someone for no reason, we love someone for no reason.", "End"));

            dialogTexts.Add(new DialogData("/emote:Perfect/If we give them a place to rest one by one, they'll try harder.", "End"));

            dialogTexts.Add(new DialogData("Anyway, today I'm going to make sure you have enough competence in the perfumer. \nI'll see if I can appoint you as a full-time employee and leave you with more work.", "End"));

            dialogTexts.Add(new DialogData("First of all, what are the scores so far?", "End", () => Show_EndScore()));

            DialogManager.Show(dialogTexts);
        }
        else
        {
            var dialogTexts = new List<DialogData>();

            dialogTexts.Add(new DialogData("/speed:0.1/...", "End"));

            dialogTexts.Add(new DialogData("벌써 네가 여기서 일한지 6일째네.", "End"));

            dialogTexts.Add(new DialogData("/emote:Perfect/어땠어? 이곳에서의 한 주간은? 일은 충분히 익숙해졌지?", "End"));

            dialogTexts.Add(new DialogData("/emote:Perfect/여러가지 성격의 손님들을 겪었을테고,", "End"));

            dialogTexts.Add(new DialogData("/emote:Perfect/그 중에는 특이한 분들도 있었겠지.", "End"));

            dialogTexts.Add(new DialogData("물론 짜증나는 일도 있었을거야, 그치?", "End"));

            dialogTexts.Add(new DialogData("/emote:Perfect/그렇지만 너무 미워하지는 마. \n그런분들도 품어주는게 우리 향수가게의 일이니까.", "End"));

            dialogTexts.Add(new DialogData("/emote:Perfect/사람들이 누군가를 이유없이 미워하듯이, 우린 이유없이 사랑해보는거야.", "End"));

            dialogTexts.Add(new DialogData("/emote:Perfect/한 분 한 분 쉬어갈 수 있는 안식처가 되어주면, 그분들도 더 노력할테니까.", "End"));

            dialogTexts.Add(new DialogData("아무튼 오늘은 네가 조향사에 대한 충분한 역량을 갖고 있는지 체크 할거야. \n너를 정직원으로 임명해서 네게 더 많은 일을 맡겨도 될지 보는거지.", "End"));

            dialogTexts.Add(new DialogData("일단 지금까지의 점수는?", "End", () => Show_EndScore()));

            DialogManager.Show(dialogTexts);
        }
    }

    void Show_EndScore()
    {
        Invoke("Show_button", 0.1f);

        int s = 0;

        for (int i = 0; i < DialogSystem.instance.MadePf.Length; i++)
        {
            if(DialogSystem.instance.MadePf[i] == true)
            {
                s++;
            }
        }

        if(s >= 5)
        {
            Zoom.instance.ShakP = 1f;
            Zoom.instance.Shaking = true;
            perfect.SetActive(true);

            if (DialogSystem.instance.Rang == 0)
            {
                var dialogTexts = new List<DialogData>();

                dialogTexts.Add(new DialogData("/emote:Perfect//size:up/Perfect score! /size:init/You did a good job! I didn't teach you much, but I'm very proud. You can start working as a full-time employee tomorrow!", "End", () => Show_button()));

                DialogManager.Show(dialogTexts);
            }
            else
            {
                var dialogTexts = new List<DialogData>();

                dialogTexts.Add(new DialogData("/emote:Perfect//size:up/만점이네! /size:init/잘해줬구나! 별로 가르쳐준 것도 없는데 굉장히 뿌듯하네. 내일부터 바로 정직원으로 일해도 되겠어!", "End", () => Show_button()));

                DialogManager.Show(dialogTexts);
            }
        }
        else if(s >= 3) 
        {
            if (DialogSystem.instance.Rang == 0)
            {
                var dialogTexts = new List<DialogData>();

                dialogTexts.Add(new DialogData("It's more than half, If you work a little more, \nyour skills will improve, right? \nI'll keep an eye on you a little longer, so try your best.", "End", () => Show_button()));

                DialogManager.Show(dialogTexts);
            }
            else
            {
                var dialogTexts = new List<DialogData>();

                dialogTexts.Add(new DialogData("절반은 넘었네, 조금만 더 일하면 실력이 늘겠는데? \n조금 더 지켜볼테니까 열심히 해봐.", "End", () => Show_button()));

                DialogManager.Show(dialogTexts);
            }
        }
        else
        {
            Zoom.instance.ShakP = 1f;
            Zoom.instance.Shaking = true;
            hmm.SetActive(true);

            if (DialogSystem.instance.Rang == 0)
            {
                var dialogTexts = new List<DialogData>();

                dialogTexts.Add(new DialogData("I can't believe it's less than half... You should work harder. \nThere will be another opportunity to hire full-time employees someday, so work hard until then.", "End", () => Show_button()));

                DialogManager.Show(dialogTexts);
            }
            else
            {
                var dialogTexts = new List<DialogData>();

                dialogTexts.Add(new DialogData("절반도 못넘다니... 더 열심히 해야겠구나. \n언젠가 정직원 채용 기회가 또 있을테니 그때까지 열심히 일해보렴.", "End", () => Show_button()));

                DialogManager.Show(dialogTexts);
            }
        }
    }

    public void Show_button()
    {
        Button.SetActive(true);
    }

        public void ShowEnding()
    {
        god.instance.Ending = true;

        Ending.SetActive(true);

        for (int i = 0; i < DialogSystem.instance.MadePf.Length - 1; i++)
        {
            if (DialogSystem.instance.MadePf[i] == true)
            {
                Charic[i].SetActive(true);
            }
        }

        Invoke("Fal", 2f);
    }

    void Fal()
    {
        perfect.SetActive(false);
        hmm.SetActive(false);
    }
}
