using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blocks : MonoBehaviour
{
    public GameObject variablePanel;
    public GameObject printfPanel;

    public void OpenCreateVariablePanel()
    {
        variablePanel.SetActive(true);
    }

    public void OpenCreatePrintf()
    {
        printfPanel.SetActive(true);
    }

    public void CloseCreatePrintf()
    {
        printfPanel.SetActive(false);
    }
}
