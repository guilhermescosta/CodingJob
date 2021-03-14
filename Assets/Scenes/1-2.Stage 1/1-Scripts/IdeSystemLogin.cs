using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class IdeSystemLogin : MonoBehaviour
{
    public InputField var1;
    int err1;

    public InputField command1;
    int err2;

    public InputField var2;
    int err3;

    public InputField var3;
    int err4;

    public InputField var4;
    int err5;

    public GameObject commandIde;

    //  relatorio
    public Text erros;
    

    public void CreateText()
    {
        string path = Application.dataPath + "/resultado.txt";
        if (!File.Exists(path))
        {
            File.WriteAllText(path, "\nFase 1 erro1: " + err1 + " erro2: " + err2 + " erro3: " + err3 + " erro4: " + err4 + " erro5: " + err5);
        }
        else
        {
            string content = "\nFase 1 erro1: " + err1 + " erro2: " + err2 + " erro3: " + err3 + " erro4: " + err4 + " erro5: " + err5;
            File.AppendAllText(path, content);
        }
    }

    private void Start()
    {
      
    }

    public void CloseCommand()
    {
        commandIde.SetActive(false);
    }

    public void PlayButton()
    {
        // Debug.Log(string.Compare(var1.text, "validaSenha"));
        if (string.Compare(var1.text, "validaSenha") != 0)
        {
            err1++;
            erros.text = "Erro no primeiro campo da linha 1 ";
        }
         if (string.Compare(command1.text, "strcmp(senha,pass);") != 0)
        {
            err2++;
            erros.text = "Erro no segundo campo da linha 2 "; 
        }

        // linha 2
         if (string.Compare(var2.text, "validou") != 0)
        {
            err3++;
            erros.text = "Erro no primeiro campo da linha 2 ";
        }

        if (string.Compare(var3.text, "validaUsuario") != 0)
        {
            err4++;
            erros.text = "Erro no segundo campo da linha 2 ";
        }

        if (string.Compare(var4.text, "validaSenha;") != 0)
        {
            err5++;
            erros.text = "Erro no terceiro campo da linha 2 ";
        }


        if (string.Compare(var1.text, "validaSenha") != 0 || string.Compare(command1.text, "strcmp(senha,pass);") != 0  || string.Compare(var2.text, "validou") != 0 || string.Compare(var3.text, "validaUsuario") != 0  || string.Compare(var4.text, "validaSenha;") != 0) {
            Debug.Log("erro");
        }
        else
        {
            //  Debug.Log("Tudo Ok");
            erros.text += "Arquivo compilado com sucesso ";
            commandIde.SetActive(true);
            CreateText();

        }

    }
}
