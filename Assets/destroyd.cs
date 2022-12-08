using UnityEngine;
using System.Collections;

public class destroyd : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Destroy (gameObject,0.000001f);
	}
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name == "de")
        {
            Debug.Log("d");
        }
    }
}
