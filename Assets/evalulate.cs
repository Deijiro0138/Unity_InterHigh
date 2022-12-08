using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using NCMB;
public class evalulate : MonoBehaviour {
	//string key="SendMessage";
	static public string str;
	public InputField inputField;
	//public Text tex;
	public Text thank;
	public float timer;

	// Use this for initialization
	void Start () {
		//text.text = PlayerPrefs.GetString (key,"");
		timer=0f;
	}
	
	// Update is called once per frame
	void Update () {
		
		thank.color = Color.clear;
			if (timer < 1.5f && timer > 0.01f) {
			timer += Time.deltaTime;
				thank.color = Color.black;

			}
		if(timer>1.5f){
			timer = 0f;
		}
	}
	public void SaveText(){
		timer += Time.deltaTime;
		/*PlayerPrefs.SetString (key, str);
		PlayerPrefs.Save ();*/
		str = inputField.text;
		//tex.text = str;
		inputField.text = "";
			//Application.OpenURL("http://twitter.com/intent/tweet?text=" + WWW.EscapeURL(str+"#hashtag"));
		NCMBObject testClass=new NCMBObject("TestClass");
		testClass ["message"] = str;
		testClass.SaveAsync ();
	}
}