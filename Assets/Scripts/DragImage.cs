using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using System.Collections;

public class DragImage : MonoBehaviour, IDragHandler, IBeginDragHandler, IEndDragHandler, IPointerDownHandler
{
    private RectTransform rectTransform;
    private Canvas canvas;
    private Image buttonImage;
    private Color originalBackgroundColor = new Color(0, 0, 0, 0.5f); // 어두운 배경 색상

    private bool isMovingToCenter = false;
    private Vector2 dragStartPos;
    private bool isFadingOut = false;
    private bool isDragging = false;
    private bool isButtonClicked = false;

    // 추가: 클릭 가능 여부를 나타내는 변수
    private bool isButtonClickable = true;

    void Start()
    {
        rectTransform = GetComponent<RectTransform>();
        canvas = GetComponentInParent<Canvas>();
        buttonImage = GetComponent<Image>();
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        // 추가: 버튼이 클릭되었고 클릭 가능한 상태이면 투명도 조절
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

        if (!isMovingToCenter)
        {
            if (Vector2.Distance(rectTransform.anchoredPosition, Vector2.zero) < 50f / canvas.scaleFactor)
            {
                isMovingToCenter = true;

                if (isDragging)
                {
                    StartCoroutine(FadeOutButton());
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

    IEnumerator FadeOutButton()
    {
        if (isFadingOut)
        {
            yield break;
        }

        isFadingOut = true;

        float duration = 2f;
        float elapsedTime = 0f;
        Color startingColor = buttonImage.color;

        while (elapsedTime < duration)
        {
            buttonImage.color = Color.Lerp(startingColor, new Color(1, 1, 1, 0), elapsedTime / duration);
            elapsedTime += Time.deltaTime;
            yield return null;
        }

        // 추가: 클릭 불가능 상태로 변경
        isButtonClickable = false;

        isFadingOut = false;
    }

    IEnumerator MoveToOriginalPosition()
    {
        float duration = 1f;
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

        // 추가: 클릭 가능 상태로 변경
        isButtonClickable = true;
        buttonImage.color = new Color(1, 1, 1, 0);
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        // 추가: 클릭 가능한 상태이면서 중앙에 가까우면 클릭으로 처리
        isButtonClicked = isButtonClickable && Vector2.Distance(rectTransform.anchoredPosition, Vector2.zero) < 50f / canvas.scaleFactor;
    }
}
