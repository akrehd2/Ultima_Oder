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

            dialogTexts.Add(new DialogData("/sound:Door/Bonjour! This is the place that makes perfumes, right??", "���"));

            dialogTexts.Add(new DialogData("/emote:Great/Oui, bonjour, sir. we are Mystique Parfume, the store that makes perfumes.", "Player_T"));

            dialogTexts.Add(new DialogData("/emote:Perfect/Wow! It smells good in here! Awesome!!!!", "���"));

            dialogTexts.Add(new DialogData("You Know What? Aroma therapy using aroma oil is popular among friends these days! \nBut I'm a trendsetter!", "���"));

            dialogTexts.Add(new DialogData("I'm going to go beyond oil and fashion perfume like a grown-up! My first perfume... I'm going to give it to my grandmother.", "���"));

            dialogTexts.Add(new DialogData("/emote:Great/That's very thoughtful of you.", "Player_T"));

            dialogTexts.Add(new DialogData("My grandmother recently got burned while making carrot soup for me. If there are ingredients that are good for burns, please add them generously, generously!!", "���"));

            dialogTexts.Add(new DialogData("Oh! And my grandmother is very worried because she's been losing a lot of hair lately. It would be great if you could add a scent that helps with hair care enough!", "���"));

            dialogTexts.Add(new DialogData("And finally, please give it a soft woody fragrance as a finishing touch! Because she likes woody smell.", "���"));

            dialogTexts.Add(new DialogData("But I don't like it when it smells too much like wood from my grandmother.. It's like a dead person.. So please add just a tiny bit, just a tiny bit!/emote:Great/", "���", () => Show_Button()));

            DialogManager.Show(dialogTexts);
        }
        else
        {
            var dialogTexts = new List<DialogData>();

            dialogTexts.Add(new DialogData("/sound:Door/�ȳ��ϼ���! ���� ��� ������ִµ� ����??", "���"));

            dialogTexts.Add(new DialogData("/emote:Great/��, �������, �մ�. \n����� ������ִ� ����, �̽�ƽ ��Ǿ�Դϴ�.", "Player_T"));

            dialogTexts.Add(new DialogData("/emote:Perfect/���!! ��� ���پ�!! ���!!!!", "���"));

            dialogTexts.Add(new DialogData("�װ� �Ƽ���?? ���� ģ���� ���̿��� �Ʒθ� ������ �̿��ϴ� �Ʒθ� �׶��ǰ� �����̿���! \n������ �� ������ �����ϴ� �������!", "���"));

            dialogTexts.Add(new DialogData("���� ������ �Ѿ�� ������� ����� �����ų�ſ���! �� ù �����.. �ҸӴϲ� �帱�ſ���.", "���"));

            dialogTexts.Add(new DialogData("/emote:Great/��������ó׿�.", "Player_T"));

            dialogTexts.Add(new DialogData("�ֱٿ� �ҸӴϰ� ���� ���� ��� ������ ����ôٰ� ȭ���� �����̾��.. ȭ�� ���� ��ᰡ ������ ���� �־��ּ���, ����!!", "���"));

            dialogTexts.Add(new DialogData("��! �׸��� �ҸӴϰ� ���� �Ӹ�ī���� ���� �����ż� ������ �����ŵ� �Ӹ��� �������ִ� �⵵ ������ ������ ���ھ��!", "���"));

            dialogTexts.Add(new DialogData("�׸��� �������δ� �ε巯�� ���� ��Ⱑ ���� ���ּ���! �ҸӴϰ� ���� ���� �����ϼ���.", "���"));

            dialogTexts.Add(new DialogData("�ٵ� �� �ҸӴ����׼� ������Ⱑ ���°� �Ⱦ��.. ���� ��� ���ݾƿ�.. �׷��� ���� �ɲ��� �־��ּ���, �ɲ���!!/emote:Great/", "���", () => Show_Button()));

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

                dialogTexts.Add(new DialogData("I hope it comes out soon... hehe/emote:Great/", "���"));

                DialogManager.Show(dialogTexts);
            }
            else
            {
                var dialogTexts = new List<DialogData>();

                dialogTexts.Add(new DialogData("���� �������� ���ڴ�.. ����/emote:Great/", "���"));

                DialogManager.Show(dialogTexts);
            }
        }
    }

    void Show_Button()
    {
        Button.SetActive(true);
    }
}
