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

    public int Rang;

    public int day;

    public int Result;

    public bool[] MadePf;

    public List<int> Notelist = new List<int>() { 0, 0, 0, 0, 0, 0 };

    private string savedHash;

    private void Awake()
    {
        instance = this;
        LoadDay();
    }

    private void Update()
    {
        if (SceneManager.GetActiveScene().name == "GameScene")
        {
            for(int i = 0; i < Dialogs.Length;  i++)
            {
                if(day == i)
                {
                    Dialogs[i].SetActive(true);
                }
                else
                {
                    Dialogs[i].SetActive(false);
                }
            }
        }

        // day                      
        if (day != PlayerPrefs.GetInt("SavedDay", -1) || Result != PlayerPrefs.GetInt("SavedResult", -1))
        {
            SaveDay();
        }
    }

    public void OnNewButtonClicked()
    {
        day = 0;
        Result = 0;
        SaveDay();
        UpdateDialogs();
    }

    public void Korean()
    {
        Rang = 1;
    }

    public void English()
    {
        Rang = 0;
    }

    public void UpdateDialogs()
    {
        for (int i = 0; i < Dialogs.Length; i++)
        {
            if (day == i)
            {
                Dialogs[i].SetActive(true);
            }
            else
            {
                Dialogs[i].SetActive(false);
            }
        }
    }

    public void SaveDay()
    {
        PlayerPrefs.SetInt("SavedDay", day);
        PlayerPrefs.SetInt("SavedResult", Result);
        PlayerPrefs.Save();
        Debug.Log("Day and Result saved: " + day + ", " + Result);
           
        string filePath = PlayerPrefs.GetString("SavedDayFilePath", "Not available");
        Debug.Log("Day and Result saved to file at: " + filePath);
          
        CalculateAndSaveHash();
    }

    private void CalculateAndSaveHash()
    {
        string currentHash = Hash(day.ToString() + Result.ToString());

        if (savedHash != currentHash)
        {
            Debug.LogError("File has been tampered with!");
        }
        else
        {
            savedHash = currentHash;
            Debug.Log("Hash saved: " + savedHash);
        }
    }

    private void LoadDay()
    {
        if (PlayerPrefs.HasKey("SavedDay") && PlayerPrefs.HasKey("SavedResult"))
        {
            day = PlayerPrefs.GetInt("SavedDay");
            Result = PlayerPrefs.GetInt("SavedResult");
            Debug.Log("Day and Result loaded: " + day + ", " + Result);
        }
        else
        {
            Debug.Log("No saved day and result found. Using default values.");
        }
            
        PlayerPrefs.SetString("SavedDayFilePath", Application.persistentDataPath);
        PlayerPrefs.Save();
   
        savedHash = PlayerPrefs.GetString("SavedHash", "");
    }

    private string Hash(string input)
    {
        using (SHA256 sha256Hash = SHA256.Create())
        {
            byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < bytes.Length; i++)
            {
                builder.Append(bytes[i].ToString("x2"));
            }

            return builder.ToString();
        }
    }
}
