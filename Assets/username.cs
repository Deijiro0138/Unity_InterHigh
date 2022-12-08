using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class username : MonoBehaviour {
	public Text name;
	// Use this for initialization
	void Start () {
		name.text = FindObjectOfType <UserAuth>().currentPlayer ();
        var highscore = FindObjectOfType<Highscore1>();
        var high = FindObjectOfType<HighScore>();
       // high.fetch();
      //  highscore.fetch1();
	}
	
	// Update is called once per frame
	void Update () {
	}
}
