using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HandleScriptBtn : Handletext
{

    public override void TrTextChange()
    {
        this.transform.GetChild(0).GetComponent<TextMeshProUGUI>().SetText(nameTrText);
    }
    public override void EngTextChange()
    {
        this.transform.GetChild(0).GetComponent<TextMeshProUGUI>().SetText(nameEngText);
    }
}
