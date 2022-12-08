using UnityEngine;
using System.Collections;
using System.IO;
using System.Text;
public class filecreatetime2 : MonoBehaviour {

	// Use this for initialization
	void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
        if (File.Exists("3.txt"))
        {
        }
        else {
            FileStream h = new FileStream("3.txt", FileMode.Create, FileAccess.Write);
            Encoding sjisEnc3 = Encoding.GetEncoding("UTF-8");
            StreamWriter writer3 = new StreamWriter(h, sjisEnc3);
            writer3.WriteLine(0);
            writer3.Close();
        }
        if (File.Exists("threen.txt"))
        {
        }
        else {
            FileStream k = new FileStream("threen.txt", FileMode.Create, FileAccess.Write);
            Encoding sjisEnc5 = Encoding.GetEncoding("UTF-8");
            StreamWriter writer5 = new StreamWriter(k, sjisEnc5);
            writer5.WriteLine("");
            writer5.Close();
        }
    }
}
