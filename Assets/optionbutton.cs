using UnityEngine;
using System.Collections;

public class optionbutton : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    public void go()
    {
        if (option.page <= 5)
        {
            option.page = option.page + 1;
        }
    }
    public void back()
    {
        if (option.page >= 1)
        {
            option.page = option.page - 1;

        }
    }
}
