﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OpSystem : MonoBehaviour
{
    public GameData gameData;
    private void Awake()
    {
        gameData = GameObject.Find("GameData").GetComponent<GameData>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CloseOS()               //versao teste:  volta para tela inicial 
    {
        SceneManager.LoadScene(5);
    }


    // ####################### FASE 1 ############################ 
    public void openEmail1()
    {

        SceneManager.LoadScene(7);
    }

    public void openIde1()
    {
        if (gameData == null)
            gameData.thisStage = 1;

        if(gameData.thisStage ==1 )
            SceneManager.LoadScene(8);
        if (gameData.thisStage == 2)
            SceneManager.LoadScene(9);
        if (gameData.thisStage == 3)
            SceneManager.LoadScene(10);

    }

    public void openChat1()
    {
        SceneManager.LoadScene(11);
    }

    public void BackToOS1()
    {
        SceneManager.LoadScene(6);
    }




    //######################### FASE 2 #################################
    

    public void openEmail2()
    {

        SceneManager.LoadScene(13);
    }

    public void openIde2()
    {
        SceneManager.LoadScene(15);
    }

    public void openChat2()
    {
        SceneManager.LoadScene(14);
    }



    public void BackToOS2()
    {
        SceneManager.LoadScene(12);
    }










    public void openEmail3()
    {

        SceneManager.LoadScene(8);
    }

    public void openEmail4()
    {

        SceneManager.LoadScene(11);
    }

    public void openEmail5()
    {

        SceneManager.LoadScene(14);
    }




   

    public void openIde3()
    {
        SceneManager.LoadScene(9);
    }

    public void openIde4()
    {
        SceneManager.LoadScene(12);
    }

    public void openIde5()
    {
        SceneManager.LoadScene(15);
    }



    public void BackToOS3()
    {
        SceneManager.LoadScene(7);
    }

    public void BackToOS4()
    {
        SceneManager.LoadScene(10);
    }

    public void BackToOS5()
    {
        SceneManager.LoadScene(13);
    }

}
