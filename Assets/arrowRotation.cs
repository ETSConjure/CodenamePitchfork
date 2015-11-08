﻿using UnityEngine;
using System.Collections;

public class arrowRotation : MonoBehaviour {
    GameObject target;
	// Use this for initialization
	void Start () {
        target = GameObject.Find("Objective");
	}
	
	// Update is called once per frame
	void Update () {
        // fast rotation
        float rotSpeed = 360f;

        // distance between target and the actual rotating object
        Vector3 D = target.transform.position - transform.position;


        // calculate the Quaternion for the rotation
        Quaternion rot = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(D), rotSpeed * Time.deltaTime);

        //Apply the rotation 
        transform.rotation = rot;

        // put 0 on the axys you do not want for the rotation object to rotate
        transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y, transform.eulerAngles.z); 
	}
}
