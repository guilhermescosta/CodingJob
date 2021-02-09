using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class IdeSystemInsurance : MonoBehaviour
{
    public InputField var1;
    int err1;
    public InputField command1;
    int err2;

    public InputField var2;
    int err3;

 //   public GameObject commandIde;

    public void CreateText()
    {
        string path = Application.dataPath + "/resultado.txt";
        if (!File.Exists(path))
        {
            File.WriteAllText(path, "Resultado \nFase 2 erro1: " + err1 + " erro2: " + err2 + " erro3: " + err3);
        }
        else
        {
            string content = "\nFase 2 erro1: " + err1 + " erro2: " + err2 + " erro3: " + err3;
            File.AppendAllText(path, content);
        }

    }

    public void PlayButton()
    {
        // Debug.Log(string.Compare(var1.text, "validaSenha"));
        if (string.Compare(var1.text, "(idade>=18&&idade<30)") != 0)
        {
            Debug.Log("erro");
            err1++;
        }
        else if (string.Compare(command1.text, "else if") != 0)
        {
            Debug.Log("erro 2");
            err2++;
        }

        // linha 2
        else if (string.Compare(var2.text, "if(strcmp(doencaCronica,\"s\"")==0)
        {
            Debug.Log("erro 3");
            err3++;
        }

       

        else
        {
            Debug.Log("Tudo Ok");
           // commandIde.SetActive(true);
            CreateText();

        }

    }
}
