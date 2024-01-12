using Doublsb.Dialog;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;

public class C2_3 : MonoBehaviour
{
    public DialogManager DialogManager;

    public GameObject Grandma;

    public GameObject Button;

    private void OnEnable()
    {
        if (DialogSystem.instance.day == 2)
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
        Grandma.SetActive(true);

        Grandma.GetComponent<AudioSource>().Play();
    }

    public void Start3day()
    {
        if (DialogSystem.instance.Rang == 0)
        {
            var dialogTexts = new List<DialogData>();

            dialogTexts.Add(new DialogData("Hello, this is Mystique Parfume, we make perfumes with the scent you want.", "Player_A"));

            dialogTexts.Add(new DialogData("/speed:0.06/Hello. I stopped by once while passing by.. \nYou make perfumes according to the scent whatever I want..? Ho-ho.", "앤"));

            dialogTexts.Add(new DialogData("/speed:0.06/Reminds me of the first time I bought a perfume... when I was a girl, I used it a lot because of my husband now..", "앤"));

            dialogTexts.Add(new DialogData("What a romantic story.", "Player_A"));

            dialogTexts.Add(new DialogData("/speed:0.06/I'd like to make a gift for my grandson. I'm afraid he has no appetite these days. He's a picky eater of carrots and cucumbers, I don't know much about perfumes..", "앤"));

            dialogTexts.Add(new DialogData("/speed:0.06/but is there a case of adding food flavor to it? \nI hope it also contains a scent that makes your body comfortable to boost your appetite.", "앤", () => Show_Button()));

            DialogManager.Show(dialogTexts);
        }
        else
        {
            var dialogTexts = new List<DialogData>();

            dialogTexts.Add(new DialogData("안녕하세요, 원하는 향으로 향수를 만들어주는 가게, 미스틱 파퓸입니다.", "Player_A"));

            dialogTexts.Add(new DialogData("/speed:0.06/안녕하신가요. 지나가다가 한 번 들렀네만.. \n원하는대로 향대로 향수를 만들어준다고요.. 호호.", "앤"));

            dialogTexts.Add(new DialogData("/speed:0.06/첫 향수를 샀을 때가 생각나네요.. 처녀 시절 적, 남편 때문에 많이 사용했었는데..", "앤"));

            dialogTexts.Add(new DialogData("낭만적인 이야기군요.", "Player_A"));

            dialogTexts.Add(new DialogData("/speed:0.06/손주에게 줄 선물을 만들고 싶네요. 손주가 식욕이 너무 없어서 걱정인데.. 나는 향수에 대해 잘 모릅니다만..", "앤"));

            dialogTexts.Add(new DialogData("/speed:0.06/아이가 당근과 오이를 계속해서 편식하는데 음식 향기를 넣는 경우도 있나요?\r\n식욕을 좀 돋구게 몸을 편안하게 해주는 향도 들어갔으면 좋겠네요.", "앤", () => Show_Button()));

            DialogManager.Show(dialogTexts);
        }
    }
    void Show_Button()
    {
        Button.SetActive(true);
    }
}
