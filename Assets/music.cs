using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class music : MonoBehaviour
{
    private GameObject[] sound;
    int lenth;
    public bool DontDestroyEnabled = true;
    string sceneName;
    AudioSource audio;
    bool ts;
    // Use this for initialization
    void Start()
    {
        audio = gameObject.GetComponent<AudioSource>();
        ts = true;
        audio.Play();
        sound = GameObject.FindGameObjectsWithTag("haikei");
        lenth = sound.Length;
    }

    // Update is called once per frame
    void Update()
    {
        if (lenth == 2)
        {
            gameObject.SetActive(false);
        }
        sceneName = Application.loadedLevelName;
        if (DontDestroyEnabled)
        {
            DontDestroyOnLoad(this);
            
            
        }
        if ((sceneName == "catch" || sceneName == "catchidea" || sceneName == "option")&&ts==true)
        {
            ts = false;
            audio.Pause(); 
        }else if (sceneName == "online"&&ts==false)
        {
            audio.Play();
            ts = true;
            
        }/*else if (sceneName == "title"&&ts==false)
        {
            audio.time = 0f;
            audio.Play();
        }*/
    }
}