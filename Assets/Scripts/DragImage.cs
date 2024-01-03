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

    // 추가: 버튼이 중앙으로 이동 중인지 여부
    private bool isMovingToCenter = false;

    // 추가: 드래그 시작 위치 저장
    private Vector2 dragStartPos;

    // 추가: FadeOutButton 코루틴이 이미 실행 중이라면 중단할 플래그
    private bool isFadingOut = false;

    // 추가: 드래그 중인지 여부를 체크하는 플래그
    private bool isDragging = false;

    // 추가: 버튼이 클릭되었는지 여부를 체크하는 플래그
    private bool isButtonClicked = false;

    void Start()
    {
        rectTransform = GetComponent<RectTransform>();
        canvas = GetComponentInParent<Canvas>();
        buttonImage = GetComponent<Image>();
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        // 추가: 버튼이 클릭되었고 중앙으로 이동 중이 아니면 투명도 조절
        if (!isMovingToCenter && isButtonClicked)
        {
            StartCoroutine(FadeOutButton());
        }

        // 추가: 드래그 시작 시 위치 저장
        dragStartPos = rectTransform.anchoredPosition;

        // 추가: 드래그 중임을 표시
        isDragging = true;
    }

    public void OnDrag(PointerEventData eventData)
    {
        // 드래그 중일 때 호출되는 메서드
        rectTransform.anchoredPosition += eventData.delta / canvas.scaleFactor;

        // 추가: 버튼이 중앙으로 이동하고 있는 동안은 투명도 조절하지 않음
        if (!isMovingToCenter)
        {
            // 추가: 버튼이 중앙에 도달하면 투명도를 0으로 설정
            if (Vector2.Distance(rectTransform.anchoredPosition, Vector2.zero) < 50f)
            {
                isMovingToCenter = true;

                // 추가: 드래그 중인 경우에만 FadeOutButton 코루틴 시작
                if (isDragging)
                {
                    StartCoroutine(FadeOutButton());
                }
            }
        }
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        // 드래그가 종료될 때 호출되는 메서드
        // 추가: 드래그가 끝났을 때 중앙 이동 중이라면 중단
        if (isMovingToCenter)
        {
            StopAllCoroutines();
            StartCoroutine(FlickerButton()); // 추가: 버튼 테두리 반짝이기
        }
        else
        {
            StartCoroutine(MoveToOriginalPosition()); // 추가: 중앙으로 이동하지 않았을 경우 원래 위치로 이동
        }

        // 추가: 드래그 종료 시 드래그 중인 플래그 해제
        isDragging = false;
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

        float duration = 2f; // 투명해지는 데 걸리는 시간 (초)
        float elapsedTime = 0f;
        Color startingColor = buttonImage.color;

        while (elapsedTime < duration)
        {
            buttonImage.color = Color.Lerp(startingColor, new Color(1, 1, 1, 0), elapsedTime / duration);
            elapsedTime += Time.deltaTime;
            yield return null;
        }

        // 버튼을 비활성화하거나 삭제하는 코드를 추가할 수 있습니다.
        // 예를 들어:
        // gameObject.SetActive(false);
        // 또는
        // Destroy(gameObject);

        isFadingOut = false; // 추가: 코루틴 종료 후 플래그 초기화
    }

    // 추가: 버튼을 원래 위치로 천천히 이동하는 코루틴
    IEnumerator MoveToOriginalPosition()
    {
        float duration = 1f; // 이동하는 데 걸리는 시간 (초)
        float elapsedTime = 0f;

        while (elapsedTime < duration)
        {
            rectTransform.anchoredPosition = Vector2.Lerp(rectTransform.anchoredPosition, dragStartPos, elapsedTime / duration);
            elapsedTime += Time.deltaTime;
            yield return null;
        }

        // 최초의 상태로 돌아간 후 추가 작업을 할 수 있습니다.
    }

    // 추가: 버튼 테두리가 두 번정도 반짝이는 효과를 구현하는 코루틴
    IEnumerator FlickerButton()
    {
        for (int i = 0; i < 2; i++)
        {
            buttonImage.color = new Color(1, 1, 1, 1); // 밝게
            yield return new WaitForSeconds(0.1f);
            buttonImage.color = originalBackgroundColor; // 어두워짐
            yield return new WaitForSeconds(0.1f);
        }

        buttonImage.color = new Color(1, 1, 1, 0); // 투명하게
    }

    // 추가: 버튼 클릭 시 호출되는 메서드
    public void OnPointerDown(PointerEventData eventData)
    {
        // 추가: 버튼이 클릭되었음을 표시
        isButtonClicked = Vector2.Distance(rectTransform.anchoredPosition, Vector2.zero) < 50f; // 중앙에 가까울 때만 클릭으로 처리
    }
}
