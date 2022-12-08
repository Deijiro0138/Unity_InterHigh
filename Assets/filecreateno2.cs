using UnityEngine;
using System.Collections;
using System.IO;
using System.Text;
public class filecreateno2 : MonoBehaviour {

	// Use this for initialization
	void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
        if (File.Exists("3n.txt"))
        {
        }
        else {
            FileStream h = new FileStream("3n.txt", FileMode.Create, FileAccess.Write);
            Encoding sjisEnc3 = Encoding.GetEncoding("UTF-8");
            StreamWriter writer3 = new StreamWriter(h, sjisEnc3);
            writer3.WriteLine(0);
            writer3.Close();
        }
        if (File.Exists("three.txt"))
        {
        }
        else {
            FileStream k = new FileStream("three.txt", FileMode.Create, FileAccess.Write);
            Encoding sjisEnc5 = Encoding.GetEncoding("UTF-8");
            StreamWriter writer5 = new StreamWriter(k, sjisEnc5);
            writer5.WriteLine("");
            writer5.Close();
        }
    }
}
