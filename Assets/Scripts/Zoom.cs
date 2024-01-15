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

    public bool Shaking;

    [SerializeField]
    private float m_roughness;      //거칠기 정도
    [SerializeField]
    private float m_magnitude;      //움직임 범위

    IEnumerator Shake(float duration)
    {
        float halfDuration = duration / 2;
        float elapsed = 0f;
        float tick = Random.Range(-10f, 10f);

        while (elapsed < duration)
        {
            elapsed += Time.deltaTime / halfDuration;

            tick += Time.deltaTime * m_roughness;
            transform.position = new Vector3(
                Mathf.PerlinNoise(tick, 0) - .5f,
                Mathf.PerlinNoise(0, tick) - .5f,
                0f) * m_magnitude * Mathf.PingPong(elapsed, halfDuration);

            yield return null;
        }
        transform.position = new Vector3(transform.position.x, transform.position.y, -10f);
    }

    private void Awake()
    {
        instance = this;
    }

    private void Update()
    {
        if (Shaking)
        {
            StartCoroutine(Shake(1f));
            Shaking = false;
        }

        if (timer >= 0.005f)
        {
            timer = 0;

            if (DialogSystem.instance.day != 8 && DialogSystem.instance.day != 9)
            {
                if (In && Printer.activeSelf == true)
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
