using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Rendering.PostProcessing;
using UnityEngine.UI;

public class ButtonHoverText : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerClickHandler
{
    public TextMeshProUGUI hoverText; // Text 컴포넌트
    public GameObject hoverObject; // 나타날 게임 오브젝트

    private bool isClicked = false; // 클릭 여부를 확인하기 위한 변수
    public string originalTextE; // 원래 텍스트를 저장하는 변수
    public string originalTextK; // 원래 텍스트를 저장하는 변수

    // 호버 시작 시 호출될 메서드
    public void OnPointerEnter(PointerEventData eventData)
    {
        if (hoverText != null && !isClicked)
        {
            hoverText.gameObject.SetActive(true);

            if (DialogSystem.instance.Rang == 0)
            {
                hoverText.text = originalTextE; // 저장된 원래 텍스트 출력
            }
            else
            {
                hoverText.text = originalTextK; // 저장된 원래 텍스트 출력
            }
        }

        if (hoverObject != null)
        {
            hoverObject.SetActive(true);
        }
    }

    // 호버 종료 시 호출될 메서드
    public void OnPointerExit(PointerEventData eventData)
    {
        if (!isClicked) // 클릭 상태가 아닌 경우에만 실행
        {
            if (hoverText != null)
            {
                hoverText.gameObject.SetActive(false);
            }

            if (hoverObject != null)
            {
                hoverObject.SetActive(false);
            }
        }
    }

    // 클릭 시 호출될 메서드
    public void OnPointerClick(PointerEventData eventData)
    {
        isClicked = !isClicked; // 클릭 상태 변경

        if (hoverText != null && isClicked)
        {
            hoverText.gameObject.SetActive(false);
            hoverText.text = "";
        }

        if (hoverObject != null)
        {
            hoverObject.SetActive(false);
        }
    }
}
