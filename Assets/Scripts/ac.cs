using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ac : MonoBehaviour
{
    public GameObject Printer;

    public GameObject[] Burron;

    private void Update()
    {
        if(Printer.activeSelf == true)
        {
            Burron[0].SetActive(false);
            Burron[1].SetActive(false);
            Burron[2].SetActive(false);
        }
        else
        {
            Burron[0].SetActive(true);
            Burron[1].SetActive(true);
            Burron[2].SetActive(true);
        }
    }
}
