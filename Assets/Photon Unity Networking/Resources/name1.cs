using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class name1 : Photon.MonoBehaviour {
    public static string na;
    public Text n;
    public Vector2 offset;
    Text tx;
    void Start () {
        na = "daijiro"; FindObjectOfType<UserAuth>().currentPlayer();
        tx = Instantiate(n) as Text;
        tx.transform.SetParent(GameObject.Find("Canvas").transform);
    }
	
	// Update is called once per frame
	void Update () {
        tx.transform.position = Camera.main.WorldToScreenPoint(transform.position) + new Vector3(offset.x, offset.y);
        n.text = na;
        n.color = Color.red;
    }
}
