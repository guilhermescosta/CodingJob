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

    public Text erros;
    public GameObject telaFinal;

    //    public GameObject commandIde;

    //  relatorio



    public void CreateText()
    {
        string path = Application.dataPath + "/resultado.txt";
        if (!File.Exists(path))
        {
            File.WriteAllText(path, "\nFase 4 erro1: " + err1 + " erro2: " + err2 + " erro3: " + err3);
        }
        else
        {
            string content = "\nFase 4 erro1: " + err1 + " erro2: " + err2 + " erro3: " + err3;
            File.AppendAllText(path, content);
        }
    }

    private void Start()
    {

    }

    public void CloseCommand()
    {
       // commandIde.SetActive(false);
    }

    public void PlayButton()
    {
        // Debug.Log(string.Compare(var1.text, "validaSenha"));
        

        // linha 2
        if (string.Compare(varDefault.text, "default:") != 0)
        {
            erros.text = "erro na linha 3, tratamento de valores fora dos previstos";
            err3++;
        }

        if (string.Compare(varCase.text, "case 4:") != 0)
        {
            erros.text = "erro na linha 2, comando case";
            err2++;
        }

        if (string.Compare(varSwitch.text, "switch(valor)") != 0)
        {
            //Debug.Log("erro");
            erros.text = "erro na linha 1, comando switch";
            err1++;
        }



        if (string.Compare(varSwitch.text, "switch(valor)") != 0 || string.Compare(varCase.text, "case 4:") != 0 || string.Compare(varDefault.text, "default:") != 0)
        {
            Debug.Log("erro");
        }

        else
        {
            Debug.Log("Tudo Ok");
            telaFinal.SetActive(true);
            CreateText();

        }

    }
}

