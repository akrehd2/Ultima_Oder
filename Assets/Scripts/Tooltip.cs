using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Tooltip : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public string tooltipText = "이미지 도움말"; // 원하는 도움말 텍스트로 변경

    private GameObject tooltipObject;
    private Text tooltipTextObject;

    void Start()
    {
        // 툴팁을 생성하고 비활성화합니다.
        tooltipObject = new GameObject("Tooltip");
        tooltipObject.transform.SetParent(transform, false);
        tooltipObject.SetActive(false);

        // 텍스트 오브젝트 생성 및 설정
        tooltipTextObject = tooltipObject.AddComponent<Text>();
        tooltipTextObject.font = Resources.GetBuiltinResource<Font>("Arial.ttf");
        tooltipTextObject.fontSize = 14;
        tooltipTextObject.color = Color.white;

        // 툴팁 배경 설정
        Image bgImage = tooltipObject.AddComponent<Image>();
        bgImage.color = new Color(0, 0, 0, 0.7f);

        // 툴팁 크기 및 위치 설정
        RectTransform tooltipRect = tooltipObject.GetComponent<RectTransform>();
        tooltipRect.sizeDelta = new Vector2(200, 60);
        tooltipRect.pivot = new Vector2(0.5f, 1f);
    }

    void Update()
    {
        // 마우스 우클릭을 누르면 툴팁을 표시합니다.
        if (Input.GetMouseButtonDown(1))
        {
            tooltipObject.SetActive(true);
            SetTooltipPosition();
        }
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        // 마우스가 이미지 위에 올라가면 툴팁 표시
        tooltipObject.SetActive(true);
        SetTooltipPosition();
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        // 마우스가 이미지에서 벗어나면 툴팁 비활성화
        tooltipObject.SetActive(false);
    }

    private void SetTooltipPosition()
    {
        // 툴팁의 위치를 이미지 아래로 설정
        RectTransform imageRect = GetComponent<RectTransform>();
        RectTransform tooltipRect = tooltipObject.GetComponent<RectTransform>();

        Vector3[] corners = new Vector3[4];
        imageRect.GetWorldCorners(corners);

        float tooltipX = corners[0].x + imageRect.sizeDelta.x / 2f;
        float tooltipY = corners[0].y;

        tooltipRect.position = new Vector3(tooltipX, tooltipY, 0);
    }
}
