using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ConsoleSystem : MonoBehaviour
{
    public InputField user;
    public InputField pass;
    public Text output;

    public Lesson _lesson;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
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
            _lesson.aula = 2;
        }
    }


}
