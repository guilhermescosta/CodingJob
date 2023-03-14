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

    public GameData gameData;

    public GameObject panelSobre; 

    private void Awake()
    {
        gameData = GameObject.Find("GameData").GetComponent<GameData>();
    }

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
        Application.Quit();
    }

    public void Fase1()
    {
        gameData.thisStage = 1;
        SceneManager.LoadScene(6);
    }

    public void Fase2()
    {
        SceneManager.LoadScene(12);
    }

    public void Fase3()
    {
        SceneManager.LoadScene(17);
    }

    public void Fase4()
    {
        SceneManager.LoadScene(21);
    }

    public void Fase5()
    {
        SceneManager.LoadScene(25);
    }


    public void MenuSobre()
    {
        panelSobre.SetActive(true);
    }

    public void FecharSobre()
    {
        panelSobre.SetActive(false);
    }




}
 