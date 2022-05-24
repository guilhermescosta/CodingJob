using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class IdeMainCaixa : MonoBehaviour
{
    public InputField varWhile;
    int err1;

    public Text erros;
    public GameObject telaFinal;


    public void CreateText()
    {
        string path = Application.dataPath + "/resultado.txt";
        if (!File.Exists(path))
        {
            File.WriteAllText(path, "\nFase 5-2 erro1: " + err1);
        }
        else
        {
            string content = "\nFase 5-2" + " erro1: " + err1 ;
            File.AppendAllText(path, content);
        }
    }


    public void PlayButton()
    {
        // Debug.Log(string.Compare(var1.text, "validaSenha"));

        if (string.Compare(varWhile.text.Replace(" ", ""), "while(codOperacao!=4)") != 0)
        {
            erros.text = "erro na linha 1, comando while";
            err1++;
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



