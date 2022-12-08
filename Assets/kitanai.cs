using UnityEngine;
using System.Collections;
public class kitanai : MonoBehaviour {
	private Vector3 tra = new Vector3 (525,360,0);
	private Vector3 tr = new Vector3 (526,360,0);
	public float timer;
	float time;
	float times;
	float i;
	float j;
	float q;
	// Use this for initialization
	void Start () {
		timer = 0;
		i= Random.Range (5.0f,12.0f);
		j = Random.Range (25.0f,32.0f);
		q = Random.Range (45.0f,52.0f);
		Debug.Log ("j="+j);
		Debug.Log ("i="+i);
		Debug.Log ("q="+q);
	}
	
	// Update is called once per frame
	void Update () {
		timer += Time.deltaTime;
		if ((timer<i+12&&timer > i)&&transform.position!=tr) {
			time += Time.deltaTime;
			transform.position = new Vector3 (transform.position.x-0.051111f,Mathf.Sin(Time.time*7.0f)+360f,0);

		}else if(Vector3.Distance (tra, transform.position) >= 35f){
			transform.position = tra;
		}

		if ((timer<j+12&&timer > j)&&transform.position!=tra) {
			times += Time.deltaTime;
			transform.position = new Vector3 (transform.position.x-0.051111f,Mathf.Sin(Time.time*7.0f)+360f,0);

		}else if(Vector3.Distance (tra, transform.position) >= 35f){
			transform.position = tra;
		}
		if ((timer<q+12&&timer > q)&&transform.position!=tr) {
			time += Time.deltaTime;
			transform.position = new Vector3 (transform.position.x-0.051111f,Mathf.Sin(Time.time*7.0f)+360f,0);

		}else if(Vector3.Distance (tra, transform.position) >= 35f){
			transform.position = tra;
		}
	}

}