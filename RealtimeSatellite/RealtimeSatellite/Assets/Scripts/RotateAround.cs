using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAround : MonoBehaviour {

    Vector3 axis;
    float speed;
	// Use this for initialization
	void Start () {
        do
            axis = new Vector3(0, Random.Range(-1, 2), Random.Range(-1, 2));
        while (axis == Vector3.zero);
        speed = (float)Random.Range(15, 30);
       
        Debug.Log(gameObject + "" + axis);
    }
	
	// Update is called once per frame
	void Update () {

        transform.RotateAround(Vector3.zero,axis, speed * Time.deltaTime);
        transform.RotateAroundLocal(axis, Time.deltaTime);

    }
}
