using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class namesend : Photon.MonoBehaviour {
    public static string name;
    public Text n;
    public Vector2 offset;
    Text tx;
    // Use this for initialization
    void Start () {
        name = "810";//FindObjectOfType<UserAuth>().currentPlayer();
        tx = Instantiate(n) as Text;
        tx.transform.SetParent(GameObject.Find("Canvas").transform);
    }
	
	// Update is called once per frame
	void Update () {
        tx.transform.position = Camera.main.WorldToScreenPoint(transform.position) + new Vector3(offset.x,offset.y);
        n.text = name;
        n.color = Color.blue;
    }
}
