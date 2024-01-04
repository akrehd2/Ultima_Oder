using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialog : MonoBehaviour
{
    [Tooltip("캐릭터 이름")]
    public string Cname;

    [Tooltip("대사 내용")]
    public string[] contexts;

    [Tooltip("이벤트 번호")]
    public int number;

    [Tooltip("스킵라인")]
    public bool[] skipnum;
}
