using UnityEngine;
using System.Collections;
using System.IO;
using System.Text;
using UnityEngine.UI;

public class testing : MonoBehaviour {

	// Use this for initialization
	void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
        if (File.Exists("5n.txt"))
        {
        }
        else {
            FileStream k = new FileStream("5n.txt", FileMode.Create, FileAccess.Write);
            Encoding sjisEnc5 = Encoding.GetEncoding("UTF-8");
            StreamWriter writer5 = new StreamWriter(k, sjisEnc5);
            writer5.WriteLine(0);
            writer5.Close();
        }
        if (File.Exists("five.txt"))
        {
        }
        else {
            FileStream k = new FileStream("five.txt", FileMode.Create, FileAccess.Write);
            Encoding sjisEnc5 = Encoding.GetEncoding("UTF-8");
            StreamWriter writer5 = new StreamWriter(k, sjisEnc5);
            writer5.WriteLine("");
            writer5.Close();
        }
    }
}
