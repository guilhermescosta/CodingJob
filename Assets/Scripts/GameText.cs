using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameText : MonoBehaviour
{
    [TextArea]
    public string[] text;

    public int _index;

    public Text _gameText;

    public int index_next_scene;

    private void Start()
    {
        _index = 0;
     
        _gameText.text = text[_index];
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) )
        {
            Debug.Log("ok");

            if (_index + 1 < text.Length)
            {
                _index++;
                _gameText.text = text[_index];

            }
            else
            {
                SceneManager.LoadScene(index_next_scene);
            }
        }
    }
}
