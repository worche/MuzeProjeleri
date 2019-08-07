using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using TMPro;

public class LangueSwitch : MonoBehaviour
{

    Button btn;
    Image btnImage;
    [SerializeField] bool treng = false;

    [SerializeField] HandleHeadText head1;
    [SerializeField] Handletext info1;
    [SerializeField] Handletext info2;
    [SerializeField] Handletext info3;
    [SerializeField] Handletext info4;
    [SerializeField] Handletext info5;
    [SerializeField] HandleScriptBtn btn1;
    [SerializeField] HandleScriptBtn btn2;
    [SerializeField] HandleScriptBtn btn3;
    [SerializeField] HandleScriptBtn btn4;
    [SerializeField] HandleScriptBtn btn5;
    [SerializeField] HandleScriptBtn btn11;
    [SerializeField] HandleScriptBtn btn22;
    [SerializeField] HandleScriptBtn btn33;
    [SerializeField] HandleScriptBtn btn44;
    [SerializeField] HandleScriptBtn btn55;

    int _long = 0;
    int longSize = 0;

    // Use this for initialization
    void Start()
    {
        btn = this.GetComponent<Button>();
        btnImage = this.GetComponent<Image>();
        ImageChange();
        btn.onClick.AddListener(ImageChange);
        
    }

    private void ImageChange()
    {
        if (treng == true)
        {
            head1.EngTextChange();

            info1.EngTextChange();
            info2.EngTextChange();
            info3.EngTextChange();
            info4.EngTextChange();
            info5.EngTextChange();

            btn1.EngTextChange();
            btn2.EngTextChange();
            btn3.EngTextChange();
            btn4.EngTextChange();
            btn5.EngTextChange();

            btn11.EngTextChange();
            btn22.EngTextChange();
            btn33.EngTextChange();
            btn44.EngTextChange();
            btn55.EngTextChange();

            
            btnImage.sprite = (Sprite)Resources.Load<Sprite>("ButtonImages/Eng");
            treng = false;

        }
        else if (treng == false)
        {
            head1.TrTextChange();

            info1.TrTextChange();
            info2.TrTextChange();
            info3.TrTextChange();
            info4.TrTextChange();
            info5.TrTextChange();


            btn1.TrTextChange();
            btn2.TrTextChange();
            btn3.TrTextChange();
            btn4.TrTextChange();
            btn5.TrTextChange();

            btn11.TrTextChange();
            btn22.TrTextChange();
            btn33.TrTextChange();
            btn44.TrTextChange();
            btn55.TrTextChange();

            info1.gameObject.SetActive(false);
            info2.gameObject.SetActive(false);
            info3.gameObject.SetActive(false);
            info4.gameObject.SetActive(false);
            info5.gameObject.SetActive(false);


            btn11.gameObject.SetActive(false);
            btn22.gameObject.SetActive(false);
            btn33.gameObject.SetActive(false);
            btn44.gameObject.SetActive(false);
            btn55.gameObject.SetActive(false);

            btn1.gameObject.SetActive(true);
            btn2.gameObject.SetActive(true);
            btn3.gameObject.SetActive(true);
            btn4.gameObject.SetActive(true);
            btn5.gameObject.SetActive(true);



            btnImage.sprite = (Sprite)Resources.Load<Sprite>("ButtonImages/Tr");
            treng = true;
        }
    }
}


