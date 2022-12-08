using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using NCMB;
using System.Collections.Generic;
public class gamemanager : MonoBehaviour {
    public static bool fi;
    public GameObject clicking;
    public static bool music;
	private string username;
	GameObject[] gos;
	private int players;
	public Color n;
	public Text ja;
	private ParticleSystem paper;
	private ParticleSystem paper1;
	private ParticleSystem paper2;
	private ParticleSystem paper3;
	private ParticleSystem paper4;
	private ParticleSystem paper5;
	public static int j2;
	public static int dame;
	/*public RawImage btu;
	public RawImage batu;
	public RawImage bat;*/
	private string key = "highscoreTATI";
	private int highScore;
	private Button restart;
	private Button backtitle;
	//private Button uploaded;
	public Text res;
	public Text tit;
	public Text result;
	public Text yourscore;
	public Text highscore;
	public Text start;
	public Text finish;
	public Image gamen;
	int falltime;
	const int fallstart=0;
	const int falling=1;
	const int fallfinish=2;
	public Text timer;
	public float times;
	float timers=3f;
	public float t=0f;
	public static float second;
	public static int tensu;
	public Text score;
    AudioSource audio;
   // Button teisi;
    public Text over;
    ParticleSystem nami;
    ParticleSystem nami1;
	// Use this for initialization
	void Start () {
        nami = GameObject.Find("nami").GetComponent<ParticleSystem>();
        nami1 = GameObject.Find("nami1").GetComponent<ParticleSystem>();
        nami.gameObject.SetActive(true);
        nami1.gameObject.SetActive(true);
        fi = false;
        clicking.GetComponent<click>().enabled = true;
        over.color = Color.clear;
       // teisi = GameObject.Find("stop").GetComponent<Button>();
        music = false;
        audio = gameObject.GetComponent<AudioSource>();
        dame = 0;
		tensu = 0;
		ja.color = Color.clear;
		j2 = 0;
		/*bat.enabled = false;
		batu.enabled = false;
		btu.enabled = false;*/
		highScore = PlayerPrefs.GetInt (key,0);
		falltime=fallstart;
		start.color = Color.green; 
		finish.color = Color.clear; 
		gamen.enabled = false;
		second = 0f;
		yourscore.color = Color.clear;
		highscore.color = Color.clear;
		result.color = Color.clear;
		res.color = Color.clear;
		tit.color = Color.clear;
		restart = GameObject.Find("res").GetComponent<Button>();
		backtitle = GameObject.Find("tit").GetComponent<Button>();
		//uploaded = GameObject.Find ("send").GetComponent<Button> ();
		restart.gameObject.SetActive(false);
		backtitle.gameObject.SetActive(false);
		//uploaded.gameObject.SetActive (false);
		paper = GameObject.Find ("paperblue").GetComponent<ParticleSystem> ();
		paper1 = GameObject.Find ("paperred").GetComponent<ParticleSystem> ();
		paper2 = GameObject.Find ("papergreen").GetComponent<ParticleSystem> ();
		paper3 = GameObject.Find ("papergreen1").GetComponent<ParticleSystem> ();
		paper4 = GameObject.Find ("paperblue1").GetComponent<ParticleSystem> ();
		paper5 = GameObject.Find ("paperred1").GetComponent<ParticleSystem> ();
		paper.gameObject.SetActive (false);
		paper1.gameObject.SetActive (false);
		paper2.gameObject.SetActive (false);
		paper3.gameObject.SetActive (false);
		paper4.gameObject.SetActive (false);
		paper5.gameObject.SetActive (false);
    }

	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.F5))
        {
            Application.LoadLevel("catch");
        }
        if (Input.GetKey(KeyCode.Escape))
        {
            Application.LoadLevel("online");
        }
		second += Time.deltaTime;
        score.text = "SCORE:" + tensu;
        switch (falltime) {
		case fallstart:
			
			timers -= Time.deltaTime;
			if (timers < 0f) {
				start.color = Color.clear;
				falltime = falling;
			}
			break;
		case falling:
			times -= Time.deltaTime;
			timer.text = times.ToString ("f0");
			/*if(dame==1){
				btu.enabled = true;
			}
			if(dame==2){
				batu.enabled=true;
			}
			if(dame>=3){
				bat.enabled=true;
			}*/
			if (times < 0f||dame==1) {
				falltime = fallfinish;
			}
			break;
		case fallfinish:
			j2=j2+1;
                if (dame == 1)
                {
                    over.color = Color.red;
                }
                else if (dame == 0)
                {
                    finish.color = Color.red;
                }
			t += Time.deltaTime;
                music = true;
               // teisi.gameObject.SetActive(false);
                clicking.GetComponent<click>().enabled = false;
                fi = true;
                nami.gameObject.SetActive(false);
                nami1.gameObject.SetActive(false);
                test2.score = tensu;
                test2.hantei++;
			if (t > 3f) {
                    /*username = "coco";/*FindObjectOfType<UserAuth> ().currentPlayer ();*/
                    /*NCMBQuery<NCMBObject> query = new NCMBQuery<NCMBObject> ("HighScore");
                    query.WhereEqualTo ("Name",username);
                    query.FindAsync ((List<NCMBObject> objList, NCMBException e) => {
                        if(e==null){
                            objList[0]["Score"]=tensu;
                            objList[0].SaveAsync();
                        }
                    });*/
                    /* var Highscore = FindObjectOfType<HighScore>();
                     if (Highscore.score < tensu)
                     {
                         Highscore.username = FindObjectOfType<UserAuth>().currentPlayer();
                         Highscore.score = tensu;
                         Highscore.save();
                     }*/
                    over.color = Color.clear;
				finish.color =Color.clear;
				gamen.enabled = true;
				yourscore.text = "your score:" + tensu;
				yourscore.color = Color.yellow;
				highscore.color = Color.green;
				result.color = Color.red;
				res.color = Color.black;
				tit.color = Color.black;
				restart.gameObject.SetActive(true);
				backtitle.gameObject.SetActive(true);
				//uploaded.gameObject.SetActive (true);
				PlayerPrefs.SetInt ("rank",tensu);
				/*if(upload.puts==1){
					uploaded.gameObject.SetActive (false);
				}*/

				if (tensu > highScore) {
                        audio.PlayOneShot(audio.clip);
					ja.color = n;
					highScore = tensu;
					PlayerPrefs.SetInt (key, highScore);
					paper.gameObject.SetActive (true);
					paper1.gameObject.SetActive (true);
					paper2.gameObject.SetActive (true);
					paper3.gameObject.SetActive (true);
					paper4.gameObject.SetActive (true);
					paper5.gameObject.SetActive (true);
					highscore.text = "high score" + highscore;
				} else if (tensu < highScore || tensu == highScore) {
					highscore.text = "high score:" + highScore;
				
				}
			}
			break;
		}
	}
}
