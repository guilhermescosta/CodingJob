using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Stdio : MonoBehaviour
{
    public string textValue;

    public Text blockText;
    bool isActive;

    private void OnMouseDown()
    {
        isActive = true;
    }

    public void OnMouseExit()
    {
        isActive = false;
    }

    private void Update()
    {
        if (isActive == true)
        {
            blockText.text = textValue;
        }
    }

    public void Printf(string text)
    {        
        string result = text;   
    }

    public void Scanf()
    {

    }

}
