﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightPaddle : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	    var x = Input.GetAxis("Horizontal") * Time.deltaTime * 150.0f;
	    var z = Input.GetAxis("Vertical") * Time.deltaTime * 3.0f;

        transform.Translate(z,0f,0f);
    }
}
