using UnityEngine;
using System.Collections;
using System.IO;
using System.Text;
using UnityEngine.UI;
public class kousin : MonoBehaviour {
    public Text name;
    string naming;
    string topname;
    string secondname;
    string threename;
    string fourname;
    string fivename;
    int top;
    int second;
    int three;
    int four;
    int five;
    public static int score4;
    // Use this for initialization
    void Start () {
	}
	// Update is called once per frame
	void Update () {
        naming = name.text;
    }
     public void sorting()
    {
        naming = name.text;
        FileStream fji = new FileStream("top.txt", FileMode.Open, FileAccess.Read);
        StreamReader reader1ji = new StreamReader(fji);
                topname = reader1ji.ReadLine();
            reader1ji.Close();
        FileStream gji = new FileStream("second.txt", FileMode.Open, FileAccess.Read);
        StreamReader reader2ji = new StreamReader(gji);
                secondname = reader2ji.ReadLine();
            reader2ji.Close();
        FileStream hji = new FileStream("three.txt", FileMode.Open, FileAccess.Read);
        StreamReader reader3ji = new StreamReader(hji);
                threename = reader3ji.ReadLine();
            reader3ji.Close();
        FileStream jji = new FileStream("four.txt", FileMode.Open, FileAccess.Read);
        StreamReader reader4ji = new StreamReader(jji);
                fourname = reader4ji.ReadLine();
            reader4ji.Close();
        
        FileStream kji = new FileStream("five.txt", FileMode.Open, FileAccess.Read);
        StreamReader reader5ji = new StreamReader(kji);
                fivename = reader5ji.ReadLine();
            reader5ji.Close();
        
        FileStream f = new FileStream("1.txt", FileMode.Open, FileAccess.Read);
        StreamReader reader1 = new StreamReader(f);
        if (reader1 != null)
        {
            while (!reader1.EndOfStream)
            {
                top = int.Parse(reader1.ReadLine());
            }
            reader1.Close();
        }
        FileStream g = new FileStream("2.txt", FileMode.Open, FileAccess.Read);
        StreamReader reader2 = new StreamReader(g);
        if (reader2 != null)
        {
            while (!reader2.EndOfStream)
            {
                second = int.Parse(reader2.ReadLine());
            }
            reader2.Close();
        }
        FileStream h = new FileStream("3.txt", FileMode.Open, FileAccess.Read);
        StreamReader reader3 = new StreamReader(h);
        if (reader3 != null)
        {
            while (!reader3.EndOfStream)
            {
                three = int.Parse(reader3.ReadLine());
            }
            reader3.Close();
        }
        FileStream j = new FileStream("4.txt", FileMode.Open, FileAccess.Read);
        StreamReader reader4 = new StreamReader(j);
        if (reader4 != null)
        {
            while (!reader4.EndOfStream)
            {
                four = int.Parse(reader4.ReadLine());
            }
            reader4.Close();
        }
        FileStream k = new FileStream("5.txt", FileMode.Open, FileAccess.Read);
        StreamReader reader5 = new StreamReader(k);
        if (reader5 != null)
        {
            while (!reader5.EndOfStream)
            {
                five = int.Parse(reader5.ReadLine());
            }
            reader5.Close();
        }
        if (score4 > top)
        {
            FileStream r = new FileStream("1.txt", FileMode.Create, FileAccess.Write);
            Encoding sjisEnc1 = Encoding.GetEncoding("UTF-8");
            StreamWriter writer1 = new StreamWriter(r, sjisEnc1);
            writer1.WriteLine(score4);
            writer1.Close();
            FileStream z = new FileStream("2.txt", FileMode.Create, FileAccess.Write);
            Encoding sjisEnc12 = Encoding.GetEncoding("UTF-8");
            StreamWriter writer12 = new StreamWriter(z, sjisEnc12);
            writer12.WriteLine(top);
            writer12.Close();
            FileStream x = new FileStream("3.txt", FileMode.Create, FileAccess.Write);
            Encoding sjisEnc13 = Encoding.GetEncoding("UTF-8");
            StreamWriter writer13 = new StreamWriter(x, sjisEnc13);
            writer13.WriteLine(second);
            writer13.Close();
            FileStream c = new FileStream("4.txt", FileMode.Create, FileAccess.Write);
            Encoding sjisEnc14 = Encoding.GetEncoding("UTF-8");
            StreamWriter writer14 = new StreamWriter(c, sjisEnc14);
            writer14.WriteLine(three);
            writer14.Close();
            FileStream v = new FileStream("5.txt", FileMode.Create, FileAccess.Write);
            Encoding sjisEnc15 = Encoding.GetEncoding("UTF-8");
            StreamWriter writer15 = new StreamWriter(v, sjisEnc15);
            writer15.WriteLine(four);
            writer15.Close();
            //
            FileStream rji = new FileStream("top.txt", FileMode.Create, FileAccess.Write);
            Encoding sjisEnc1ji = Encoding.GetEncoding("UTF-8");
            StreamWriter writer1ji = new StreamWriter(rji, sjisEnc1ji);
            writer1.WriteLine(naming);
            writer1.Close();
            FileStream zji = new FileStream("second.txt", FileMode.Create, FileAccess.Write);
            Encoding sjisEnc12ji = Encoding.GetEncoding("UTF-8");
            StreamWriter writer12ji = new StreamWriter(zji, sjisEnc12ji);
            writer12ji.WriteLine(topname);
            writer12ji.Close();
            FileStream xji = new FileStream("three.txt", FileMode.Create, FileAccess.Write);
            Encoding sjisEnc13ji = Encoding.GetEncoding("UTF-8");
            StreamWriter writer13ji = new StreamWriter(xji, sjisEnc13ji);
            writer13ji.WriteLine(secondname);
            writer13ji.Close();
            FileStream cji = new FileStream("four.txt", FileMode.Create, FileAccess.Write);
            Encoding sjisEnc14ji = Encoding.GetEncoding("UTF-8");
            StreamWriter writer14ji = new StreamWriter(cji, sjisEnc14ji);
            writer14ji.WriteLine(threename);
            writer14ji.Close();
            FileStream vji = new FileStream("five.txt", FileMode.Create, FileAccess.Write);
            Encoding sjisEnc15ji = Encoding.GetEncoding("UTF-8");
            StreamWriter writer15ji = new StreamWriter(vji, sjisEnc15ji);
            writer15ji.WriteLine(fourname);
            writer15ji.Close();
        }
        else
        if (score4 > second)
        {

            FileStream yji = new FileStream("three.txt", FileMode.Create, FileAccess.Write);
            Encoding sjisEnc3ji = Encoding.GetEncoding("UTF-8");
            StreamWriter writer3ji = new StreamWriter(yji, sjisEnc3ji);
            writer3ji.WriteLine(naming);
            writer3ji.Close();
            FileStream wji = new FileStream("four.txt", FileMode.Create, FileAccess.Write);
            Encoding sjisEnc7ji = Encoding.GetEncoding("UTF-8");
            StreamWriter writer7ji = new StreamWriter(wji, sjisEnc7ji);
            writer7ji.WriteLine(threename);
            writer7ji.Close();
            FileStream eji = new FileStream("five.txt", FileMode.Create, FileAccess.Write);
            Encoding sjisEnc8ji = Encoding.GetEncoding("UTF-8");
            StreamWriter writer8ji = new StreamWriter(eji, sjisEnc8ji);
            writer8ji.WriteLine(fourname);
            writer8ji.Close();

            FileStream t = new FileStream("2.txt", FileMode.Create, FileAccess.Write);
            Encoding sjisEnc2 = Encoding.GetEncoding("UTF-8");
            StreamWriter writer2 = new StreamWriter(t, sjisEnc2);
            writer2.WriteLine(score4);
            writer2.Close();
            FileStream a = new FileStream("3.txt", FileMode.Create, FileAccess.Write);
            Encoding sjisEnc9 = Encoding.GetEncoding("UTF-8");
            StreamWriter writer9 = new StreamWriter(a, sjisEnc9);
            writer9.WriteLine(second);
            writer9.Close();
            FileStream s = new FileStream("4.txt", FileMode.Create, FileAccess.Write);
            Encoding sjisEnc10 = Encoding.GetEncoding("UTF-8");
            StreamWriter writer10 = new StreamWriter(s, sjisEnc10);
            writer10.WriteLine(three);
            writer10.Close();
            FileStream d = new FileStream("5.txt", FileMode.Create, FileAccess.Write);
            Encoding sjisEnc11 = Encoding.GetEncoding("UTF-8");
            StreamWriter writer11 = new StreamWriter(d, sjisEnc11);
            writer11.WriteLine(four);
            writer11.Close();
            //
            FileStream tji = new FileStream("second.txt", FileMode.Create, FileAccess.Write);
            Encoding sjisEnc2ji = Encoding.GetEncoding("UTF-8");
            StreamWriter writer2ji = new StreamWriter(tji, sjisEnc2ji);
            writer2ji.WriteLine(naming);
            writer2ji.Close();
            FileStream aji = new FileStream("three.txt", FileMode.Create, FileAccess.Write);
            Encoding sjisEnc9ji = Encoding.GetEncoding("UTF-8");
            StreamWriter writer9ji = new StreamWriter(aji, sjisEnc9ji);
            writer9ji.WriteLine(secondname);
            writer9ji.Close();
            FileStream sji = new FileStream("four.txt", FileMode.Create, FileAccess.Write);
            Encoding sjisEnc10ji = Encoding.GetEncoding("UTF-8");
            StreamWriter writer10ji = new StreamWriter(sji, sjisEnc10ji);
            writer10ji.WriteLine(threename);
            writer10ji.Close();
            FileStream dji = new FileStream("five.txt", FileMode.Create, FileAccess.Write);
            Encoding sjisEnc11ji = Encoding.GetEncoding("UTF-8");
            StreamWriter writer11ji = new StreamWriter(dji, sjisEnc11ji);
            writer11ji.WriteLine(fourname);
            writer11ji.Close();
        }
        else
        if (score4 > three)
        {
            FileStream y = new FileStream("3.txt", FileMode.Create, FileAccess.Write);
            Encoding sjisEnc3 = Encoding.GetEncoding("UTF-8");
            StreamWriter writer3 = new StreamWriter(y, sjisEnc3);
            writer3.WriteLine(score4);
            writer3.Close();
            FileStream w = new FileStream("4.txt", FileMode.Create, FileAccess.Write);
            Encoding sjisEnc7 = Encoding.GetEncoding("UTF-8");
            StreamWriter writer7 = new StreamWriter(w, sjisEnc7);
            writer7.WriteLine(three);
            writer7.Close();
            FileStream e = new FileStream("5.txt", FileMode.Create, FileAccess.Write);
            Encoding sjisEnc8 = Encoding.GetEncoding("UTF-8");
            StreamWriter writer8 = new StreamWriter(e, sjisEnc8);
            writer8.WriteLine(four);
            writer8.Close();

            
        }
        else
        if (score4 > four)
        {

            FileStream u = new FileStream("4.txt", FileMode.Create, FileAccess.Write);
            Encoding sjisEnc4 = Encoding.GetEncoding("UTF-8");
            StreamWriter writer4 = new StreamWriter(u, sjisEnc4);
            writer4.WriteLine(score4);
            writer4.Close();
            FileStream q = new FileStream("5.txt", FileMode.Create, FileAccess.Write);
            Encoding sjisEnc6 = Encoding.GetEncoding("UTF-8");
            StreamWriter writer6 = new StreamWriter(q, sjisEnc6);
            writer6.WriteLine(four);
            writer6.Close();

            //
            FileStream uji = new FileStream("four.txt", FileMode.Create, FileAccess.Write);
            Encoding sjisEnc4ji = Encoding.GetEncoding("UTF-8");
            StreamWriter writer4ji = new StreamWriter(uji, sjisEnc4ji);
            writer4ji.WriteLine(naming);
            writer4ji.Close();
            FileStream qji = new FileStream("five.txt", FileMode.Create, FileAccess.Write);
            Encoding sjisEnc6ji = Encoding.GetEncoding("UTF-8");
            StreamWriter writer6ji = new StreamWriter(qji, sjisEnc6ji);
            writer6ji.WriteLine(fourname);
            writer6ji.Close();
        }
        else
        if (score4 > five)
        {

            FileStream i = new FileStream("5.txt", FileMode.Create, FileAccess.Write);
            Encoding sjisEnc5 = Encoding.GetEncoding("UTF-8");
            StreamWriter writer5 = new StreamWriter(i, sjisEnc5);
            writer5.WriteLine(score4);
            writer5.Close();
            //
            FileStream j1 = new FileStream("five.txt", FileMode.Create, FileAccess.Write);
            Encoding sjisEnc = Encoding.GetEncoding("UTF-8");
            StreamWriter writerji = new StreamWriter(j1, sjisEnc);
            writerji.WriteLine(naming);
            writerji.Close();
        }
    }
}
