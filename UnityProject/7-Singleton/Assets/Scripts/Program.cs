﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Program : MonoBehaviour {

	// Use this for initialization
	void Start () {

        print(SingletonTest.Instance.items);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}