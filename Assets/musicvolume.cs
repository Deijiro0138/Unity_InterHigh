using UnityEngine;
using System.Collections;
using UnityEngine.Audio;
public class musicvolume : MonoBehaviour {
    public AudioMixer mixer;
	// Use this for initialization
	void Start () {
	
	}
	public void ChangeMusicVolume(float vol)
    {
        mixer.SetFloat("MusicVolume",vol);
    }
    public void ChangeSfxVolume(float vol)
    {
        mixer.SetFloat("SfxVolume",vol);
    }
	// Update is called once per frame
	void Update () {
	
	}
    public void Back()
    {
        Application.LoadLevel("option");
    }
}
