using UnityEngine;
using System.Collections;

public class dest : MonoBehaviour {// 追いかける対象
	public GameObject vec;
	public GameObject obj;
	private float fall;
	private Vector3 clickPosition;
	public GameObject kitanai;
	// Use this for initialization
	void Start () {
		fall = 0f;
	}
	
	// Update is called once per frame
	void Update () {
		Rigidbody2D rd = GetComponent<Rigidbody2D> ();
		/*if (gamemanager.second > 25f) {
			fall += 0.0001f;
		} else if (gamemanager.second > 45f) {
			fall += 0.0001f;
		} /*else if (gamemanager.second > 35f) {
			fall += 0.0015f;
		} else if (gamemanager.second > 45f) {
			fall += 0.0015f;
		} else if (gamemanager.second > 55f) {
			fall += 0.0015f;
		}*/
		rd.AddForce (Vector3.down * fall);
		/*if (Vector3.Distance (obj.transform.position,transform.position) <= 1f) {
			Destroy (gameObject);
			Instantiate(kitanai,transform.position,transform.rotation);
		}*/
		if (gamemanager.j2>=1||management.j2>=1) {
			Destroy (gameObject);
		}

	}
	void OnCollisionEnter2D(Collision2D collider){
		if (collider.gameObject.tag == "hasi") {
			Destroy (gameObject);
			click.jack++;
			clickonline.jac++;
		} else if (collider.gameObject.tag == "test1") {
			Destroy (gameObject);
		} else if (collider.gameObject.tag == "test2") {
			Destroy (gameObject);
			gamemanager.tensu++;
			management.tensu++;
            onlinemanager.tensu++;
            option.tensu++;
		}else if (collider.gameObject.tag == "test3")
        {
            Destroy(gameObject);
            onlinemanager.tensu1++;
        }
}
}