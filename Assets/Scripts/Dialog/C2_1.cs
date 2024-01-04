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

                dialogTexts.Add(new DialogData("/size:up/Hi, /size:init/welcome to Mystique Parfume.", "������"));

                dialogTexts.Add(new DialogData("It's going to be quite busy today. /wait:0.3/You're going to have to learn to work like crazy.\n/wait:1/Of course I'll help you until you get used to it.", "������"));

                dialogTexts.Add(new DialogData("Now, first, we have to respond to customers when they come. /wait:0.3/You can click on them. \nI'll pretend to be a customer, so respond well.", "������_C"));

                DialogManager.Show(dialogTexts);
            }
            else
            {
                var dialogTexts = new List<DialogData>();

                dialogTexts.Add(new DialogData("/size:up/�ȳ�?, /size:init/�츮 �̽�ƽ ��Ǿ(Mystique Parfume)�� �� �� ȯ����.", "������"));

                dialogTexts.Add(new DialogData("���� �Ϸ�� �� �ٻڰ� �귯���ž�. /wait:0.3/���ž��� ���� ����� �� �Űŵ�. \n/wait:1/���� �ͼ����� ������ ���� ���� �����ٰ����� ����.", "������"));

                dialogTexts.Add(new DialogData("��, ���� �մ��� ���� �մ� ���븦 �ؾ���. /wait:0.3/�մ��� Ŭ���ϸ� ��. \n���� �մ��� ô �غ��״ϱ� �� �����غ�.", "������_C"));

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

            dialogTexts.Add(new DialogData("/size:up/Well done!", "������"));

            dialogTexts.Add(new DialogData("/size:init/Then you have to talk to the customer and understand the scent you want. /wait:0.3/Then let's start making perfume in earnest.", "������"));

            dialogTexts.Add(new DialogData("There are six types of scents in our store.", "������"));

            dialogTexts.Add(new DialogData("And if you click on the shelf you want to open it, you'll see the ingredients listed, and if you move up one by one, you'll see the corresponding information.", "������"));

            dialogTexts.Add(new DialogData("Then let's take the perfume order in earnest. /wait:0.3/I'll pretend to be a customer.", "������"));

            dialogTexts.Add(new DialogData("I love the scent of flowers./wait:0.3/ \r\nAt first, I hope romanticism will capture you,\r\nNext, flowers that smell like dirt would be good.", "������"));

            dialogTexts.Add(new DialogData("At the end, I hope you can feel the cool scent naturally.", "������"));

            DialogManager.Show(dialogTexts);
        }
        else
        {
            var dialogTexts = new List<DialogData>();

            dialogTexts.Add(new DialogData("�������, �̽�ƽ ��Ǿ�Դϴ�.", "Player"));

            dialogTexts.Add(new DialogData("/size:up/���߾�!", "������"));

            dialogTexts.Add(new DialogData("/size:init/�׷� ���� �մ԰� ��ȭ�ϸ� ���ϴ� ���� �� �ľ��ؾ���. /wait:0.3/�� �׷� ���������� ����� ������.", "������"));

            dialogTexts.Add(new DialogData("�츮 ���Կ��� ���� ������ ���� ������ �з��ϰ� �־�.", "������"));

            dialogTexts.Add(new DialogData("�׸��� ���ϴ� ������ Ŭ���ؼ� �����, ���ٽ��� ������ �����������ٵ�, �ϳ��ϳ� ���콺�� �÷����� �ش��ϴ� ������ ���ϰž�.", "������"));

            dialogTexts.Add(new DialogData("�׷� ���������� ��� �ֹ��� �޾ƺ���. /wait:0.3/���� �մ��� ô �غ���.", "������"));

            dialogTexts.Add(new DialogData("���� ����Ⱑ �ʹ� ���ƿ�. /wait:0.3/\r\nó������ �θ�ƽ���� ���������� ���ڰ��,\r\n�������δ� �� ������ ǳ��� ���̸� ���ƿ�.", "������"));

            dialogTexts.Add(new DialogData("���������� �ÿ��� ���� �ڿ������� �������� ���ڳ׿�.", "������"));

            DialogManager.Show(dialogTexts);
        }
    }
}
