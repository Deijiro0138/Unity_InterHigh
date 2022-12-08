using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class push : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void OnClick(){
		SceneManager.LoadScene("catch");
        Time.timeScale = 1;
	}
    public void Onclicknormal()
    {
        SceneManager.LoadScene("catchidea");
        Time.timeScale = 1;
    }
    public void click()
    {
        Application.LoadLevel("network");
    }
}
