using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Fade : MonoBehaviour
{
    public Image FadeImage;
    public bool isFadingIn;
    public bool isFadingOut;

    private void Awake()
    {
        FadeOut();
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

        float duration = 2f; // 투명해지는 데 걸리는 시간 (초)
        float elapsedTime = 0f;
        Color startingColor = FadeImage.color;

        while (elapsedTime < duration)
        {
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

        float duration = 2f; // 투명해지는 데 걸리는 시간 (초)
        float elapsedTime = 0f;
        Color startingColor = FadeImage.color;

        while (elapsedTime < duration)
        {
            FadeImage.color = Color.Lerp(startingColor, new Color(0, 0, 0, 0), elapsedTime / duration);
            elapsedTime += Time.deltaTime;
            yield return null;
        }

        isFadingOut = false;
        FadeImage.gameObject.SetActive(false);
    }
}
