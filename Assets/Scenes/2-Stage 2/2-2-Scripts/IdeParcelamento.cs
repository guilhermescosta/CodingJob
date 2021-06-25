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
        SceneManager.LoadScene(10);
    }

    public void PlayButton()
    {
        if (string.Compare(var3.text, "cod_pagamento==2||cod_pagamento==3") != 0)
        {
            err3++;
            erros.text = "Erro na linha pagamento por pix ou cartão débito";
        }

        if (string.Compare(var2.text, "valor=valor/parcelas;") != 0)
        {
            err2++;
            erros.text = "Erro na linha valor das parcelas ";
        }

        if (string.Compare(var1.text, "cod_pagamento==1") != 0)
        {
            err1++;
            erros.text = "Erro na linha pagamento cartão de crédito  ";
        }

        if (string.Compare(var1.text, "cod_pagamento==1") != 0 || string.Compare(var2.text, "valor=valor/parcelas;") != 0 || string.Compare(var3.text, "cod_pagamento==2||cod_pagamento==3") != 0)
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






