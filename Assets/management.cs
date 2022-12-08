using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class management : MonoBehaviour {
    public static bool fino;
    public AudioClip sound;
	AudioSource audi;
	public Text highmessage;
	private ParticleSystem paper;
	private ParticleSystem paper1;
	private ParticleSystem paper2;
	private ParticleSystem paper3;
	private ParticleSystem paper4;
	private ParticleSystem paper5;
	public static int j2;
	public static int dame;
	public RawImage btu;
	public RawImage batu;
	public RawImage bat;
	private string k = "SCORETATI";
	private int highScore;
	private Button restart;
	private Button backtitle;
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
	public Text score;
	public static int tensu;
	float timers=3f;
	float t=0f;
	public static float second;
    Button teisi;
    ParticleSystem nami;
    ParticleSystem nami1;
	// Use this for initialization
	void Start () {
        nami = GameObject.Find("nami").GetComponent<ParticleSystem>();
        nami1 = GameObject.Find("nami1").GetComponent<ParticleSystem>();
        nami.gameObject.SetActive(true);
        nami1.gameObject.SetActive(true);
        GetComponent<click>().enabled = true;
		audi = gameObject.GetComponent<AudioSource> ();
		j2 = 0;
		bat.enabled = false;
		batu.enabled = false;
		btu.enabled = false;
		highScore = PlayerPrefs.GetInt (k,0);
		tensu = 0;
		falltime=fallstart;
		start.color = Color.green; 
		finish.color = Color.clear; 
		gamen.enabled = false;
		yourscore.color = Color.clear;
		highscore.color = Color.clear;
		result.color = Color.clear;
		res.color = Color.clear;
		tit.color = Color.clear;
		restart = GameObject.Find("restart").GetComponent<Button>();;
		backtitle = GameObject.Find("title").GetComponent<Button>();;
		restart.gameObject.SetActive(false);
		backtitle.gameObject.SetActive(false);
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
		highmessage.color = Color.clear;
        dame = 0;
        fino = false;
	}

	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.F5))
        {
            Application.LoadLevel("catchidea");
        }
        if (Input.GetKey(KeyCode.Escape))
        {
            Application.LoadLevel("online");
        }
		second += Time.deltaTime;
		switch (falltime) {
		case fallstart:
			timers -= Time.deltaTime;
			if (timers < 0f) {
				start.color = Color.clear;
				falltime = falling;
			}
			break;
		case falling:
			score.text = "SCORE:" + tensu;
			if(dame==1){
				btu.enabled = true;
			}
			if(dame==2){
				batu.enabled=true;
			}
			if (dame>=3) {
				falltime = fallfinish;
				bat.enabled = true;
			}
			break;
		case fallfinish:
                fino = true;
			j2 = j2 + 1;
			finish.color = Color.red;
			t += Time.deltaTime;
                GetComponent<click>().enabled = false;
                test3.score4 = tensu;
                test3.HANTEI++;
                nami.gameObject.SetActive(false);
                nami1.gameObject.SetActive(false);
                if (t > 3f) {
                    /*var Highscore = FindObjectOfType<Highscore1>();
                    if (Highscore.score < tensu)
                    {
                        Highscore.username = FindObjectOfType<UserAuth>().currentPlayer();
                        Highscore.score = tensu;
                        Highscore.save1();
                    }*/
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
				PlayerPrefs.SetInt ("rank",tensu);
				if (tensu > highScore) {
                        audi.PlayOneShot(audi.clip);
                        highScore = tensu;
					PlayerPrefs.SetInt (k, highScore);
					highscore.text = "high score" + highscore;
					paper.gameObject.SetActive (true);
					paper1.gameObject.SetActive (true);
					paper2.gameObject.SetActive (true);
					paper3.gameObject.SetActive (true);
					paper4.gameObject.SetActive (true);
					paper5.gameObject.SetActive (true);
					highmessage.color = Color.yellow;
				} else if (tensu < highScore || tensu == highScore) {
					highscore.text = "high score:" + highScore;

				}
			}
			break;

		}
	}

}