using UnityEngine;
using System.Collections;
using System.IO;
using System.Text;
public class filecreatetime1 : MonoBehaviour {

	// Use this for initialization
	void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
        if (File.Exists("2.txt"))
        {
        }
        else {
            FileStream g = new FileStream("2.txt", FileMode.Create, FileAccess.Write);
            Encoding sjisEnc2 = Encoding.GetEncoding("UTF-8");
            StreamWriter writer2 = new StreamWriter(g, sjisEnc2);
            writer2.WriteLine(0);
            writer2.Close();
        }
        if (File.Exists("secondn.txt"))
        {
        }
        else {
            FileStream k = new FileStream("secondn.txt", FileMode.Create, FileAccess.Write);
            Encoding sjisEnc5 = Encoding.GetEncoding("UTF-8");
            StreamWriter writer5 = new StreamWriter(k, sjisEnc5);
            writer5.WriteLine("");
            writer5.Close();
        }
    }
}
