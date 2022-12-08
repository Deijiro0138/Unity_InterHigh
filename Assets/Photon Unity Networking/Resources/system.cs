using UnityEngine;
using System.Collections;

public class system : Photon.MonoBehaviour {
	private Vector3 receivePosition = Vector3.zero;
	private Quaternion receiveRotation = Quaternion.identity;
	private Vector2 receiveVelocity = Vector2.zero;

	void OnPhotonSerializeView(PhotonStream stream, PhotonMessageInfo info) {
		if (stream.isWriting) {
			//データの送信
			stream.SendNext(transform.position);
			stream.SendNext(transform.rotation);
			stream.SendNext(GetComponent<Rigidbody2D>().velocity);
		} else {
			//データの受信（変数へ格納）
			receivePosition = (Vector3)stream.ReceiveNext();
			receiveRotation = (Quaternion)stream.ReceiveNext();
			receiveVelocity = (Vector2)stream.ReceiveNext();
		}
	}

	void Update() {
		
	}
}
