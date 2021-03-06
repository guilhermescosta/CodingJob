using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class IdeCadastroFornecedor : MonoBehaviour
{
    public InputField var1;
    int err1;

    public InputField command1;
    int err2;

    public Text erros;
    public GameObject panelFim;
    

    //   public GameObject commandIde;

    public void CreateText()
    {
        string path = Application.dataPath + "/resultado.txt";
        if (!File.Exists(path))
        {
            File.WriteAllText(path, "\nFase 2 erro1: " + err1 + " erro2: " + err2);
        }
        else
        {
            string content = "\nFase 2 erro1: " + err1 + " erro2: " + err2;
            File.AppendAllText(path, content);
        }

    }

  

    public void PlayButton()
    {
        if (string.Compare(var1.text, "scanf(\"%d\",&cnpj);") != 0)
        {
            erros.text = "erro na linha 1 / scanf CNPJ";
            err1++;
        }
        if (string.Compare(command1.text, "scanf(\"%s\",email);") != 0)
        {
            erros.text = "erro na linha 2 / scanf email";
            err2++;
        }


        else
        {
            panelFim.SetActive(true);
            CreateText();
        }
    }
}
