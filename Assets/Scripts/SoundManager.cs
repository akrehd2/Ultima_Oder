using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public AudioSource Bgms;

    public AudioSource[] Effects;

    public AudioClip[] bgm;

    private void Update()
    {
        if (DialogSystem.instance.day < 2)
        {
            Bgms.clip = bgm[0];
        }
        else if (DialogSystem.instance.day < 4)
        {
            Bgms.clip = bgm[1];
        }
        else if (DialogSystem.instance.day < 6)
        {
            Bgms.clip = bgm[2];
        }
        else if (DialogSystem.instance.day < 8)
        {
            Bgms.clip = bgm[3];
        }
        else if (DialogSystem.instance.day < 10)
        {
            Bgms.clip = bgm[4];
        }
        else if (DialogSystem.instance.day < 12)
        {
            Bgms.clip = bgm[5];
        }
    }
}
