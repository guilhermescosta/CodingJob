using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IdeSystem : MonoBehaviour
{
    public InputField var1;
    public InputField command1;

    public InputField var2;
    public InputField var3;
    public InputField var4;

    public GameObject commandIde;

    public void CloseCommand()
    {
        commandIde.SetActive(false);
    }

    public void PlayButton()
    {
        // Debug.Log(string.Compare(var1.text, "validaSenha"));
        if (string.Compare(var1.text, "validaSenha") != 0)
        {
            Debug.Log("erro");
        }
        else if (string.Compare(command1.text, "strcmp(senha,pass);") != 0)
        {
            Debug.Log("erro 2");
        }

        // linha 2
        else if (string.Compare(var2.text, "validou") != 0)
        {
            Debug.Log("erro 3");
        }

        else if (string.Compare(var3.text, "validaUsuario") != 0)
        {
            Debug.Log("erro 4");
        }

        else if (string.Compare(var4.text, "validaSenha;") != 0)
        {
            Debug.Log("erro 5");
        }

        else
        {
            Debug.Log("Tudo Ok");
            commandIde.SetActive(true);
        }

    }
}
