﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveproj : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.position += transform.up;
        transform.position += new Vector3(0, 0, 11);
	}
}
