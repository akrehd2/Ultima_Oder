using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using System.IO;

public class DragImage : MonoBehaviour, IDragHandler, IBeginDragHandler, IEndDragHandler, IPointerDownHandler
{
    private RectTransform rectTransform;
    public RectTransform rectTransform2;

    private Rect rect1;
    private Rect rect2;

    private Canvas canvas;
    private Image buttonImage;
    private Color originalBackgroundColor = new Color(0, 0, 0, 0.5f);

    private bool isMovingToCenter = false;
    private Vector2 dragStartPos;
    private bool isFadingOut = false;
    private bool isDragging = false;
    private bool isButtonClicked = false;
    private bool isButtonClickable = true;

    public int Note;

    public static int totalScore = 0;  // 누적 점수 변수

    private List<string> draggedButtons = new List<string>();

    public static int dragCount = 0;  // 드래그 횟수

    void Start()
    {
        rectTransform = GetComponent<RectTransform>();
        canvas = GetComponentInParent<Canvas>();
        buttonImage = GetComponent<Image>();
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        if (!isMovingToCenter && isButtonClicked && isButtonClickable)
        {
            StartCoroutine(FadeOutButton());
        }

        dragStartPos = rectTransform.anchoredPosition;
        isDragging = true;
    }

    public void OnDrag(PointerEventData eventData)
    {
        rectTransform.anchoredPosition += eventData.delta / canvas.scaleFactor;

        rect1 = new Rect(rectTransform.position.x - rectTransform.rect.width / 2,
                         rectTransform.position.y - rectTransform.rect.height / 2,
                         rectTransform.rect.width, rectTransform.rect.height);
        rect2 = new Rect(rectTransform2.position.x - (rectTransform2.rect.width - 500) / 2,
                         rectTransform2.position.y - rectTransform2.rect.height / 2,
                         rectTransform2.rect.width - 500, rectTransform2.rect.height - 100);

        if (!isMovingToCenter)
        {
            if (rect1.Overlaps(rect2))
            {
                isMovingToCenter = true;

                if (isDragging)
                {
                    StartCoroutine(FadeOutButton());

                    // Print the information about the button that was dragged to the center
                    Debug.Log("Button Dragged to Center: " + gameObject.name);

                    // 추가: 리스트에 버튼 이름 추가
                    draggedButtons.Add(gameObject.name);

                    // 추가: 최초 3번만 누적하도록 설정
                    if (dragCount < 3)
                    {
                        int AddScore = 0;

                        // 버튼마다 스코어 저장
                        if (DialogSystem.instance.day == 0) //Jeniffer
                        {
                            AddScore = CalculateScore("Jeniffer", 1);
                        }
                        else if (DialogSystem.instance.day == 2)    ///Anne
                        {
                            AddScore = CalculateScore("Anne", 1);
                        }
                        else if (DialogSystem.instance.day == 4)    ///Anne
                        {
                            AddScore = CalculateScore("Olivia", 1);
                        }
                        else
                        {
                            Debug.Log("Not set day");
                        }

                        // 최종 스코어 계산 및 누적
                        totalScore += AddScore;
                        Debug.Log("Total Score: " + totalScore);

                        // 추가: 리스트 초기화
                        draggedButtons.Clear();
                    }
                    else
                    {
                        totalScore = -1;
                        Debug.Log("Total Score: " + totalScore);
                    }

                    DialogSystem.instance.Notelist[Note] += 1;

                    // 추가: 드래그 횟수 증가
                    dragCount++;
                }
            }
        }
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        if (isMovingToCenter)
        {
            StopAllCoroutines();
            StartCoroutine(FlickerButton());
        }
        else
        {
            StartCoroutine(MoveToOriginalPosition());
        }

        isDragging = false;
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        isButtonClicked = isButtonClickable && Vector2.Distance(rectTransform.anchoredPosition, Vector2.zero) < 50f / canvas.scaleFactor;
    }

    IEnumerator FadeOutButton()
    {
        if (isFadingOut)
        {
            yield break;
        }

        isFadingOut = true;

        float duration = 0.5f;
        float elapsedTime = 0f;
        Color startingColor = buttonImage.color;

        while (elapsedTime < duration)
        {
            buttonImage.color = Color.Lerp(startingColor, new Color(1, 1, 1, 0), elapsedTime / duration);
            elapsedTime += Time.deltaTime;
            yield return null;
        }

        isButtonClickable = false;

        isFadingOut = false;
    }

    IEnumerator MoveToOriginalPosition()
    {
        float duration = 0.5f;
        float elapsedTime = 0f;

        while (elapsedTime < duration)
        {
            rectTransform.anchoredPosition = Vector2.Lerp(rectTransform.anchoredPosition, dragStartPos, elapsedTime / duration);
            elapsedTime += Time.deltaTime;
            yield return null;
        }
    }

    IEnumerator FlickerButton()
    {
        for (int i = 0; i < 2; i++)
        {
            buttonImage.color = new Color(1, 1, 1, 1);
            yield return new WaitForSeconds(0.1f);
            buttonImage.color = originalBackgroundColor;
            yield return new WaitForSeconds(0.1f);
        }
        gameObject.SetActive(false);
    }

    private int CalculateScore(string fileName, int points)
    {
        int score = 0;

        foreach (string buttonName in draggedButtons)
        {
            // 파일 이름 구성
            TextAsset textAsset = Resources.Load<TextAsset>(fileName);

            // 파일 존재 여부 확인
            if (textAsset != null)
            {
                // 파일 내용 읽기
                string[] fileContents = textAsset.text.Split(",");

                // 버튼의 이름과 파일 내용이 일치하는 경우에만 점수 부여
                for (int i = 0; i < fileContents.Length; i++)
                {
                    if (fileContents[i] == buttonName)
                    {
                        score += points;

                        Debug.Log(buttonName + " contents: " + fileContents[i]);
                    }
                }
            }
            else
            {
                Debug.LogError(fileName + " does not exist in Resources!");
            }
        }

        return score;
    }
}
