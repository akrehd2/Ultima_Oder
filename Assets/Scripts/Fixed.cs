using UnityEngine;

public class Fixed : MonoBehaviour
{
    private void Start()
    {
        SetResolution();
    }

    /// <summary>
    /// �ػ� ���� �Լ�
    /// </summary>
    public void SetResolution()
    {
        int setWidth = 1920; // ȭ�� �ʺ�
        int setHeight = 1080; // ȭ�� ����

        //�ػ󵵸� �������� ���� ����
        //3��° �Ķ���ʹ� Ǯ��ũ�� ��带 ���� > true : Ǯ��ũ��, false : â���
        Screen.SetResolution(setWidth, setHeight, true);
    }
}