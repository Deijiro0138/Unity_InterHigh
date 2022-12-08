using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class messages : MonoBehaviour {
	 Button backtitle;
	public bool onoff=true;
	 InputField input;
	Text t;
	// Use this for initialization
	void Start () {
		backtitle = GameObject.Find("Button").GetComponent<Button>();
		input = GameObject.Find ("InputField").GetComponent<InputField> ();
		t=GameObject.Find ("Textt").GetComponent<Text> ();
		t.gameObject.SetActive (false);
	}

	// Update is called once per frame
	void Update () {

	}
	public void OnClick(){
		if(onoff==true){
		backtitle.gameObject.SetActive(false);
			input.gameObject.SetActive(false);
			t.gameObject.SetActive(true);
			onoff = false;
			//evalulate.text.color = Color.black;
		}else if(onoff==false){
			backtitle.gameObject.SetActive(true);
			input.gameObject.SetActive(true);
			t.gameObject.SetActive(false);
			onoff = true;
			//evalulate.text.color = Color.clear;
		}
	}
}
