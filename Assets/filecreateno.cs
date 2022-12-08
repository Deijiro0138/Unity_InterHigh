using UnityEngine;
using System.Collections;
using System.IO;
using System.Text;
public class filecreateno : MonoBehaviour {

	// Use this for initialization
	void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
        if (File.Exists("1n.txt"))
        {
            // ファイルが存在する.
        }
        else
        {
            FileStream f = new FileStream("1n.txt", FileMode.Create, FileAccess.Write);
            Encoding sjisEnc1 = Encoding.GetEncoding("UTF-8");
            StreamWriter writer1 = new StreamWriter(f, sjisEnc1);
            writer1.WriteLine(0);
            writer1.Close();
        }
        if (File.Exists("top.txt"))
        {
        }
        else {
            FileStream k = new FileStream("top.txt", FileMode.Create, FileAccess.Write);
            Encoding sjisEnc5 = Encoding.GetEncoding("UTF-8");
            StreamWriter writer5 = new StreamWriter(k, sjisEnc5);
            writer5.WriteLine("");
            writer5.Close();
        }
    }
}
