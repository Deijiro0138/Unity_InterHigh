using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class stop : MonoBehaviour {
    public Image gamen;
    bool push;
    private Button res;
    private Button tit;
	// Use this for initialization
	void Start () {
        res = GameObject.Find("res").GetComponent<Button>();
        tit = GameObject.Find("tit").GetComponent<Button>();
        res.gameObject.SetActive(false);
        tit.gameObject.SetActive(false);
        push = false;
        gamen.color = Color.clear;
    }
	
	// Update is called once per frame
	void Update () {
	
	}
    public void stoping()
    {
        if (push == false)
        {
            gamen.color = Color.black;
           res.gameObject.SetActive(true);
           tit.gameObject.SetActive(true);
            push = true;
            Time.timeScale = 0;

        }
        else if (push == true)
        {
            gamen.color = Color.clear;
            res.gameObject.SetActive(false);
            tit.gameObject.SetActive(false);
            push = false;
            Time.timeScale = 1;
        }
    }
}
