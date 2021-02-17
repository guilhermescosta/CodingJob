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

    

    //   public GameObject commandIde;

    public void CreateText()
    {
        string path = Application.dataPath + "/resultado.txt";
        if (!File.Exists(path))
        {
            File.WriteAllText(path, "Resultado \nFase 2 erro1: " + err1 + " erro2: " + err2);
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
            Debug.Log("erro");
            err1++;
        }
        else if (string.Compare(command1.text, "scanf(\"%s\",email);") != 0)
        {
            Debug.Log("erro 2");
            err2++;
        }


        else
        {
            Debug.Log("Tudo Ok");
            // commandIde.SetActive(true);
            CreateText();

        }

    }
}
