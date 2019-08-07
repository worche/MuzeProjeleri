using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;


public class ButtonScript : MonoBehaviour {

    [SerializeField] RawImage infoPanel;
   
    [SerializeField] Controler controler;
    
    
    [HideInInspector]public bool click = false;
    Button btn;
    // Use this for initialization
    void Start () {
        btn=GetComponent<Button>();
       

        btn.onClick.AddListener(clickFunc);
    }

    private void clickFunc()
    {
        controler.DefaultState(this.gameObject.name);
        click = !click;
        if (click)
        {
            
            infoPanel.gameObject.SetActive(true);
            
            infoPanel.GetComponent<Animator>().Play("Open");
        }
        else 
        {

            infoPanel.GetComponent<Animator>().Play("Close");
        }
    }
    public void SetClickFalse()
    {
        click = !click;
       
    }

    
}
