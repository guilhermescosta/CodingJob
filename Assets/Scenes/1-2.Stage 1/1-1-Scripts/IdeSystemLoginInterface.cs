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

    public GameObject marcadorErros1;
    public Text marcadorErrosText1;

    public GameObject marcadorErros2;
    public Text marcadorErrosText2;

    public GameObject marcadorErros3;
    public Text marcadorErrosText3;


    public GameObject telaFinal;

    public GameData gameData;

    private void Awake()
    {
        gameData = GameObject.Find("GameData").GetComponent<GameData>();
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
        //esvazia campos de texto
        marcadorErrosText1.text = "";
        marcadorErros1.SetActive(false);
        marcadorErrosText2.text = "";
        marcadorErros2.SetActive(false);
        marcadorErrosText3.text = "";
        marcadorErros3.SetActive(false);



        // printf("\n\tSenha");
        if (!var3.text.EndsWith(";"))
        {
            marcadorErros3.SetActive(true);
            err3++;
            marcadorErrosText3.text = "-Erro na linha senha, falta o ponto e vírgula final\n\n";
        }
        if (string.Compare(var3.text, "printf(\"\\n\\tSenha\");") != 0)
        {
            marcadorErros3.SetActive(true);
            err3++;
            marcadorErrosText3.text += "-Erro na linha senha ";
        }

        //  printf("\n\tUsuario");
        if (!var2.text.EndsWith(";"))
        {
            err2++;
            marcadorErros2.SetActive(true);
            marcadorErrosText2.text = "-Erro na linha usuário, falta o ponto e vírgula final\n\n";
        }
         if (string.Compare(var2.text, "printf(\"\\n\\tUsuario\");") != 0)
        {
            marcadorErros2.SetActive(true);
            err2++;
           marcadorErrosText2.text += "-Erro no texto linha do usuário ";
        }


        // printf("MegaLoja");
        
        if (!var1.text.EndsWith(";"))
        {
            err1++;
            marcadorErros1.SetActive(true);

            marcadorErrosText1.text = "-Erro na linha nome da loja, falta o ponto e vírgula final\n\n";
        }
        

         if (string.Compare(var1.text, "printf(\"MegaLoja\");") != 0)
        {
            Debug.Log(var1.text);
            marcadorErros1.SetActive(true);
            err1++;
            marcadorErrosText1.text += "-Erro no texto da linha nome da loja  ";
        }






        // verificação final da string
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
