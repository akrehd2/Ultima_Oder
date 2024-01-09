using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ButtonHoverText2 : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public TextMeshProUGUI hoverText; // Text 컴포넌트
    public TextMeshProUGUI NameText; // Text 컴포넌트
    public Image image;
    public GameObject hoverObject; // 나타날 게임 오브젝트

    public string originalTextE; // 원래 텍스트를 저장하는 변수
    public string originalTextK; // 원래 텍스트를 저장하는 변수
    public string nameTextK; // 원래 텍스트를 저장하는 변수
    public Sprite sprite;


    private void Update()
    {
        hoverObject.transform.position = Input.mousePosition + new Vector3(0, -250, 0);

        image.gameObject.transform.position = new Vector3(190, 180, 0);

        if (Input.GetMouseButton(0))
        {
            hoverObject.SetActive(false);
        }
    }

    // 호버 시작 시 호출될 메서드
    public void OnPointerEnter(PointerEventData eventData)
    {
        if (!Input.GetMouseButton(0))
        {
            hoverObject.SetActive(true);
        }

        if (DialogSystem.instance.Rang == 0)
        {
            hoverText.text = originalTextE; // 저장된 원래 텍스트 출력
            image.sprite = sprite;
            NameText.text = gameObject.name;
        }
        else
        {
            hoverText.text = originalTextK; // 저장된 원래 텍스트 출력
            image.sprite = sprite;
            NameText.text = nameTextK;
        }

        hoverObject.GetComponent<RectTransform>().sizeDelta = new Vector2(350, 250 + hoverText.text.Length);
    }

    // 호버 종료 시 호출될 메서드
    public void OnPointerExit(PointerEventData eventData)
    {
        hoverObject.SetActive(false);
    }
}
