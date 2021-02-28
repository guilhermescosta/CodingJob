using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ConsoleSystemLogin : MonoBehaviour
{
    public InputField user;
    public InputField pass;
    public Text output;

    public Lesson _lesson;
    public GameObject telaFinal;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Fim()
    {
        telaFinal.SetActive(true);
    }

    public void Encerrar()
    {
        SceneManager.LoadScene(0);
    }

    public void Result()
    {
        if (string.Compare(user.text, "haskell") != 0)
        {
            output.text = "usuário não cadastrado\n";
        }
        else if (string.Compare(pass.text, "senha123") != 0)
        {
            output.text = "senha incorreta";
        }
        else
        {
            output.text = "Usuário Logado\nTeste Encerrado, reportar Haskell";
            Fim();
            //_lesson.aula = 2;
        }
    }


}
