﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class text : MonoBehaviour {
	public Text blinkText;
	// Use this for initialization
	void Start () {
    }
	
	// Update is called once per frame
	void Update () {

		if (Input.anyKeyDown) {
			Application.LoadLevel ("online");
		}
		blinkText.color = new Color (0,0,0,Mathf.PingPong(Time.time,1));
	}
}
