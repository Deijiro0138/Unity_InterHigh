using UnityEngine;
using System.Collections;
using NCMB;
using System.Collections.Generic;
using System;
public class HighScore : MonoBehaviour {
    public int score{ get;set;}
    public string username{ get; set;}
    // Use this for initialization
	public void save(){
		/*NCMBObject high = new NCMBObject ("HighScore");
		high ["Score"] =score;
		high ["Name"] = username;
		high.SaveAsync ();*/
		NCMBQuery<NCMBObject> query = new NCMBQuery<NCMBObject> ("HighScore");
		query.WhereEqualTo ("Name",username);
		query.FindAsync ((List<NCMBObject> objList, NCMBException e) => {
			if(e==null){
				objList[0]["Score"]=score;
				objList[0].SaveAsync();
			}
		});
	}
   
    public void fetch(){
		NCMBQuery<NCMBObject> query = new NCMBQuery<NCMBObject> ("HighScore");
		query.WhereEqualTo ("Name",username);
		query.FindAsync ((List<NCMBObject> objList, NCMBException e) => {
			if (e == null) {
				if (objList.Count == 0) {
					NCMBObject obj = new NCMBObject ("HighScore");
					obj ["Name"] = username;
					obj ["Score"] = 0;
					obj.SaveAsync ();
					score= 0;
				} else {
					score = System.Convert.ToInt32 (objList [0] ["Score"]);
				}
			}
		});
	}
   
	public string print(){
		return username + ' ' + score;
	}
	private HighScore instance = null;
	void Awake(){
		if (instance == null) {
			instance = this;
			DontDestroyOnLoad (gameObject);
			string name = gameObject.name;
			gameObject.name = name + "(Singleton)";
			GameObject duplicater = GameObject.Find (name);
			if (duplicater != null) {
				Destroy (gameObject);
			} else {
				gameObject.name = name;
			}
		} else {

		Destroy(gameObject);
		}
	}
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        
	}
}
