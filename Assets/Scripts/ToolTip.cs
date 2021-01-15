using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToolTip : MonoBehaviour
{
    public GameObject toolTipPanel;
    private Text toolTipText;

    [SerializeField] [TextArea]
    private string infoString;

    private void Start()
    {

        toolTipText = toolTipPanel.transform.Find("ToolTipText").GetComponent<Text>();
    }

    private void ShowToolTip(string toolTipString) {
        toolTipPanel.SetActive(true);
        toolTipText.text = toolTipString;
    }

    private void HideToolTip() {
        toolTipPanel.SetActive(false);
    }

    public void ActiveToolTip() {
        ShowToolTip(infoString);
    }

    public void DesactivateToolTip()
    {
        HideToolTip();
    }


}
