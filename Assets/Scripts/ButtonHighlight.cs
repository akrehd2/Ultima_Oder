using UnityEngine;
using UnityEngine.UI;

public class ButtonHighlight : MonoBehaviour
{
    int Citruss = 0;
    // 이미지를 직접 할당하는 방법
    public Image imageToHighlight;

    // 할당할 이미지를 Inspector에서 설정하고 싶다면 주석 처리된 코드를 사용하세요
    // public Image imageToHighlight;

    void Start()
    {
        // 이미지를 Inspector에서 설정하지 않았다면 코드로 할당하는 방법
        if (imageToHighlight == null)
        {
            // 예시: 현재 스크립트가 연결된 GameObject에서 Image 컴포넌트 찾기
            imageToHighlight = GetComponent<Image>();
        }

        if (imageToHighlight != null)
        {
            // 버튼에 클릭 이벤트 연결
            Button button = GetComponent<Button>();
            button.onClick.AddListener(HighlightImage);
        }
        else
        {
            Debug.LogError("Image To Highlight is not assigned or not found on the GameObject!");
        }
    }

    public void HighlightImage()
    {
        Citruss ++;
        // imageToHighlight = 
        // 이미지 색상 변경 (강조)
        imageToHighlight.color = Color.yellow;

        // 몇 초 후에 원래 색상으로 돌아가도록 Invoke 사용
        Invoke("ResetImageColor", 1f);
        print(Citruss);
    }

    void ResetImageColor()
    {
        // 이미지 색상 원래대로 변경
        imageToHighlight.color = Color.white;
    }
}
