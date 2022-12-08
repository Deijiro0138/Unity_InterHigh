using UnityEngine;
using System.Collections;

public class sound : MonoBehaviour {
    AudioSource audio;
	// Use this for initialization
	void Start () {
        audio = gameObject.GetComponent<AudioSource>();
        audio.PlayOneShot(audio.clip);
    }
	
	// Update is called once per frame
	void Update () {
        if (gamemanager.music == true)
        {
            audio.Pause();
        }
	}
}
