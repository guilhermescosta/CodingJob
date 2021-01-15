using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OpSystem : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void openEmail() {
       
        SceneManager.LoadScene(10);
    }

    public void openIde()
    {
        SceneManager.LoadScene(9);
    }

    public void CloseOS()
    {
        SceneManager.LoadScene(7);
    }

    public void BackToOS()
    {
        SceneManager.LoadScene(8);
    }

}
