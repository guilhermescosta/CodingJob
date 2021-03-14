using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Notebook : MonoBehaviour
{
  //  public GameObject notepadIcon;
    public GameObject notepadText;

    public void AbrirNotepad()
    {
        notepadText.SetActive(true);
    }

    public void FecharNotepad()
    {
        notepadText.SetActive(false);
    }

}
