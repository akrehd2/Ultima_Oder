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

            dialogTexts.Add(new DialogData("/size:down/Bon/size:down/jou/size:down/r..", "�׿�"));

            dialogTexts.Add(new DialogData("Bonjour! \nWe are Mystique Parfume, a perfume maker", "Player_R"));

            dialogTexts.Add(new DialogData("/size:down/I want to make/size:down/perfume.. /size:down/So...", "�׿�"));

            dialogTexts.Add(new DialogData("Yes, what perfume do you want?", "Player_R"));

            dialogTexts.Add(new DialogData("/size:down/Do I just.. /size:down/have to say the scent /size:down/I want..?", "�׿�"));

            dialogTexts.Add(new DialogData("Yes, if you set a theme or concept and tell us, we can select the right fragrance for you, or if you simply tell us the feeling of the scent you want, we do our best to make it!", "Player_R"));

            dialogTexts.Add(new DialogData("/size:down/Uh, well, then... /wate:0.5/I'd like to ask for something unusual, /size:down/not something normal.. So..", "�׿�"));

            dialogTexts.Add(new DialogData("/size:down/When you think of perfume, you think of pleasant scents, right? /size:down/I don't like that typical and stereotypical way of thinking.", "�׿�"));

            dialogTexts.Add(new DialogData("/size:down/I think the most unusual scent of perfume is the tree scent. It lasts the longest. /size:down/When I approach the tree and smell it, it doesn't smell anything.", "�׿�"));

            dialogTexts.Add(new DialogData("/size:down/The forest where the trees gather has a unique scent of forest. /size:down/Is it the same reason that individuals are weak, but groups of individuals have a loud voice?", "�׿�"));

            dialogTexts.Add(new DialogData("/size:down/Yes, anyway.. Unique tree scent. What's the most unusual thing about it? /size:down/Very unique perfume, please..", "�׿�", () => Show_Button()));

            DialogManager.Show(dialogTexts);
        }
        else
        {
            var dialogTexts = new List<DialogData>();

            dialogTexts.Add(new DialogData("/size:down/�ȳ���/size:down/��/size:down/��..", "�׿�"));

            dialogTexts.Add(new DialogData("�ȳ��ϼ���! \n����� ������ִ� ����, �̽�ƽ ��Ǿ�Դϴ�.", "Player_R"));

            dialogTexts.Add(new DialogData("/size:down/��� �����; ��/size:down/��/size:down/��..", "�׿�"));

            dialogTexts.Add(new DialogData("��, � ����� ���Ͻó���?", "Player_R"));

            dialogTexts.Add(new DialogData("/size:down/��.. �׳� ���� ���ϴ� ���� /size:down/���ϸ� /size:down/�ɱ��..?", "�׿�"));

            dialogTexts.Add(new DialogData("�� �մ�, ������ �մԲ��� ������ ������ ��Ƽ� �������ֽø� ������ �´� ��Ḧ �����ص帮�⵵ �ϴµ�, �ܼ��� ���ϴ� ���� ������ �������ּŵ� �ּ��� ���ؼ� ����� �帮�� �ֽ��ϴ�!", "Player_R"));

            dialogTexts.Add(new DialogData("/size:down/��.. �� �׷�.. ����Ѱ� ���� /wate:0.5/�� /size:down/Ư���Ѱɷ� ��Ź�帮�� ������..", "�׿�"));

            dialogTexts.Add(new DialogData("/size:down/����� ���ø��� ���� ���� �������ݾƿ�? ���� �׷� �������̰� Ʋ�� ���� ��� �Ⱦ��.. ���� ����� �� �߿��� ���� Ư���Ѱ� �������̶�� �����ؿ�.. /size:down/�� �߿����� ���� ���� �������ݾƿ�..", "�׿�"));

            dialogTexts.Add(new DialogData("/size:down/������ �ٰ����� ������ �þƺ��� �ƹ��� ��Ⱑ �ȳ�����.. ������ ���� ������ Ư���� �� ���� ���� ������.. /size:down/�������� ���� ������ ������ ���� ������ ��Ҹ��� ū �Ͱ� ���� ��ġ�ϱ��..", "�׿�"));

            dialogTexts.Add(new DialogData("/size:down/�׷��� ��·��.. Ư���� ������. ���߿����� ���� Ư���Ѱ� �����..? /size:down/���� Ư���� ���.. /size:down/��Ź�����..", "�׿�", () => Show_Button()));

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

                dialogTexts.Add(new DialogData("/size:down//size:down/Can't the meaning of being an individual really be a majority? blah blah..", "�׿�"));

                DialogManager.Show(dialogTexts);
            }
            else
            {
                var dialogTexts = new List<DialogData>();

                dialogTexts.Add(new DialogData("/size:down//size:down/�����̶� ���� �ǹ̴� ���� �ټ��� �� �� ���°�..? �߾��߾�..", "�׿�"));

                DialogManager.Show(dialogTexts);
            }
        }
    }

    void Show_Button()
    {
        Button.SetActive(true);
    }
}
