using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Handletext : MonoBehaviour {

    [SerializeField] TextAsset TrTextPath;
    [SerializeField] TextAsset EngTextPath;

    [HideInInspector]
    public string trText;
    [HideInInspector]
    public string engText;
    [HideInInspector]
    public string nameTrText;
    [HideInInspector]
    public string nameEngText;


    // Use this for initialization
    void Start()
    {

        trText = TrTextPath.text;
        engText = EngTextPath.text;

        nameTrText = TrTextPath.name;
        nameEngText = EngTextPath.name;
    }

    public virtual void  TrTextChange()
    {
       this.transform.GetChild(0).GetComponent<TextMeshProUGUI>().SetText(nameTrText);
       this.transform.GetChild(1).GetComponent<TextMeshProUGUI>().SetText(trText);
    }

    public virtual  void EngTextChange()
    {
        this.transform.GetChild(0).GetComponent<TextMeshProUGUI>().SetText(nameEngText);
        this.transform.GetChild(1).GetComponent<TextMeshProUGUI>().SetText(engText);
    }

}
