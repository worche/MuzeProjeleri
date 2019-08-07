using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HandleHeadText : Handletext
{

    public override void TrTextChange()
    {
        this.transform.GetComponent<TextMeshProUGUI>().SetText(nameTrText);
    }
    public override void EngTextChange()
    {
        this.transform.GetComponent<TextMeshProUGUI>().SetText(nameEngText);
    }
}
