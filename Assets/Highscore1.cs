using UnityEngine;
using System.Collections;
using System;
using System.Collections.Generic;
using NCMB;
public class Highscore1 : MonoBehaviour {
    public int score { get; set; }
    public string username { get; set; }
    public void save1()
    {
        /*NCMBObject high = new NCMBObject ("HighScore");
		high ["Score"] =score;
		high ["Name"] = username;
		high.SaveAsync ();*/
        NCMBQuery<NCMBObject> query = new NCMBQuery<NCMBObject>("HighScore1");
        query.WhereEqualTo("Name", username);
        query.FindAsync((List<NCMBObject> objList, NCMBException e) => {
            if (e == null)
            {
                objList[0]["Score"] = score;
                objList[0].SaveAsync();
            }
        });
    }
    public string print()
    {
        return username + ' ' + score;
    }
    public void fetch1()
    {
        NCMBQuery<NCMBObject> query1 = new NCMBQuery<NCMBObject>("HighScore1");
        query1.WhereEqualTo("Name", username);
        query1.FindAsync((List<NCMBObject> objList, NCMBException e) => {
            if (e == null)
            {
                if (objList.Count == 0)
                {
                    NCMBObject obj = new NCMBObject("HighScore1");
                    obj["Name"] = username;
                    obj["Score"] = 0;
                    obj.SaveAsync();
                    score = 0;
                }
                else {
                    score = System.Convert.ToInt32(objList[0]["Score"]);
                }
            }
        });
    }
    private Highscore1 instance = null;
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
            string name = gameObject.name;
            gameObject.name = name + "(Singleton)";
            GameObject duplicater = GameObject.Find(name);
            if (duplicater != null)
            {
                Destroy(gameObject);
            }
            else {
                gameObject.name = name;
            }
        }
        else {

            Destroy(gameObject);
        }
    }
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
