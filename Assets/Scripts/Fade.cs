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
        // �߰�: FadeOutButton �ڷ�ƾ�� �̹� ���� ���̶�� �ߴ�
        if (isFadingIn)
        {
            yield break;
        }

        isFadingIn = true;
        FadeImage.gameObject.SetActive(true);

        float duration = 2f; // ���������� �� �ɸ��� �ð� (��)
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

    // �߰�: ��ư�� õõ�� �����ϰ� �ϴ� �ڷ�ƾ
    IEnumerator FadeOutButton()
    {
        // �߰�: FadeOutButton �ڷ�ƾ�� �̹� ���� ���̶�� �ߴ�
        if (isFadingOut)
        {
            yield break;
        }

        isFadingOut = true;
        FadeImage.gameObject.SetActive(true);

        float duration = 2f; // ���������� �� �ɸ��� �ð� (��)
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
