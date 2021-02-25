using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainTitle : MonoBehaviour
{
    public Light computerLight;

    public bool startLight;

    public GameObject selectCanvas;


    // Start is called before the first frame update
    void Start()
    {
        startLight = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(startLight)
            StartGame();
    }

    public void StartGame()
    {
         startLight = true;
         StartComputerLight();

    }

    void StartComputerLight()
    {

        if (computerLight.range < 110f)
        {
            computerLight.range += Time.deltaTime * 50f;
        }
        else
        {
          
            SceneManager.LoadScene(1);
        }
    }

    public void OpenScenarioSelectCanvas()
    {
        selectCanvas.SetActive(true);
    }

    public void CloseScenarioSelectCanvas()
    {
        selectCanvas.SetActive(false);
    }

    public void Fase1()
    {
        SceneManager.LoadScene(1);
    }

    public void Fase2()
    {
        SceneManager.LoadScene(4);
    }

  
}
 