using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CreatePrintf : MonoBehaviour
{
    public GameObject printfBlock;  // asset do bloco printf
    public InputField printfText;

    public void NewPrintf()
    {
        printfBlock = Instantiate(printfBlock, new Vector3(-2.8f, 4, 0), Quaternion.Euler(0, 0, 0));
        printfBlock.GetComponent<Stdio>().textValue = printfText.text;
    }
}
