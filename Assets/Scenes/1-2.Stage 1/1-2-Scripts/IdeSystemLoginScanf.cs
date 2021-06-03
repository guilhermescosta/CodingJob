using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using UnityEngine.SceneManagement;

public class IdeSystemLoginScanf : MonoBehaviour
{


    public InputField var1;
    int err1;

    public InputField var2;
    int err2;

    public InputField var3;
    int err3;

    public InputField var4;
    int err4;

    public Text erros;

    public GameObject telaFinal;

    public GameData gameData;

    private void Awake()
    {
        gameData = GameObject.Find("GameData").GetComponent<GameData>();
        gameData.thisStage = 2;
    }


    public void CreateText()
    {
        string path = Application.dataPath + "/resultado.txt";
        if (!File.Exists(path))
        {
            File.WriteAllText(path, "\nFase 1-2 erro1: " + err1 + " erro2: " + err2 + " erro3: " + err3 + " erro4: " + err4);
        }
        else
        {
            string content = "\nFase 1-2 erro1: " + err1 + " erro2: " + err2 + " erro3: " + err3 + " erro4: " + err4;
            File.AppendAllText(path, content);
        }
    }

    public void Continuar()
    {
        SceneManager.LoadScene(10);
    }



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayButton()
    {

        if (string.Compare(var4.text, "scanf(\"%d\",&senha);") != 0)
        {
            err4++;
            erros.text = "Erro na linha leitura variavel senha  ";
            Debug.Log("scanf(\"%d\",&senha);");
        }

        if (string.Compare(var3.text, "scanf(\"%s\",&usuario);") != 0)
        {
            err3++;
            erros.text = "Erro na linha leitura variavel usuario  ";
            Debug.Log("scanf(\"%s\",&usuario);");
        }

        if (string.Compare(var2.text, "int senha=0;") != 0)
        {
            err2++;
            erros.text = "Erro na linha definicao variavel senha ";
        }

        if (string.Compare(var1.text, "char usuario[20];") != 0)
        {
            err1++;
            erros.text = "Erro na linha definicao variavel usuario  ";
        }

        if (string.Compare(var1.text, "char usuario[20];") != 0 || string.Compare(var2.text, "int senha=0;") != 0 || string.Compare(var3.text, "scanf(\"%s\",&usuario);") != 0 || string.Compare(var4.text, "scanf(\"%d\",&senha);") != 0)
        {
            Debug.Log(var4);

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
