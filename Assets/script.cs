using UnityEngine;
using System.Collections;
using System.IO;
using System.Text;
public class script : MonoBehaviour {

	// Use this for initialization
	void Start () {
        if (File.Exists("1.txt"))
        {
        }
        else {
            FileStream h5 = new FileStream("5.txt", FileMode.Create, FileAccess.Write);
            Encoding sjisEnc3 = Encoding.GetEncoding("Shift_JIS");
            StreamWriter writer3 = new StreamWriter(h5, sjisEnc3);
            writer3.WriteLine(0);
            writer3.Close();
            FileStream h = new FileStream("4.txt", FileMode.Create, FileAccess.Write);
            Encoding sjisEnc = Encoding.GetEncoding("Shift_JIS");
            StreamWriter writer = new StreamWriter(h, sjisEnc);
            writer.WriteLine(0);
            writer.Close();
            FileStream h1 = new FileStream("3.txt", FileMode.Create, FileAccess.Write);
            Encoding sjisEnc2 = Encoding.GetEncoding("Shift_JIS");
            StreamWriter writer5 = new StreamWriter(h1, sjisEnc2);
            writer5.WriteLine(0);
            writer5.Close();
            FileStream h3 = new FileStream("2.txt", FileMode.Create, FileAccess.Write);
            Encoding sjisEnc0 = Encoding.GetEncoding("Shift_JIS");
            StreamWriter writer0 = new StreamWriter(h3, sjisEnc0);
            writer0.WriteLine(0);
            writer0.Close();
            FileStream h4 = new FileStream("1.txt", FileMode.Create, FileAccess.Write);
            Encoding sjisEnc7 = Encoding.GetEncoding("Shift_JIS");
            StreamWriter writer8 = new StreamWriter(h4, sjisEnc7);
            writer8.WriteLine(0);
            writer8.Close();
        }
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
