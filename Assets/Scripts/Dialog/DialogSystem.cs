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

    public int Rang; // ��� 0�̸� ����, 1�̸� �ѱ���

    public int day; // ���� ��¥

    public int Result;

    private string savedHash; // ����� �ؽð�

    private void Awake()
    {
        instance = this;
        LoadDay(); // ���� ���� �� ����� day ���� �ҷ���
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

        // day ���� ���� ������ ����
        if (day != PlayerPrefs.GetInt("SavedDay", -1))
        {
            SaveDay();
        }
    }

    public void OnNewButtonClicked()
    {
        day = 0;  // ��¥�� 0���� ���� (Ư�� ��ư�� ������ �� ��¥�� 0���� ����)
        SaveDay(); // ����� day ���� ����
        UpdateDialogs(); // ���̾�α� ������Ʈ
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
        // �ٸ� ��¥�� ���� ���̾�α� ������Ʈ ���� �߰�
    }

    public void SaveDay()
    {
        PlayerPrefs.SetInt("SavedDay", day);
        PlayerPrefs.Save();
        Debug.Log("Day saved: " + day);

        // ���� ���� ��� ���
        string filePath = PlayerPrefs.GetString("SavedDayFilePath", "Not available");
        Debug.Log("Day saved to file at: " + filePath);

        // �ؽ� ��� �� ����
        CalculateAndSaveHash();
    }

    private void CalculateAndSaveHash()
    {
        // �ؽ� ���
        string currentHash = Hash(day.ToString());

        // ����� �ؽÿ� ���� �ؽ� ��
        if (savedHash != currentHash)
        {
            // �ؽð��� �ٸ��� ������ �־��ٰ� �Ǵ�
            Debug.LogError("File has been tampered with!");
        }
        else
        {
            // �ؽð��� ������ ������ �����̹Ƿ� ���� �ؽø� ����
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

        // ���� ���� ��� ����
        PlayerPrefs.SetString("SavedDayFilePath", Application.persistentDataPath);
        PlayerPrefs.Save();

        // ����� �ؽ� �ҷ�����
        savedHash = PlayerPrefs.GetString("SavedHash", "");
    }

    private string Hash(string input)
    {
        using (SHA256 sha256Hash = SHA256.Create())
        {
            // ���ڿ��� ����Ʈ �迭�� ��ȯ
            byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            // ����Ʈ �迭�� 16���� ���ڿ��� ��ȯ
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < bytes.Length; i++)
            {
                builder.Append(bytes[i].ToString("x2"));
            }

            return builder.ToString();
        }
    }
}
