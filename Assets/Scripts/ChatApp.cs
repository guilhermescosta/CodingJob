using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChatApp : MonoBehaviour
{
    public GameObject chatAppCanvas;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OpenChatApp() 
    {
        chatAppCanvas.SetActive(true);
    
    }

    public void CloseChatApp() 
    {
        chatAppCanvas.SetActive(false);
    }
}
