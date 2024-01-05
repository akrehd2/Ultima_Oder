using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveFalse : MonoBehaviour
{
    private void OnEnable()
    {
        Zoom.instance.ZoomIn();
    }
    private void OnDisable()
    {
        Zoom.instance.ZoomOut();
    }
}
