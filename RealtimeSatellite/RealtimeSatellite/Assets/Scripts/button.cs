﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button : MonoBehaviour
{
    // Start is called before the first frame update

    GameObject myObject;

    public void setDisable()
    {
        myObject.SetActive(false);
    }
}
