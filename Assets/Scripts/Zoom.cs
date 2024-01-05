using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zoom : MonoBehaviour
{
    public static Zoom instance;
    public GameObject Charic;
    public GameObject Printer;

    public bool In;
    public bool Out;

    float timer = 0;

    private void Awake()
    {
        instance = this;
    }

    private void Update()
    {
        if (timer >= 0.005f)
        {
            timer = 0;

            if(In && Printer.activeSelf == true)
            {
                if (Camera.main.orthographicSize > 3)
                {
                    Camera.main.orthographicSize -= 0.1f;

                    if (Charic.transform.localScale.x < 1.67f)
                    {
                        Charic.transform.localScale += new Vector3(0.033f, 0.033f, 0.033f);
                    }
                    else
                    {
                        Charic.transform.localScale = new Vector3(1.67f, 1.67f, 1.67f);
                    }

                    Charic.transform.position += new Vector3(0, -0.606f, 0);
                }
                else
                {
                    Camera.main.orthographicSize = 3;
                    In = false;
                }
                
            }

            if (Out && Printer.activeSelf == false)
            {
                if (Camera.main.orthographicSize < 5)
                {
                    Camera.main.orthographicSize += 0.1f;

                    if (Charic.transform.localScale.x > 1)
                    {
                        Charic.transform.localScale -= new Vector3(0.033f, 0.033f, 0.033f);
                    }
                    else
                    {
                        Charic.transform.localScale = Vector3.one;
                    }

                    Charic.transform.position += new Vector3(0, 0.606f, 0);
                }
                else
                {
                    Out = false;
                }
            }
        }
        else if(In || Out)
        {
            timer += Time.deltaTime;
        }
        else
        {
            timer = 0;
        }
    }

    public void ZoomIn()
    {
        In = true; Out = false;
    }

    public void ZoomOut()
    {
        In = false; Out = true;
    }
}
