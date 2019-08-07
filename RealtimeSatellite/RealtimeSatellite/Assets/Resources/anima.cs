using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class anima : MonoBehaviour
{
    // Start is called before the first frame update
    private Animation anim;
    GameObject myObject;
    void Start()
    {
        myObject = this.gameObject;
        anim = gameObject.GetComponent<Animation>();
        anim["a"].layer = 123;
    }
 

    // Update is called once per frame
    void Update()
    {
        if (anim.isPlaying)
        {
            myObject.SetActive(true);

        }
    }
}
