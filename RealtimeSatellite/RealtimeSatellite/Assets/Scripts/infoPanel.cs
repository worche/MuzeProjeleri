using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class infoPanel : MonoBehaviour {

    GameObject myObject;
	void Start () {
        myObject = this.gameObject;
	}
	public void setDisable()
    {
        myObject.SetActive(false);
    }

}
