using UnityEngine;
using System.Collections;
using System.IO;
using System.Text;
public class filecreateno3 : MonoBehaviour {

	// Use this for initialization
	void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
        if (File.Exists("4n.txt")) { }
        else {
            FileStream j = new FileStream("4n.txt", FileMode.Create, FileAccess.Write);
            Encoding sjisEnc4 = Encoding.GetEncoding("UTF-8");
            StreamWriter writer4 = new StreamWriter(j, sjisEnc4);
            writer4.WriteLine(0);
            writer4.Close();
        }
        if (File.Exists("four.txt"))
        {
        }
        else {
            FileStream k = new FileStream("four.txt", FileMode.Create, FileAccess.Write);
            Encoding sjisEnc5 = Encoding.GetEncoding("UTF-8");
            StreamWriter writer5 = new StreamWriter(k, sjisEnc5);
            writer5.WriteLine("");
            writer5.Close();
        }
    }
}
