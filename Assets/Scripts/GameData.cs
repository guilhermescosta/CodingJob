using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameData: MonoBehaviour
{
  //  public Stage stage = new Stage();
  //  public int totalPoints;

    public int thisStage;

    private void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
        
        //_audioSource = GetComponent<AudioSource>();
    }

}
