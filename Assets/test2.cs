using UnityEngine;
using System.Collections;
using System.IO;
using System.Text;
using UnityEngine.UI;

public class test2 : MonoBehaviour {
    int top;
    int second;
    int three;
    int four;
    int five;
    public static int score;
    public static int hantei;
    
    // Use this for initialization
    void Start()
    {
        hantei = 0;
    }
    void sorting()
    {
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
        if (score > top)
        {
            FileStream r = new FileStream("1.txt", FileMode.Create, FileAccess.Write);
            Encoding sjisEnc1 = Encoding.GetEncoding("UTF-8");
            StreamWriter writer1 = new StreamWriter(r, sjisEnc1);
            writer1.WriteLine(score);
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
        }
        else
        if (score > three)
        {

            FileStream y = new FileStream("3.txt", FileMode.Create, FileAccess.Write);
            Encoding sjisEnc3 = Encoding.GetEncoding("UTF-8");
            StreamWriter writer3 = new StreamWriter(y, sjisEnc3);
            writer3.WriteLine(score);
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
        if (score > second)
        {

            FileStream t = new FileStream("2.txt", FileMode.Create, FileAccess.Write);
            Encoding sjisEnc2 = Encoding.GetEncoding("UTF-8");
            StreamWriter writer2 = new StreamWriter(t, sjisEnc2);
            writer2.WriteLine(score);
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
        }
        else
        if (score > four)
        {

            FileStream u = new FileStream("4.txt", FileMode.Create, FileAccess.Write);
            Encoding sjisEnc4 = Encoding.GetEncoding("UTF-8");
            StreamWriter writer4 = new StreamWriter(u, sjisEnc4);
            writer4.WriteLine(score);
            writer4.Close();
            FileStream q = new FileStream("5.txt", FileMode.Create, FileAccess.Write);
            Encoding sjisEnc6 = Encoding.GetEncoding("UTF-8");
            StreamWriter writer6 = new StreamWriter(q, sjisEnc6);
            writer6.WriteLine(four);
            writer6.Close();
        }
        else
        if (score > five)
        {

            FileStream i = new FileStream("5.txt", FileMode.Create, FileAccess.Write);
            Encoding sjisEnc5 = Encoding.GetEncoding("UTF-8");
            StreamWriter writer5 = new StreamWriter(i, sjisEnc5);
            writer5.WriteLine(score);
            writer5.Close();
        }
    }
        void Update()
    {
            if (hantei == 1)
            {
            
            sorting();
                Debug.Log("ok");
        }
        }
    }
       
	
	// Update is called once per frame

