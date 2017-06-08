using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CreateDll;

public class Test : MonoBehaviour {

	// Use this for initialization
	void Start () {
        transform.Ex_SetText("Test","This is a test method");
        NewClass newC = new NewClass();
        print(newC.ShowTip());
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
