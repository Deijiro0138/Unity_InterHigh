using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class LogInManager : MonoBehaviour {
	private GameObject guiTextLogIn;
	private GameObject guiTextSignUp;
	public static bool isLogIn;
	private bool logInButton;
	private bool signUpMenuButton;
	private bool signUpButton;
	private bool backButton;
    public Text sign;
    public Text log;
	public string id;
	public string pw;
	public string mail;
	// Use this for initialization
	void Start () {
       // sign = GameObject.Find("Text(1)").GetComponent<Text>();
        //log = GameObject.Find("log").GetComponent<Text>();
		FindObjectOfType<UserAuth> ().logOut ();
		guiTextLogIn = GameObject.Find ("GUITextLogIn");
		guiTextSignUp = GameObject.Find ("GUITextSignUp");
		isLogIn = true;
		guiTextSignUp.SetActive (false);
		guiTextLogIn.SetActive (true);
        sign.color = Color.clear;
        log.color = Color.white;
	}
	void OnGUI(){
		if (isLogIn) {
			drawLogInMenu ();
			if (logInButton)
				FindObjectOfType<UserAuth> ().logIn (id, pw);
			if (signUpMenuButton)
				isLogIn = false;
		} else {
			drawSignUpMenu ();
			if (signUpButton)
				FindObjectOfType<UserAuth> ().signUp (id,mail,pw);
			if (backButton)
				isLogIn = true;
		}
		if (FindObjectOfType<UserAuth> ().currentPlayer () != null)
			Application.LoadLevel ("online");
	}
	private void drawLogInMenu(){
        log.color = Color.white;
        sign.color = Color.clear;
		guiTextSignUp.SetActive (false);
		guiTextLogIn.SetActive (true);
		GUI.skin.textField.fontSize = 20;
		int txtW = 150, txtH = 40;
		id = GUI.TextField (new Rect (Screen.width * 1 / 2, Screen.height * 1 / 3 - txtH * 1 / 2, txtW, txtH), id);
		pw=GUI.TextField (new Rect (Screen.width * 1 / 2, Screen.height * 1 / 2 - txtH * 1 / 2, txtW, txtH), pw,'*');

		int btnW = 180, btnH = 50;
		GUI.skin.button.fontSize = 20;
		logInButton=GUI.Button(new Rect (Screen.width * 1 / 4-btnW*1/2, Screen.height * 3 / 4- btnH * 1 / 2, btnW, btnH), "ログイン");
		signUpMenuButton = GUI.Button (new Rect(Screen.width * 3 / 4-btnW*1/2, Screen.height * 3 / 4- btnH * 1 / 2, btnW, btnH), "サインアップ");
	}
	private void drawSignUpMenu(){
        log.color = Color.clear;
        sign.color = Color.white;
		guiTextLogIn.SetActive(false);
		guiTextSignUp.SetActive (true);

		int txtW = 150, txtH = 35;
		GUI.skin.textField.fontSize = 20;
		id = GUI.TextField     (new Rect(Screen.width*1/2, Screen.height*1/4 - txtH*1/2, txtW, txtH), id);
		pw = GUI.PasswordField (new Rect(Screen.width*1/2, Screen.height*2/5 - txtH*1/2, txtW, txtH), pw,'*');
		mail = GUI.TextField   (new Rect(Screen.width*1/2, Screen.height*11/20 - txtH*1/2, txtW, txtH), mail);

		// ボタンの設置
		int btnW = 180, btnH = 50;
		GUI.skin.button.fontSize = 20;
		signUpButton = GUI.Button( new Rect(Screen.width*1/4 - btnW*1/2, Screen.height*3/4 - btnH*1/2, btnW, btnH), "サインアップ" );
		backButton   = GUI.Button( new Rect(Screen.width*3/4 - btnW*1/2, Screen.height*3/4 - btnH*1/2, btnW, btnH), "戻る" ); 

	}
	// Update is called once per frame
	void Update () {
	
	}
}
