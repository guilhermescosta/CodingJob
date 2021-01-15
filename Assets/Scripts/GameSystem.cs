using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameSystem : MonoBehaviour
{
    public System.DateTime today;

    public System.DateTime deadline;
    public string deadlineString;


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
}
