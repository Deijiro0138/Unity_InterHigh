using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class clickonline : Photon.MonoBehaviour {
	private Vector3 clickPosition;
	private Vector3 screenToWorldPointClickPosition;
	private Collider2D collition2d; 
	private RaycastHit2D hitObject;
	public static int jac;
	public GameObject ball;
	float timer=0.1f;
    public Text GameOver;
	SpriteRenderer MainSpriteRenderer;
    public static int dester;
	// publicで宣言し、inspectorで設定可能にする
	public Sprite StandbySprite;
	public Sprite HoldSprite;
	public Sprite SlashSprite;
    public static int bas;
    // Use this for initialization
    void Start () {
		MainSpriteRenderer=gameObject.GetComponent<SpriteRenderer>();
    }
	IEnumerator WaitAndPrint(float waitTime) {
		yield return new WaitForSeconds(waitTime);
	}

	// Update is called once per frame
	void Update () {
		if (photonView.isMine) {
            if (!Input.GetButton ("Fire1")) {
			
				GetComponent<BoxCollider2D> ().enabled = false;
				clickPosition = Input.mousePosition;
				clickPosition.z = 10f;
				screenToWorldPointClickPosition = Camera.main.ScreenToWorldPoint (clickPosition);
				transform.position = new Vector3 (screenToWorldPointClickPosition.x, screenToWorldPointClickPosition.y, transform.position.z);
				for (int i = 0; i < jac; i++) {
					Debug.Log ("出るッ！！");
					//WaitAndPrint(timer);
					Instantiate (ball, screenToWorldPointClickPosition, transform.rotation);
				}

				jac = 0;
				MainSpriteRenderer.sprite = StandbySprite;
			}
			
			if (Input.GetButton ("Fire1")) {
				if (jac == 0) {
					clickPosition = Input.mousePosition;
					clickPosition.z = 10f;
					screenToWorldPointClickPosition = Camera.main.ScreenToWorldPoint (clickPosition);
					collition2d = Physics2D.OverlapPoint (screenToWorldPointClickPosition);
					hitObject = Physics2D.Raycast (screenToWorldPointClickPosition, -Vector2.up);
					transform.position = new Vector3 (screenToWorldPointClickPosition.x, screenToWorldPointClickPosition.y, transform.position.z);
					GetComponent<BoxCollider2D> ().enabled = true;
					MainSpriteRenderer.sprite = SlashSprite;

					//Destroy(pre);
				} else if (jac < 5 && jac > 0) {
					clickPosition = Input.mousePosition;
					clickPosition.z = 10f;
					screenToWorldPointClickPosition = Camera.main.ScreenToWorldPoint (clickPosition);
					transform.position = new Vector3 (screenToWorldPointClickPosition.x, screenToWorldPointClickPosition.y, transform.position.z);
					GetComponent<BoxCollider2D> ().enabled = true;
					MainSpriteRenderer.sprite = HoldSprite;

				} else if (jac > 4) {
					clickPosition = Input.mousePosition;
					clickPosition.z = 10f;
					screenToWorldPointClickPosition = Camera.main.ScreenToWorldPoint (clickPosition);
					transform.position = new Vector3 (screenToWorldPointClickPosition.x, screenToWorldPointClickPosition.y, transform.position.z);
					GetComponent<BoxCollider2D> ().enabled = false;
					MainSpriteRenderer.sprite = HoldSprite;

				}
		 
			}
            
		}
	}
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "sita")
        {
            Destroy(gameObject);
            dester++;
        }
    }
}
