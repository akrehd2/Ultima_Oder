using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using System.IO;

public class DragImage : MonoBehaviour
{
    public int Note;
    public int Oder;

    public void ChangeScore()
    {
        MadeScore.instance.Note = Note;
        MadeScore.instance.Oder = Oder;
    }
}
