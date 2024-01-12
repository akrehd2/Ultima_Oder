using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Fade : MonoBehaviour
{
    public Image FadeImage;
    public bool isFadingIn;
    public bool isFadingOut;

    public TextMeshProUGUI Date;

    private void Awake()
    {
        FadeOut();
    }

    public void StartDay()
    {
        Date.text = "Day 1";
    }

    public void ChangeDay()
    {
        DialogSystem.instance.day += 1;
        FadeImage.gameObject.SetActive(true);
        FadeImage.color = new Color(0, 0, 0, 1);

        Date.gameObject.SetActive(true);
        Date.color = new Color(1, 1, 1, 1);

        if (DialogSystem.instance.day < 2)
        {
            Date.text = "Day 1";
        }
        else if (DialogSystem.instance.day < 4)
        {
            Date.text = "Day 2";
        }
        else if (DialogSystem.instance.day < 6)
        {
            Date.text = "Day 3";
        }
        else if (DialogSystem.instance.day < 8)
        {
            Date.text = "Day 4";
        }
        else if (DialogSystem.instance.day < 10)
        {
            Date.text = "Day 5";
        }
        else if (DialogSystem.instance.day < 12)
        {
            Date.text = "Day 6";
        }

        Invoke("FadeOut", 2f);
    }

    public void FadeIn()
    {
        StartCoroutine(FadeInButton());
    }

    public void FadeOut()
    {
        StartCoroutine(FadeOutButton());
    }

    IEnumerator FadeInButton()
    {
        // 추가: FadeOutButton 코루틴이 이미 실행 중이라면 중단
        if (isFadingIn)
        {
            yield break;
        }

        isFadingIn = true;
        FadeImage.gameObject.SetActive(true);
        Date.gameObject.SetActive(true);

        float duration = 2f; // 투명해지는 데 걸리는 시간 (초)
        float elapsedTime = 0f;
        Color startingColor = FadeImage.color;
        Color startingColor2 = Date.color;

        while (elapsedTime < duration)
        {
            Date.color = Color.Lerp(startingColor2, new Color(1, 1, 1, 1), elapsedTime / (duration / 6));
            FadeImage.color = Color.Lerp(startingColor, new Color(0, 0, 0, 1), elapsedTime / duration);
            elapsedTime += Time.deltaTime;
            yield return null;
        }

        if(SceneManager.GetActiveScene().name == "TitleScene")
        {
            SceneManager.LoadScene("GameScene");
            FadeOut();
            isFadingIn = false;
        }
        else
        {
            isFadingIn = false;
            FadeImage.gameObject.SetActive(false);
            Date.gameObject.SetActive(false);
        }
    }

    // 추가: 버튼을 천천히 투명하게 하는 코루틴
    IEnumerator FadeOutButton()
    {
        // 추가: FadeOutButton 코루틴이 이미 실행 중이라면 중단
        if (isFadingOut)
        {
            yield break;
        }

        isFadingOut = true;
        FadeImage.gameObject.SetActive(true);
        Date.gameObject.SetActive(true);

        float duration = 2f; // 투명해지는 데 걸리는 시간 (초)
        float elapsedTime = 0f;
        Color startingColor = FadeImage.color;
        Color startingColor2 = Date.color;

        while (elapsedTime < duration)
        {
            FadeImage.color = Color.Lerp(startingColor, new Color(0, 0, 0, 0), elapsedTime / duration);
            Date.color = Color.Lerp(startingColor2, new Color(1, 1, 1, 0), elapsedTime / (duration / 6));
            elapsedTime += Time.deltaTime;
            yield return null;
        }

        isFadingOut = false;
        FadeImage.gameObject.SetActive(false);
        Date.gameObject.SetActive(false);
    }
}
