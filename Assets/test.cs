using UnityEngine;
using System.Collections;
using System.IO;
using System.Text;

public class test : MonoBehaviour {

	// Use this for initialization
	void Start ()
    {
        
        
       
        
       
        
    }
	// Update is called once per frame
	void Update () {
        if (File.Exists("5.txt"))
        {
        }
        else {
            FileStream k = new FileStream("5.txt", FileMode.Create, FileAccess.Write);
            Encoding sjisEnc5 = Encoding.GetEncoding("UTF-8");
            StreamWriter writer5 = new StreamWriter(k, sjisEnc5);
            writer5.WriteLine(0);
            writer5.Close();
        }
        if (File.Exists("fiven.txt"))
        {
        }
        else {
            FileStream k = new FileStream("fiven.txt", FileMode.Create, FileAccess.Write);
            Encoding sjisEnc5 = Encoding.GetEncoding("UTF-8");
            StreamWriter writer5 = new StreamWriter(k, sjisEnc5);
            writer5.WriteLine("");
            writer5.Close();
        }
    }
}
