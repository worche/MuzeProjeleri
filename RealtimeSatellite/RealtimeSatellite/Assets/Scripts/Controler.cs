using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Controler : MonoBehaviour
{

    [SerializeField] ButtonScript btn1;
    [SerializeField] ButtonScript btn2;
    [SerializeField] ButtonScript btn3;
    [SerializeField] ButtonScript btn4;
    [SerializeField] ButtonScript btn5;

    [SerializeField]
    ButtonScript btn11;
    [SerializeField]
    ButtonScript btn22;
    [SerializeField]
    ButtonScript btn33;
    [SerializeField]
    ButtonScript btn44;
    [SerializeField]
    ButtonScript btn55;

    [SerializeField] ButtonScript btna;
    [SerializeField] ButtonScript btnb;
    [SerializeField] ButtonScript btnc;
    [SerializeField] ButtonScript btnd;
    [SerializeField] ButtonScript btne;

    [SerializeField] ButtonScript btna1;
    [SerializeField] ButtonScript btnb1;
    [SerializeField] ButtonScript btnc1;
    [SerializeField] ButtonScript btnd1;
    [SerializeField] ButtonScript btne1;

    [SerializeField] RawImage info1;
    [SerializeField] RawImage info2;
    [SerializeField] RawImage info3;
    [SerializeField] RawImage info4;
    [SerializeField] RawImage info5;
  


    public void DefaultState(string obj)
    {
        if (info1.enabled)
        {
            info1.GetComponent<Animator>().Play("Close");
        }
        if (info2.enabled)
        {
            info2.GetComponent<Animator>().Play("Close");
        }
        if (info3.enabled)
        {
            info3.GetComponent<Animator>().Play("Close");
        }
        if (info4.enabled)
        {
            info4.GetComponent<Animator>().Play("Close");
        }
        if (info5.enabled)
        {
            info5.GetComponent<Animator>().Play("Close");
        }
       
        if (btn1.click && btn1.gameObject.name == obj)
        {
            btn1.SetClickFalse();
        }
        if (btn2.click && btn2.gameObject.name == obj)
        {
            btn2.SetClickFalse();
        }
        if (btn3.click && btn3.gameObject.name == obj)
        {
            btn3.SetClickFalse();
        }
        if (btn4.click && btn4.gameObject.name == obj)
        {
            btn4.SetClickFalse();
        }
        if (btn5.click && btn5.gameObject.name == obj)
        {
            btn5.SetClickFalse();
        }
        if (btna.click && btna.gameObject.name == obj)
        {
            btna.SetClickFalse();
        }
        if (btnb.click && btnb.gameObject.name == obj)
        {
            btnb.SetClickFalse();
        }
        if (btnc.click && btnc.gameObject.name == obj)
        {
            btnc.SetClickFalse();
        }
        if (btnd.click && btnd.gameObject.name == obj)
        {
            btnd.SetClickFalse();
        }
        if (btne.click && btne.gameObject.name == obj)
        {
            btne.SetClickFalse();
        }

        if (btn11.click && btn11.gameObject.name != obj)
        {
            btn11.SetClickFalse();
        }
        if (btn22.click && btn22.gameObject.name != obj)
        {
            btn22.SetClickFalse();
        }
        if (btn33.click && btn33.gameObject.name != obj)
        {
            btn33.SetClickFalse();
        }
        if (btn44.click && btn44.gameObject.name != obj)
        {
            btn44.SetClickFalse();
        }
        if (btn55.click && btn55.gameObject.name != obj)
        {
            btn55.SetClickFalse();
        }
        if (btna1.click && btna1.gameObject.name != obj)
        {
            btna1.SetClickFalse();
        }
        if (btnb1.click && btnb1.gameObject.name != obj)
        {
            btnb1.SetClickFalse();
        }
        if (btnc1.click && btnc1.gameObject.name != obj)
        {
            btnc1.SetClickFalse();
        }
        if (btnd1.click && btnd1.gameObject.name != obj)
        {
            btnd1.SetClickFalse();
        }
        if (btne1.click && btne1.gameObject.name != obj)
        {
            btne1.SetClickFalse();
        }

    }
}
