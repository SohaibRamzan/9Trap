using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoldierHandler : MonoBehaviour
{

    public float resizeAmount = 1.2f;
    private bool isResized = false;
    public Vector2 originalSize;

    public void resizeTheButton(Button button)
    {

        RectTransform rectTransform = button.GetComponent<RectTransform>();
        originalSize = rectTransform.sizeDelta;
        if (rectTransform != null && !isResized)
        {
            // Increase the width and height of the object
            rectTransform.sizeDelta *= resizeAmount;
            isResized = true;
        }
        else if(isResized == true)
        {
            rectTransform.sizeDelta /= resizeAmount;
            isResized = false;
        }
    }

}
