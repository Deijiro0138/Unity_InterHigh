using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using NCMB;
using System.Collections.Generic;
public class onlinemanager : MonoBehaviour
{
	public Text player1;
	public Text player2;
    public Text win;
    string sc;
    string sc1;
    public Text score1;
    public static int tensu1;
    int jugde;
    private string username;
    GameObject[] gos;
    private int players;
    
    public static int j2;
    public static int dame = 0;
    /*public RawImage btu;
	public RawImage batu;
	public RawImage bat;*/
    private Button backtitle;
    //private Button uploaded;
    public Text tit;
    public Text result;
    public Text yourscore;
    public Text otherscore;
    public Text start;
    public Image gamen;
    int falltime;
    const int fallstart = 0;
    const int falling = 1;
    const int fallfinish = 2;
    public Text timer;
    public float times;
    float timers = 7f;
    float t = 0f;
    public static float second;
    public static int tensu;
    public Text score;
    // Use this for initialization
    void Start()
    {
		player1.color = Color.blue;
		player2.color = Color.red;
        tensu = 0;
        j2 = 0;
        /*bat.enabled = false;
		batu.enabled = false;
		btu.enabled = false;*/
        falltime = fallstart;
        start.color = Color.clear;
        gamen.enabled = false;
        second = 0f;
        yourscore.color = Color.clear;
        otherscore.color = Color.clear;
        result.color = Color.clear;
        tit.color = Color.clear;
        backtitle = GameObject.Find("title").GetComponent<Button>();
        //uploaded = GameObject.Find ("send").GetComponent<Button> ();
        backtitle.gameObject.SetActive(false);
        //uploaded.gameObject.SetActive (false);

        win.color = Color.clear;
        tensu1 = 0;
    }

    // Update is called once per frame
    void Update()
    {

        sc = namesend.name;
        sc1 = name1.na;
        player1.text = sc;
		player2.text = sc1;
        score.color = Color.blue;
        score1.color = Color.red;//FindObjectOfType<name1>().sendname();
        second += Time.deltaTime;
        switch (falltime)
        {
            case fallstart:
                if (online.hantei == true)
                {
                    start.color = Color.green;
                }
                score.text = "SCORE:" + tensu;
                score1.text = "SCORE:" + tensu1;
                timers -= Time.deltaTime;
                if (timers < 0f)
                {
                    start.color = Color.clear;
                    falltime = falling;
                }
                break;
            case falling:
                times -= Time.deltaTime;
                timer.text = times.ToString("f0");
                /*if(dame==1){
                    btu.enabled = true;
                }
                if(dame==2){
                    batu.enabled=true;
                }
                if(dame>=3){
                    bat.enabled=true;
                }*/
                if (times < 0f || clickonline.dester>=2)
                {
                    falltime = fallfinish;
                }
                break;
            case fallfinish:
                j2 = j2 + 1;
                t += Time.deltaTime;

                if (t > 2f)
                {
                    win.color = Color.yellow;
                    clickonline.bas = 1;
                    gamen.enabled = true;
                    yourscore.text = sc+":" + tensu;
                    otherscore.text = sc1+":" +tensu1;
                    if (tensu > tensu1)
                    {
                        win.text =sc+"の勝利です。";
                    }else if (tensu1 > tensu)
                    {
                        win.text = sc1 + "の勝利です。";
                    }else if (tensu == tensu1)
                    {
                        win.text = "引き分けです。";
                    }
                    yourscore.color = Color.blue;
                    otherscore.color = Color.red;
                    result.color = Color.red;
                    tit.color = Color.black;
                    backtitle.gameObject.SetActive(true);
                    //uploaded.gameObject.SetActive (true);
                    
                }
                if (t > 10f)
                {
                    Application.LoadLevel("online");
                }
                break;
        }
    }
}
