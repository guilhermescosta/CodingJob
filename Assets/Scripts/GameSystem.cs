using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameSystem : MonoBehaviour
{
    public System.DateTime today;

    public System.DateTime deadline;
    public string deadlineString;

    public string textoFinal;
    public Text consoleText;


    // Start is called before the first frame update
    void Start()
    {
      
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CloseIDE() {
        SceneManager.LoadScene(1);
    }

    public void Compile()
    {
        GameObject temp;
        textoFinal = GameObject.FindGameObjectWithTag("printf").GetComponent<Stdio>().textValue;
       // textoFinal = GameObject.FindGameObjectWithTag("Variable").GetComponent<>
    }
}
