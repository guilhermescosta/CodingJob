using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class IdeMenuPrincipal : MonoBehaviour
{
    public InputField varSwitch;
    int err1;
    public InputField varCase;
    int err2;

    public InputField varDefault;
    int err3;

    public InputField var3;
    int err4;

    public InputField var4;
    int err5;

//    public GameObject commandIde;

    //  relatorio



    public void CreateText()
    {
        string path = Application.dataPath + "/resultado.txt";
        if (!File.Exists(path))
        {
            File.WriteAllText(path, "Resultado \nFase 4 erro1: " + err1 + " erro2: " + err2 + " erro3: " + err3);
        }
        else
        {
            string content = "Resultado \nFase 1 erro4: " + err1 + " erro2: " + err2 + " erro3: " + err3;
            File.AppendAllText(path, content);
        }
    }

    private void Start()
    {
        CreateText();
    }

    public void CloseCommand()
    {
       // commandIde.SetActive(false);
    }

    public void PlayButton()
    {
        // Debug.Log(string.Compare(var1.text, "validaSenha"));
        if (string.Compare(varSwitch.text, "switch(valor)") != 0)
        {
            Debug.Log("erro");
            err1++;
        }
        else if (string.Compare(varCase.text, "case" + " "+ "4 :" ) != 0)
        {
            Debug.Log("erro 2");
            err2++;
        }

        // linha 2
        else if (string.Compare(varDefault.text, "default:") != 0)
        {
            Debug.Log("erro 3");
            err3++;
        }


        else
        {
            Debug.Log("Tudo Ok");
          //  commandIde.SetActive(true);
            CreateText();

        }

    }
}

