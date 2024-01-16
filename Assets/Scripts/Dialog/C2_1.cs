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

                dialogTexts.Add(new DialogData("/size:up/Hi, /size:init/welcome to Mystique Parfume.", "������"));

                dialogTexts.Add(new DialogData("You can intern here for the next 5 days. /wait:0.3/When the 6th day after the 5th day, you will face different results depending on your actions.", "������"));

                dialogTexts.Add(new DialogData("It's going to be quite busy today. /wait:0.3/You're going to have to learn to work like crazy.", "������"));

                dialogTexts.Add(new DialogData("Now, first, you have to respond to customers when they come. /wait:0.3/Here's how to do it: You can click on them. \nI'll pretend to be a customer, so respond well.", "������_C"));

                DialogManager.Show(dialogTexts);
            }
            else
            {
                var dialogTexts = new List<DialogData>();

                dialogTexts.Add(new DialogData("/size:up/�ȳ�?, /size:init/�츮 �̽�ƽ ��Ǿ(Mystique Parfume)�� �� �� ȯ����.", "������"));

                dialogTexts.Add(new DialogData("�� ������ ���⼭ 5�ϰ� ���� ��Ȱ�� �ϸ� ��. /wait:0.3/5���� ������ 6��°�� �Ǵ� ��, �׵��� �װ� �� �ൿ�� ���� �ٸ� ����� �����ϰ� �ɰž�.", "������"));

                dialogTexts.Add(new DialogData("���� �Ϸ�� �� �ٻڰ� �귯���ž�. /wait:0.3/���ž��� ���� ����� �� �Űŵ�.", "������"));

                dialogTexts.Add(new DialogData("��, ���� �մ��� ���� ���븦 �ؾ���. /wait:0.3/��� �ϳİ�? �׳� �մ��� Ŭ���ϸ� ��! \n���� �մ��� ô �غ��״ϱ� �� �����غ�.", "������_C"));

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

                dialogTexts.Add(new DialogData("/size:up/Well done!", "������"));

                dialogTexts.Add(new DialogData("Now, let��s learn how to make perfume.", "������"));

                dialogTexts.Add(new DialogData("There are six types of scents in our store. There are a total of 24 ingredients, but we generally use 3 ingredients.", "������"));

                dialogTexts.Add(new DialogData("If you click on the shelf divided by type to open it, the ingredients will be listed. If you look closely at each item, you will see the corresponding information.", "������"));

                dialogTexts.Add(new DialogData("Now, let��s take perfume orders in earnest. You need to understand the desired scent through conversation with the customer. \nI'll pretend I'm a customer.", "������"));

                dialogTexts.Add(new DialogData("I really like the scent of flowers./wait:0.3/ \r\nAt first, I hope romanticism will capture you,\r\nNext, it would be good if it was a flower that also had an earthy smell.", "������"));

                dialogTexts.Add(new DialogData("I hope you can feel the cool scent naturally at the end. \nI wish all scents had the same amount.", "������", () => Show_Button()));

                DialogManager.Show(dialogTexts);
            }
            else
            {
                var dialogTexts = new List<DialogData>();

                dialogTexts.Add(new DialogData("�������, �̽�ƽ ��Ǿ�Դϴ�.", "Player"));

                dialogTexts.Add(new DialogData("/size:up/���߾�!", "������"));

                dialogTexts.Add(new DialogData("�� �׷� ����� ����� ���� ���� �������.", "������"));

                dialogTexts.Add(new DialogData("�츮 ���Կ��� ��Ʈ�� ������ ���� ������ �з��ϰ� �־�. ��Ʈ����, ����Ƽ, �÷η�, �����̽�, �׸�, ���. ���� �ξ� ������ �ַ� �� ������ ��.", "������"));

                dialogTexts.Add(new DialogData("�������� �������� ������ Ŭ���ؼ� ����� ������ �����Ǿ������ٵ�, �ϳ��ϳ� �ڼ��� ���캸�� �ش��ϴ� ������ ���ϰž�.", "������"));

                dialogTexts.Add(new DialogData("�׷� ���������� ��� �ֹ��� �޾ƺ���. �մ԰��� ��ȭ�� ���� ���ϴ� ���� �� �ľ��ؾ���. \n���� �մ��� ô �غ���.", "������"));

                dialogTexts.Add(new DialogData("���� ����Ⱑ �ʹ� ���ƿ�. /wait:0.3/\r\nó������ �θ�ƽ���� ���������� ���ڰ��,\r\n�������δ� �� ������ ǳ��� ���̸� ���ƿ�.", "������"));

                dialogTexts.Add(new DialogData("���������� �ÿ��� ���� �ڿ������� �������� ���ڳ׿�. \n��� ���� ����ϰ� ������ ���ھ��.", "������", () => Show_Button()));

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

                dialogTexts.Add(new DialogData("Umm? You didn't make perfume yet?", "������"));

                DialogManager.Show(dialogTexts);
            }
            else
            {
                var dialogTexts = new List<DialogData>();

                dialogTexts.Add(new DialogData("��? ����� �����̾�?", "������"));

                DialogManager.Show(dialogTexts);
            }
        }
    }

    void Show_Button()
    {
        Button.SetActive(true);
    }
}
