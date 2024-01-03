using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DragImage : MonoBehaviour, IDragHandler, IBeginDragHandler, IEndDragHandler
{
    private RectTransform rectTransform;
    private Canvas canvas;
    private Image backgroundImage;
    private Color originalBackgroundColor = new Color(0, 0, 0, 0.5f); // 어두운 배경 색상

    void Start()
    {
        rectTransform = GetComponent<RectTransform>();
        canvas = GetComponentInParent<Canvas>();

        // 어두운 배경을 표시할 Image 컴포넌트 찾기
        Transform parentTransform = transform.parent;
        if (parentTransform != null)
        {
            Transform imageTransform = parentTransform.Find("Image");
            if (imageTransform != null)
            {
                backgroundImage = imageTransform.GetComponent<Image>();

                // 배경 초기 색상 저장
                originalBackgroundColor = backgroundImage.color;
            }
            else
            {
                Debug.LogError("Image not found under parent!");
            }
        }
        else
        {
            Debug.LogError("Parent transform not found!");
        }
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        // 드래그가 시작될 때 호출되는 메서드
        if (backgroundImage != null)
        {
            backgroundImage.color = originalBackgroundColor; // 배경 어두워짐
        }
    }

    public void OnDrag(PointerEventData eventData)
    {
        // 드래그 중일 때 호출되는 메서드
        rectTransform.anchoredPosition += eventData.delta / canvas.scaleFactor;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        // 드래그가 종료될 때 호출되는 메서드
        if (backgroundImage != null)
        {
            backgroundImage.color = Color.clear; // 배경 투명하게
        }
    }
}
