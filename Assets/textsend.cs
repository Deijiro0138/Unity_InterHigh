﻿using UnityEngine;
using System.Collections;

public class textsend : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void OnClick(){
		Application.LoadLevel ("rank");
	}
    public void Online()
    {
        Application.LoadLevel("online");
    }
}
