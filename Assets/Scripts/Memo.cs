using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Memo : MonoBehaviour
{
    public Sprite[] Memos;
    public Image image;

    private void Update()
    {
        if (DialogSystem.instance.day < 6)
        {
            if (DialogSystem.instance.Rang == 0)
            {
                image.sprite = Memos[0];
            }
            else
            {
                image.sprite = Memos[1];
            }
        }
        else
        {
            if (gameObject.name != "Mixture Note Shadow")
            {
                image.gameObject.transform.localScale = new Vector3(0.66f, 1, 1);
            }

            if (DialogSystem.instance.Rang == 0)
            {
                image.sprite = Memos[2];
            }
            else
            {
                image.sprite = Memos[3];
            }
        }
    }
}
