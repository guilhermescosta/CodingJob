using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TextController : MonoBehaviour
{
    [TextArea(1,5)]
    public string[] texts;
    public int textIndex = 0;

    public int nextSceneIndex;

    public Text gameText;

    // Start is called before the first frame update
    void Start()
    {
        gameText.text = texts[0];
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void NextText()
    {
        if (textIndex < texts.Length - 1)
        {
            gameText.text = texts[textIndex + 1];
            textIndex++;
        }
        else
        {
            SceneManager.LoadScene(nextSceneIndex);

        }
    }
}
