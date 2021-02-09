using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DragnDrop : MonoBehaviour
{
    private bool isDragging;
    private bool isOver;

    public void OnMouseDown()
    {
        isDragging = true;
    }

    public void OnMouseUp()
    {
        isDragging = false;
    }

    public void OnMouseOver()
    {
        isOver = true;
    }

    public void OnMouseExit()
    {
        isOver = false;
    }

    void Update()
    {   
        // move bloco
        if (isDragging)
        {
            Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
            transform.Translate(mousePosition);
        }

        // remove bloco
        if ( Input.GetMouseButtonDown(1) && isOver ) 
        {
                Destroy(this.gameObject); 
        }
    }

}
