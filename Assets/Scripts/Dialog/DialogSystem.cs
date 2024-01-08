using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using UnityEngine.SceneManagement;

public class DialogSystem : MonoBehaviour
{
    public static DialogSystem instance;

    public GameObject[] Dialogs;

    public int Rang; // 언어 0이면 영어, 1이면 한국어

    public int day; // 현재 날짜

    public int Result;

    private string savedHash; // 저장된 해시값

    private void Awake()
    {
        instance = this;
        LoadDay(); // 게임 시작 시 저장된 day 값을 불러옴
    }

    private void Update()
    {
        if (SceneManager.GetActiveScene().name == "GameScene")
        {
            if (day == 0)
            {
                Dialogs[0].SetActive(true);
                Dialogs[1].SetActive(false);
            }
            else if (day == 1)
            {
                Dialogs[0].SetActive(false);
                Dialogs[1].SetActive(true);
            }
        }

        // day 값이 변할 때마다 저장
        if (day != PlayerPrefs.GetInt("SavedDay", -1))
        {
            SaveDay();
        }
    }

    public void OnNewButtonClicked()
    {
        day = 0;  // 날짜를 0으로 설정 (특정 버튼을 눌렀을 때 날짜를 0으로 변경)
        SaveDay(); // 변경된 day 값을 저장
        UpdateDialogs(); // 다이얼로그 업데이트
    }

    public void Korean()
    {
        Rang = 1;
    }

    public void English()
    {
        Rang = 0;
    }

    private void UpdateDialogs()
    {
        if (day == 0)
        {
            Dialogs[0].SetActive(true);
            Dialogs[1].SetActive(false);
        }
        else if (day == 1)
        {
            Dialogs[0].SetActive(false);
            Dialogs[1].SetActive(true);
        }
        // 다른 날짜에 대한 다이얼로그 업데이트 로직 추가
    }

    public void SaveDay()
    {
        PlayerPrefs.SetInt("SavedDay", day);
        PlayerPrefs.Save();
        Debug.Log("Day saved: " + day);

        // 파일 저장 경로 출력
        string filePath = PlayerPrefs.GetString("SavedDayFilePath", "Not available");
        Debug.Log("Day saved to file at: " + filePath);

        // 해시 계산 및 저장
        CalculateAndSaveHash();
    }

    private void CalculateAndSaveHash()
    {
        // 해시 계산
        string currentHash = Hash(day.ToString());

        // 저장된 해시와 현재 해시 비교
        if (savedHash != currentHash)
        {
            // 해시값이 다르면 변조가 있었다고 판단
            Debug.LogError("File has been tampered with!");
        }
        else
        {
            // 해시값이 같으면 파일이 정상이므로 현재 해시를 저장
            savedHash = currentHash;
            Debug.Log("Hash saved: " + savedHash);
        }
    }

    private void LoadDay()
    {
        if (PlayerPrefs.HasKey("SavedDay"))
        {
            day = PlayerPrefs.GetInt("SavedDay");
            Debug.Log("Day loaded: " + day);
        }
        else
        {
            Debug.Log("No saved day found. Using default value.");
        }

        // 파일 저장 경로 저장
        PlayerPrefs.SetString("SavedDayFilePath", Application.persistentDataPath);
        PlayerPrefs.Save();

        // 저장된 해시 불러오기
        savedHash = PlayerPrefs.GetString("SavedHash", "");
    }

    private string Hash(string input)
    {
        using (SHA256 sha256Hash = SHA256.Create())
        {
            // 문자열을 바이트 배열로 변환
            byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            // 바이트 배열을 16진수 문자열로 변환
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < bytes.Length; i++)
            {
                builder.Append(bytes[i].ToString("x2"));
            }

            return builder.ToString();
        }
    }
}
