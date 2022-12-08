
using UnityEngine;
using UnityEngine.UI;
using System.Collections;
public class online : Photon.MonoBehaviour {
    public static bool hantei;
    public Text load;
    public int n;
	public int number;
	GameObject[] playerobj;
    public int number1;
    GameObject[] playertachi;
    public int i;
	// Use this for initialization
	// Update is called once per frame
	void Awake(){
		PhotonNetwork.ConnectUsingSettings ("v0.1");
		PhotonNetwork.sendRate = 1;
		PhotonNetwork.sendRateOnSerialize = 1;
		playerobj = GameObject.FindGameObjectsWithTag ("hasi");
        playertachi = GameObject.FindGameObjectsWithTag("hasi1");
		number = playerobj.Length;
        number1 = playertachi.Length;
        hantei = false;
        n = 0;
        i = 0;
	}
	void Update () {
        if (n == 0 || n == 1)
        {
            Time.timeScale = 0;
        }
        if (n == 2)
        {
            Time.timeScale = 1;
        }
	}
	void OnJoinedLobby(){
		PhotonNetwork.JoinRandomRoom ();
		Debug.Log ("ロビーに入室");
        n++;
	}
	void OnJoinedRoom(){
		Debug.Log ("ルームへの参加に成功しました。");
        if (n==1)
        {
            GameObject player = PhotonNetwork.Instantiate("playerprefab", new Vector3(507f, 357f, 0f), Quaternion.identity, 0);
            i = 1;
        }
        if (i==1)
        {
            GameObject player1 = PhotonNetwork.Instantiate("playerprefab2", new Vector3(507f, 357f, 0f), Quaternion.identity, 0);
            //Time.timeScale = 1;
            load.color = Color.clear;
            hantei = true;
        }
	}
	void OnPhotonRandomJoinFailed(){
		PhotonNetwork.CreateRoom (null);
		Debug.Log ("部屋入室失敗");
	}

	void OnGUI(){
		GUILayout.Label (PhotonNetwork.connectionStateDetailed.ToString());
	}
}
