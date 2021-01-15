using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SelectAction : MonoBehaviour
{
    public int thisAction;

    public Text code;

    public GameObject execute;
    public GameObject _sala;
    public GameObject _personagem;
    public GameObject _objetos;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void actionSelected()
    {
        if (thisAction == 1) {

            if (_personagem != null)
            {
                _personagem.SetActive(false);
            }
            code.text = "Programa Acao\n\nfuncao Caminhar (destino)\n\nir_para destino\n\nfim;\n\nInicio\n\n  Caminhar(                           );\n\nfim;  ";
            execute.SetActive(true);
            _sala.SetActive(true);
        }

        if (thisAction == 2) {
            if (_sala != null)
            {
                _sala.SetActive(false);
            }
            code.text = "Programa Ação\n\nfuncao Falar (personagem)\n\n se personagem então abrir_conversa(); \n\nfim;\n\nInicio\n\n  Falar(                           );\n\nfim;  ";
            execute.SetActive(true);
            _personagem.SetActive(true);
        }

        if (thisAction == 3)
        {
            if (_objetos != null)
            {
                _objetos.SetActive(false);
            }
            code.text = "Programa Ação\n\nfuncao Utilizar (objetos)\n\n se personagem então abrir_conversa(); \n\nfim;\n\nInicio\n\n  Utilizar(                           );\n\nfim;  ";
            execute.SetActive(true);
            _objetos.SetActive(true);
        }


    }

    public void Execute() {
        if (thisAction == 1) {
            Debug.Log(_sala.GetComponent<Dropdown>().value);
        }

        if (thisAction == 2)
        {
            Debug.Log(_personagem.GetComponent<Dropdown>().value);
        }

        if (thisAction == 3)
        {
            Debug.Log("abre PC");
            SceneManager.LoadScene(8);
        }
    }

}
