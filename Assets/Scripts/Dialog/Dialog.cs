using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialog : MonoBehaviour
{
    [Tooltip("ĳ���� �̸�")]
    public string Cname;

    [Tooltip("��� ����")]
    public string[] contexts;

    [Tooltip("�̺�Ʈ ��ȣ")]
    public int number;

    [Tooltip("��ŵ����")]
    public bool[] skipnum;
}
