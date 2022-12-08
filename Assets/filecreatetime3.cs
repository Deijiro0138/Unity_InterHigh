using UnityEngine;
using System.Collections;
using System.IO;
using System.Text;
public class filecreatetime3 : MonoBehaviour {

	// Use this for initialization
	void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
        if (File.Exists("4.txt"))
        {
        }
        else {
            FileStream h = new FileStream("4.txt", FileMode.Create, FileAccess.Write);
            Encoding sjisEnc3 = Encoding.GetEncoding("UTF-8");
            StreamWriter writer3 = new StreamWriter(h, sjisEnc3);
            writer3.WriteLine(0);
            writer3.Close();
        }
        if (File.Exists("fourn.txt")) { }
        else {
            FileStream j = new FileStream("fourn.txt", FileMode.Create, FileAccess.Write);
            Encoding sjisEnc4 = Encoding.GetEncoding("UTF-8");
            StreamWriter writer4 = new StreamWriter(j, sjisEnc4);
            writer4.WriteLine("");
            writer4.Close();
        }
    }
}
