using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CreateVariable : MonoBehaviour
{
    public InputField inputName;
    public Dropdown dropData;

    public GameObject var;         // asset da variavel

    public GameObject variablePanel;
    string variableDesc;


    public void NewVariable()
    {
        var = Instantiate(var, new Vector3(-2.8f, 4, 0), Quaternion.Euler(0, 0, 0));
        var.GetComponent<Variable>().variableName = inputName.text;
        var.GetComponent<Variable>().variableData = dropData.value.ToString();

       
        if (dropData.value == 0) variableDesc = "Int";
        else if (dropData.value == 1) variableDesc = "Char";
        else if (dropData.value == 2) variableDesc = "Float";

        var.transform.GetChild(0).GetComponent<TextMesh>().text = variableDesc + " " + inputName.text;

    }

    public void CloseCreateVariablePanel()
    {
        variablePanel.SetActive(false);
    }
}
