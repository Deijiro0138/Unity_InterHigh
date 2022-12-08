using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class start : MonoBehaviour {
    
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	public void OnClick(){
		Application.LoadLevel ("catch");
	}
    public void Select()
    {
        Application.LoadLevel("select");
    }
    public void Online()
    {
        Application.LoadLevel("network");
    }
    public void normal()
    {
        Application.LoadLevel("catchidea");
    }
    public void option()
    {
        Application.LoadLevel("option");
    }
    public void audio()
    {
        Application.LoadLevel("audio");
    }
    public void operation()
    {
        Application.LoadLevel("operation");
    }
    public void menu()
    {
        Application.LoadLevel("LeaderBoard");
    }
    public void rankselect()
    {
            Application.LoadLevel("rankselect");
        rankmanager.isLeaderBoardFetched = false;
        rankmanager.isRankFetched = false;
        rankmanager.isScoreFetched = false;
        rankmanager.issearch=false;
        Rankmanager1.isLeaderBoardFetched1 = false;
        Rankmanager1.isRankFetched1 = false;
        Rankmanager1.isScoreFetched1 = false;
        Rankmanager1.issearch1=false;
    }
    public void tit()
    {
        Application.LoadLevel("online");
        //Properties.Settings.Default.top = "1919";
    }
}
