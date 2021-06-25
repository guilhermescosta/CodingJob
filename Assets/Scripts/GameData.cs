using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameData: MonoBehaviour
{
  //  public Stage stage = new Stage();
  //  public int totalPoints;

    public int thisStage;
    public static GameData instance;

    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
            return;
        }
        else
        {
            instance = this;
            
        }

        DontDestroyOnLoad(transform.gameObject);
        
        
    }

}
