using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SoundManager : MonoBehaviour
{
    public AudioSource Bgms;

    public AudioSource[] Effects;

    public AudioClip[] bgm;

    public Slider Sv;

    private void Update()
    {
        Bgms.volume = Sv.value;

        if (SceneManager.GetActiveScene().name != "TitleScene")
        {
            if (DialogSystem.instance.day < 2)
            {
                if (Bgms.clip != bgm[0])
                {
                    Bgms.clip = bgm[0];
                    Bgms.Stop();
                    Bgms.Play();
                }
            }
            else if (DialogSystem.instance.day < 4)
            {
                if (Bgms.clip != bgm[1])
                {
                    Bgms.clip = bgm[1];
                    Bgms.Stop();
                    Bgms.Play();
                }
            }
            else if (DialogSystem.instance.day < 6)
            {
                if (Bgms.clip != bgm[2])
                {
                    Bgms.clip = bgm[2];
                    Bgms.Stop();
                    Bgms.Play();
                }
            }
            else if (DialogSystem.instance.day < 8)
            {
                if (Bgms.clip != bgm[3])
                {
                    Bgms.clip = bgm[3];
                    Bgms.Stop();
                    Bgms.Play();
                }
            }
            else if (DialogSystem.instance.day < 10)
            {
                if (Bgms.clip != bgm[4])
                {
                    Bgms.clip = bgm[4];
                    Bgms.Stop();
                    Bgms.Play();
                }
            }
            else if (DialogSystem.instance.day < 12)
            {
                if (Bgms.clip != bgm[5])
                {
                    Bgms.clip = bgm[5];
                    Bgms.Stop();
                    Bgms.Play();
                }
            }
        }
    }
}
