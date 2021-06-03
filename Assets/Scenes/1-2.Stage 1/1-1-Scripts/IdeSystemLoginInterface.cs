using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using UnityEngine.SceneManagement;

public class IdeSystemLoginInterface : MonoBehaviour
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
            File.WriteAllText(path, "\nFase 1-1 erro1: " + err1 + " erro2: " + err2 + " erro3: " + err3);
        }
        else
        {
            string content = "\nFase 1-1 erro1: " + err1 + " erro2: " + err2 + " erro3: " + err3;
            File.AppendAllText(path, content);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void Continuar()
    {
        SceneManager.LoadScene(9);
    }

    public void PlayButton()
    {
        if (string.Compare(var3.text, "printf(\"\\n\\tSenha;\")") != 0)
        {
            err3++;
            erros.text = "Erro na linha senha ";
        }

        if (string.Compare(var2.text, "printf(\"\\n\\tUsuario\");") != 0)
        {
            err2++;
            erros.text = "Erro na linha do usuário ";
        }

        if (string.Compare(var1.text, "printf(\"MegaLoja\");") != 0)
        {
            err1++;
            erros.text = "Erro na linha nome da loja  ";
        }

        if (string.Compare(var1.text, "printf(\"MegaLoja\");") != 0 || string.Compare(var2.text, "printf(\"\\n\\tUsuario\");") != 0 || string.Compare(var3.text, "printf(\"\\n\\tSenha\");") != 0 )
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
