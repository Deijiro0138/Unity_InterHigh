using UnityEngine;
using System.Collections;
using System;
using System.IO;
using System.Text;
using UnityEngine.UI;
public class file : MonoBehaviour {
    public Text s;
    public Text s1;
    public Text s2;
    public Text s3;
    public Text s4;
    public Text sc1;
    public Text sc2;
    public Text sc3;
    public Text sc4;
    public Text sc5;
    int top;
    int second;
    int three;
    int four;
    int five;
    int top1;
    int second1;
    int three1;
    int four1;
    int five1;
    string topname;
    string secondname;
    string threename;
    string fourname;
    string fivename;
    string topname1;
    string secondname1;
    string threename1;
    string fourname1;
    string fivename1;
    // Use this for initialization
    void Start()
    {
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

        FileStream kj = new FileStream("five.txt", FileMode.Open, FileAccess.Read);
        StreamReader reader5j = new StreamReader(kj);
        fivename = reader5j.ReadLine();
        reader5j.Close();
        FileStream fj = new FileStream("topn.txt", FileMode.Open, FileAccess.Read);
        StreamReader reader1j = new StreamReader(fj);
        topname = reader1j.ReadLine();
        reader1j.Close();
        FileStream gj = new FileStream("secondn.txt", FileMode.Open, FileAccess.Read);
        StreamReader reader2j = new StreamReader(gj);
        secondname = reader2j.ReadLine();
        reader2j.Close();
        FileStream hj = new FileStream("threen.txt", FileMode.Open, FileAccess.Read);
        StreamReader reader3j = new StreamReader(hj);
        threename = reader3j.ReadLine();
        reader3j.Close();
        FileStream jj = new FileStream("fourn.txt", FileMode.Open, FileAccess.Read);
        StreamReader reader4j = new StreamReader(jj);
        fourname = reader4j.ReadLine();
        reader4j.Close();

        FileStream kjn = new FileStream("fiven.txt", FileMode.Open, FileAccess.Read);
        StreamReader reader5jn = new StreamReader(kjn);
        fivename = reader5jn.ReadLine();
        reader5jn.Close();
        FileStream f = new FileStream("1n.txt", FileMode.Open, FileAccess.Read);
        StreamReader reader1 = new StreamReader(f);
        if (reader1 != null)
        {
            while (!reader1.EndOfStream)
            {
                top1 = int.Parse(reader1.ReadLine());
            }
            reader1.Close();
        }
        FileStream g = new FileStream("2n.txt", FileMode.Open, FileAccess.Read);
        StreamReader reader2 = new StreamReader(g);
        if (reader2 != null)
        {
            while (!reader2.EndOfStream)
            {
                second1 = int.Parse(reader2.ReadLine());
            }
            reader2.Close();
        }
        FileStream h = new FileStream("3n.txt", FileMode.Open, FileAccess.Read);
        StreamReader reader3 = new StreamReader(h);
        if (reader3 != null)
        {
            while (!reader3.EndOfStream)
            {
                three1 = int.Parse(reader3.ReadLine());
            }
            reader3.Close();
        }
        FileStream j = new FileStream("4n.txt", FileMode.Open, FileAccess.Read);
        StreamReader reader4 = new StreamReader(j);
        if (reader4 != null)
        {
            while (!reader4.EndOfStream)
            {
                four1 = int.Parse(reader4.ReadLine());
            }
            reader4.Close();
        }
        FileStream k = new FileStream("5n.txt", FileMode.Open, FileAccess.Read);
        StreamReader reader5 = new StreamReader(k);
        if (reader5 != null)
        {
            while (!reader5.EndOfStream)
            {
                five1 = int.Parse(reader5.ReadLine());
            }
            reader5.Close();
        }


        FileStream f1 = new FileStream("1.txt", FileMode.Open, FileAccess.Read);
        StreamReader reader10 = new StreamReader(f1);
        if (reader1 != null)
        {
            while (!reader10.EndOfStream)
            {
                top = int.Parse(reader10.ReadLine());
            }
            reader10.Close();
        }
        FileStream g1 = new FileStream("2.txt", FileMode.Open, FileAccess.Read);
        StreamReader reader20 = new StreamReader(g1);
        if (reader20 != null)
        {
            while (!reader20.EndOfStream)
            {
                second = int.Parse(reader20.ReadLine());
            }
            reader20.Close();
        }
        FileStream hi = new FileStream("3.txt", FileMode.Open, FileAccess.Read);
        StreamReader reader30 = new StreamReader(hi);
        if (reader30 != null)
        {
            while (!reader30.EndOfStream)
            {
                three = int.Parse(reader30.ReadLine());
            }
            reader30.Close();
        }
        FileStream m = new FileStream("4.txt", FileMode.Open, FileAccess.Read);
        StreamReader reader40 = new StreamReader(m);
        if (reader40 != null)
        {
            while (!reader40.EndOfStream)
            {
                four = int.Parse(reader40.ReadLine());
            }
            reader40.Close();
        }
        FileStream p = new FileStream("5.txt", FileMode.Open, FileAccess.Read);
        StreamReader reader50 = new StreamReader(p);
        if (reader50 != null)
        {
            while (!reader50.EndOfStream)
            {
                five = int.Parse(reader50.ReadLine());
            }
            reader50.Close();
        }
    }
    void Update()
    {
        s.text = "1位　"+top.ToString();
        s1.text = "2位　"+second.ToString();
        s2.text = "3位　"+three.ToString();
        s3.text = "4位　"+four.ToString();
        s4.text = "5位　"+five.ToString();
        sc1.text = "1位　"+top1.ToString();
        sc2.text = "2位　"+second1.ToString();
        sc3.text = "3位　"+three1.ToString();
        sc4.text = "4位　"+four1.ToString();
        sc5.text = "5位　"+five1.ToString();
    }
    
	
}
