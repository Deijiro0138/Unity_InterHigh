using UnityEngine;
using System.Collections;

public class Logout : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	public void OnClick(){
        FindObjectOfType<UserAuth>().logOut();
        Application.LoadLevel ("title");
		/*UserAuth use = GetComponent<UserAuth> ();
		use.logOut ();*/
	}
	// Update is called once per frame
	void Update () {
	}
}
