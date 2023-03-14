using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using UnityEngine.SceneManagement;

public class IdeParcelamento : MonoBehaviour
{
    public InputField var1;
    int err1;

    public InputField var2;
    int err2;

    public InputField var3;
    int err3;

    public Text erros;

    public GameObject telaFinal;

    public GameData gameData;


    // marcadores

    public GameObject marcadorErros1;
    public Text marcadorErrosText1;

    public GameObject marcadorErros2;
    public Text marcadorErrosText2;

    public GameObject marcadorErros3;
    public Text marcadorErrosText3;




    private void Awake()
    {
        gameData = GameObject.Find("GameData").GetComponent<GameData>();
        gameData.thisStage = 3;
    }

    public void CreateText()
    {
        string path = Application.dataPath + "/resultado.txt";
        if (!File.Exists(path))
        {
            File.WriteAllText(path, "\nFase 2-2 erro1: " + err1 + " erro2: " + err2 + " erro3: " + err3);
        }
        else
        {
            string content = "\nFase 2-2 erro1: " + err1 + " erro2: " + err2 + " erro3: " + err3;
            File.AppendAllText(path, content);
        }
    }

    public void Continuar()
    {
        SceneManager.LoadScene(5);
    }

    public void PlayButton()
    {

        marcadorErros1.SetActive(false);
        marcadorErrosText1.text = "";
        marcadorErros2.SetActive(false);
        marcadorErrosText2.text = "";
        marcadorErros3.SetActive(false);
        marcadorErrosText3.text = "";



        if (string.Compare(var1.text, "cod_pagamento==1") != 0)
        {
            err1++;
            marcadorErros1.SetActive(true);
            marcadorErrosText1.text += "-Erro na linha pagamento cartão de crédito";
        }


        if (!var2.text.EndsWith(";"))
        {
            err2++;
            marcadorErros2.SetActive(true);
            marcadorErrosText2.text = "-falta o ponto e vírgula final\n";
        }
        else if (string.Compare(var2.text, "valor=valor/parcelas;") != 0)
        {
            err2++;
            marcadorErros2.SetActive(true);
            marcadorErrosText2.text += "-Erro na linha pagamento cartão de crédito";
        }


        if (string.Compare(var3.text, "cod_pagamento==2||cod_pagamento==3") != 0)
        {
            err3++;
            marcadorErros3.SetActive(true);
            marcadorErrosText3.text += "-Erro na linha pagamento por pix ou cartão débito";
        }

   

        if (string.Compare(var1.text.Replace(" ", ""), "cod_pagamento==1") != 0 || string.Compare(var2.text.Replace(" ", ""), "valor=valor/parcelas;") != 0 || string.Compare(var3.text.Replace(" ", ""), "cod_pagamento==2||cod_pagamento==3") != 0)
        {
            Debug.Log("erro");
        }
        else
        {
            //  Debug.Log("Tudo Ok");
            erros.text = "Arquivo compilado com sucesso ";
            // commandIde.SetActive(true);
            CreateText();
            telaFinal.SetActive(true);

        }
    }
}






