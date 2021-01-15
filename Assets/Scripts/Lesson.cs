using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;

public class Lesson : MonoBehaviour
{
    public int aula;  // informa qual a aula / fase o jogador está
    public Email[] emails;    // email com as instruções do que deverá ser feito na IDE

    public DateTime lesson1 = new DateTime(2020, 1, 9);    // prazo de entrega da aula

    private void Awake()
    {
     //   DontDestroyOnLoad(this.gameObject);
    }


    // Start is called before the first frame update
    void Start()
    {
        if (System.DateTime.Today == lesson1)
        {
            Debug.Log("Aula 1 ativada");
            aula = 1;
        }

      
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
