using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class click : MonoBehaviour {
    private Vector3 e;
    private ParticleSystem nami;
    private ParticleSystem nami1;
	public GameObject Prefab;
	private Vector3 clickPosition;
	private Vector3 screenToWorldPointClickPosition;
	private Collider2D collition2d; 
	private RaycastHit2D hitObject;
	public GameObject pre;
	public GameObject hasi;
	public static int jack;
	public GameObject ball;
	private Vector3 trans;
	float timer=0.1f;
    public Image[] ts=new Image[5];
    public float ookisa;
    // Use this for initialization
    void Start () {
        nami = GameObject.Find("nami").GetComponent<ParticleSystem>();
        nami1 = GameObject.Find("nami1").GetComponent<ParticleSystem>();
        for(int i = 0; i <= 4; i++)
        {
            ts[i].enabled = true;
        }
    }
	IEnumerator WaitAndPrint(float waitTime) {
		yield return new WaitForSeconds(waitTime);
	}

	// Update is called once per frame
	void Update () {
        if (gamemanager.fi == true)
        {
            for (int i = 0; i <= 4; i++)
            {
                ts[i].enabled = false;
            }
        }
        if (management.fino == true)
        {
            for (int i = 0; i <= 4; i++)
            {
                ts[i].enabled = false;
            }
        }
        if (jack >= 5)
        {
            for (int i = 0; i <= 4; i++)
                ts[i].enabled = false;
        } else if (jack==4){
            for (int i = 0; i <= 3; i++)
                ts[i].enabled = false;
        }else if (jack == 3)
        {
            for (int i = 0; i <= 2; i++)
                ts[i].enabled = false;
        }else if (jack == 2)
        {
            for (int i = 0; i <= 1; i++)
                ts[i].enabled = false;
        }else if (jack == 1)
        {
            ts[0].enabled = false;
        }else if (jack == 0)
        {
            for(int i = 0; i <= 4; i++)
            {
                ts[i].enabled = true;
            }
        }
        
        if (!Input.GetButton ("Fire1")) {
            nami.gameObject.SetActive(false);
            nami1.gameObject.SetActive(false);
			trans = new Vector3 (screenToWorldPointClickPosition.x-2,screenToWorldPointClickPosition.y,screenToWorldPointClickPosition.z);
			clickPosition = Input.mousePosition;
			clickPosition.z = 10f;
			screenToWorldPointClickPosition = Camera.main.ScreenToWorldPoint (clickPosition);
            e = new Vector3(screenToWorldPointClickPosition.x,screenToWorldPointClickPosition.y,-5);
			Instantiate (pre, e, pre.transform.rotation);
			for (int i = 0; i < jack; i++) {
				WaitAndPrint(timer);
				Instantiate (ball,trans,pre.transform.rotation);
				}

			jack = 0;
		}

		/*if(Input.GetButton("Fire1")&&jack>5){
			clickPosition = Input.mousePosition;
			clickPosition.z = 10f;
			screenToWorldPointClickPosition = Camera.main.ScreenToWorldPoint (clickPosition);
			Instantiate (hasi, screenToWorldPointClickPosition, pre.transform.rotation);
			hasi.GetComponent<BoxCollider2D> ().enabled = false;
		}*/
		if (Input.GetButton ("Fire1")) {
            
            if (jack == 0)
                {
                        nami.transform.position = new Vector3(screenToWorldPointClickPosition.x - 1.3f, screenToWorldPointClickPosition.y - 1f, -2);
                        nami1.transform.position = new Vector3(screenToWorldPointClickPosition.x - 2, screenToWorldPointClickPosition.y - 1f, -2);
                        nami.gameObject.SetActive(true);
                        nami1.gameObject.SetActive(true);
                    
                    /* if (Vector3.Distance(kabe.transform.position, Prefab.transform.position) >= 20f)
                     {
                         nami.gameObject.SetActive(false);
                         nami1.gameObject.SetActive(false);
                     }*/
                    clickPosition = Input.mousePosition;
                    clickPosition.z = 10f;
                    screenToWorldPointClickPosition = Camera.main.ScreenToWorldPoint(clickPosition);
                    /*collition2d = Physics2D.OverlapPoint (screenToWorldPointClickPosition);
                    hitObject = Physics2D.Raycast (screenToWorldPointClickPosition, -Vector2.up);*/
                    e = new Vector3(screenToWorldPointClickPosition.x, screenToWorldPointClickPosition.y, -5);
                    Instantiate(Prefab, e, Prefab.transform.rotation);
                if (screenToWorldPointClickPosition.x <= ookisa)
                {
                    nami.gameObject.SetActive(false);
                    nami1.gameObject.SetActive(false);
                }
                    //Destroy(pre);
                }
                else if (jack < 5 && jack > 0)
                {
                        nami.transform.position = new Vector3(screenToWorldPointClickPosition.x - 1.3f, screenToWorldPointClickPosition.y - 1f, -2);
                        nami1.transform.position = new Vector3(screenToWorldPointClickPosition.x - 2, screenToWorldPointClickPosition.y - 1f, -2);
                        nami.gameObject.SetActive(true);
                        nami1.gameObject.SetActive(true);
                    
                    /*if (Vector3.Distance(kabe.transform.position, hasi.transform.position) >= 19f)
                    {
                        nami.gameObject.SetActive(false);
                        nami1.gameObject.SetActive(false);
                    }*/
                    clickPosition = Input.mousePosition;
                    clickPosition.z = 10f;
                    screenToWorldPointClickPosition = Camera.main.ScreenToWorldPoint(clickPosition);
                    e = new Vector3(screenToWorldPointClickPosition.x, screenToWorldPointClickPosition.y, -5);
                    Instantiate(hasi, e, pre.transform.rotation);
                    hasi.GetComponent<BoxCollider2D>().enabled = true;
                if (screenToWorldPointClickPosition.x <= ookisa)
                {
                    nami.gameObject.SetActive(false);
                    nami1.gameObject.SetActive(false);
                }
            }
                else if (jack > 4)
                {
                    nami.gameObject.SetActive(false);
                    nami1.gameObject.SetActive(false);
                    clickPosition = Input.mousePosition;
                    clickPosition.z = 10f;
                    screenToWorldPointClickPosition = Camera.main.ScreenToWorldPoint(clickPosition);
                    e = new Vector3(screenToWorldPointClickPosition.x, screenToWorldPointClickPosition.y, -5);
                    Instantiate(hasi, e, pre.transform.rotation);
                    hasi.GetComponent<BoxCollider2D>().enabled = false;
                }
            
		}
	}
}
