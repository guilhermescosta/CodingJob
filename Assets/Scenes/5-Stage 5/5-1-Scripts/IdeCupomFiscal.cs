using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class IdeCupomFiscal : MonoBehaviour
{
    public InputField varFor;
    int err1;
 

 //   public InputField varDefault;
 //   int err3;

    public Text erros;
    public GameObject telaFinal;

    public void CreateText()
    {
        string path = Application.dataPath + "/resultado.txt";
        if (!File.Exists(path))
        {
            File.WriteAllText(path, "\nFase 5-1 erro1: " + err1);
        }
        else
        {
            string content = "\nFase 5-1" +" erro1: " + err1;
            File.AppendAllText(path, content);
        }
    }


    public void PlayButton()
    {
        // Debug.Log(string.Compare(var1.text, "validaSenha"));
        
        if (string.Compare(varFor.text.Replace(" ", ""), "for(inti=0;i<=vendasHoje;i++)") != 0)
        {
            erros.text = "erro na linha 1, comando for";
            err1++;


        }

        if (string.Compare(varFor.text.Replace(" ", ""), "for(inti=0;i<=vendasHoje;i++)") != 0 )
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
