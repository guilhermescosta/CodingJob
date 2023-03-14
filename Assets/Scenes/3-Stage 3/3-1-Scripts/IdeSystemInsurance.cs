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

    public Text erros;
    public GameObject telaFinal;

    //   public GameObject commandIde;

    //marcadores

    public GameObject marcadorErros1;
    public Text marcadorErrosText1;

    public GameObject marcadorErros2;
    public Text marcadorErrosText2;

    public GameObject marcadorErros3;
    public Text marcadorErrosText3;


    public void CreateText()
    {
        string path = Application.dataPath + "/resultado.txt";
        if (!File.Exists(path))
        {
            File.WriteAllText(path, "\nFase 3 erro1: " + err1 + " erro2: " + err2 + " erro3: " + err3);
        }
        else
        {
            string content = "\nFase 3 erro1: " + err1 + " erro2: " + err2 + " erro3: " + err3;
            File.AppendAllText(path, content);
        }

    }

    public void PlayButton()
    {

        marcadorErros1.SetActive(false);
        marcadorErrosText1.text = "";
        marcadorErros2.SetActive(false);
        marcadorErrosText2.text = "";
        marcadorErros3.SetActive(false);
        marcadorErrosText3.text = "";


        if (string.Compare(var1.text.Replace(" ", ""), "(idade>=18&&idade<30)") != 0)
        {
            err1++;
            marcadorErros1.SetActive(true);
            marcadorErrosText1.text += "-a condição IF esta incorreta";
        }



        if (string.Compare(command1.text, "else if") != 0)
        {
            err2++;
            marcadorErros2.SetActive(true);
            marcadorErrosText2.text += "-erro na expressão condicional";
        }

        if (string.Compare(var2.text.Replace(" ", ""), "if(strcmp(doencaCronica,\"s\"))") != 0)
        {
            err3++;
            marcadorErros3.SetActive(true);
            marcadorErrosText3.text += "-erro na expressão condicional + condição da expressão";
        }





        /*

        if (string.Compare(command1.text, "else if") != 0)
        {
            erros.text = "erro na linha 2, expressão condicional";
            err2++;
        }

        if (string.Compare(var1.text.Replace(" ", ""), "(idade>=18&&idade<30)") != 0)
        {
            erros.text = "erro na linha 1, condição If ";
            err1++;
        }
        */


        if (string.Compare(var1.text.Replace(" ",""), "(idade>=18&&idade<30)") != 0 || string.Compare(command1.text, "else if") != 0 || string.Compare(var2.text.Replace(" ", ""), "if(strcmp(doencaCronica,\"s\"))") != 0)
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
