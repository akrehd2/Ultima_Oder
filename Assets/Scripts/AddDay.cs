using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddDay : MonoBehaviour
{
    public void AddDay1()
    {
        DialogSystem.instance.day += 1;
    }

    public void CheakScore() 
    {
        if(DragImage.totalScore >= 16)
        {
            DialogSystem.instance.Result = 0;
        }
        else if (DragImage.totalScore >= 1)
        {
            DialogSystem.instance.Result = 1;
        }
        else
        {
            DialogSystem.instance.Result = 2;
        }
        
    }
}
