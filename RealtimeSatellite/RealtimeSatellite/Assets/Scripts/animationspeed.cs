using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animationspeed : MonoBehaviour
{ 

    public Animation anim;
    // Start is called before the first frame update
    void Start()
    {
        anim["dmove"].speed = 4.0f;
    }

  
}
