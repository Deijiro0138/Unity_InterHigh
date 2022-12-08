using UnityEngine;
using System.Collections;

public class obt : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (gamemanager.j2 >= 1||management.j2>=1) {
			Destroy (gameObject);

		}
	}
	void OnCollisionEnter2D(Collision2D collider){
		if (collider.gameObject.tag == "hasi") {
			Destroy (gameObject);
			gamemanager.dame++;
			management.dame++;
            option.dame++;
            click.jack = 0;
		} else if (collider.gameObject.tag == "test1") {
			Destroy (gameObject);
		}
}
}