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
        marcadorErros1.SetActive(false);
        marcadorErrosText1.text = "";
        marcadorErros2.SetActive(false);
        marcadorErrosText2.text = "";
        marcadorErros3.SetActive(false);
        marcadorErrosText3.text = "";


        if (string.Compare(varSwitch.text, "switch(valor)") != 0)
        {
            err1++;
            marcadorErros1.SetActive(true);
            marcadorErrosText1.text += "-o comando Switch esta incorreto";
        }

        if (string.Compare(varCase.text, "case 4:") != 0)
        {
            err2++;
            marcadorErros2.SetActive(true);
            marcadorErrosText2.text += "-o comando Case esta incorreto";
        }


        if (string.Compare(varDefault.text, "default:") != 0)
        {
            err3++;
            marcadorErros3.SetActive(true);
            marcadorErrosText3.text += "-o comando Default esta incorreto";
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

