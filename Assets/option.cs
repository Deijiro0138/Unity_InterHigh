using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class option : MonoBehaviour
{
    public static int dame;
    public RawImage mensu;
    public Text mensuyuu;
    public RawImage go1;
    public Text gokai;
    public static int page;
    public RawImage clickmen;
    public Text climen;
    public RawImage menue;
    public Text menu;
    public GameObject hasi;
    public RawImage mausu;
    GameObject clicking;
    public Text ma;
    private Button going;
    private Button backing;
    public RawImage ichiji;
    public Text teisi;
    public Text Score;
    public static int tensu;
    public RawImage hae;
    public Text ha;
    public Color ao;
    private Button title;
    public RawImage batsu;
    public RawImage batsu1;
    public RawImage batsu2;
    // Use this for initialization
    void Start()
    {
        tensu = 0;
        batsu.enabled = false;
        batsu1.enabled = false;
        batsu2.enabled = false;
        dame = 0;
        /*clicking = GameObject.Find("click");
        menu.color = Color.clear;
        menue.color = Color.clear;*/
        page = 0;
       going = GameObject.Find("go").GetComponent<Button>();
        backing = GameObject.Find("back").GetComponent<Button>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            Application.LoadLevel("online");
        }
        if (Input.GetKey(KeyCode.F5))
        {
            Application.LoadLevel("option");
        }
        Score.text = "SCORE:" + tensu;
        if (page == 0)
        {
            backing.gameObject.SetActive(false);
            going.gameObject.SetActive(true);
            mausu.color = ao;
            ma.color = Color.black;
            menu.color = Color.clear;
            menue.color = Color.clear;
            clickmen.color = Color.clear;
            climen.color = Color.clear;
            go1.color = Color.clear;
            gokai.color = Color.clear;
            mensu.color = Color.clear;
            mensuyuu.color = Color.clear;
            ichiji.color = Color.clear;
            teisi.color = Color.clear;
            hae.color = Color.clear;
            ha.color = Color.clear;
        }
        if (page == 1)
        {
            mausu.color = Color.clear;
            ma.color = Color.clear;
            menu.color = Color.black;
            menue.color = ao;
            clickmen.color = Color.clear;
            climen.color = Color.clear;
            backing.gameObject.SetActive(true);
            going.gameObject.SetActive(true);
            go1.color = Color.clear;
            gokai.color = Color.clear;
            mensu.color = Color.clear;
            mensuyuu.color = Color.clear;
            ichiji.color = Color.clear;
            teisi.color = Color.clear;
            hae.color = Color.clear;
            ha.color = Color.clear;
        }
        if (page == 2)
        {
            mausu.color = Color.clear;
            ma.color = Color.clear;
            menu.color = Color.clear;
            menue.color = Color.clear;
            clickmen.color = ao;
            climen.color = Color.black;
            backing.gameObject.SetActive(true);
            going.gameObject.SetActive(true);
            go1.color = Color.clear;
            gokai.color = Color.clear;
            mensu.color = Color.clear;
            mensuyuu.color = Color.clear;
            ichiji.color = Color.clear;
            teisi.color = Color.clear;
            hae.color = Color.clear;
            ha.color = Color.clear;
        }
        if (page == 3)
        {
            mausu.color = Color.clear;
            ma.color = Color.clear;
            menu.color = Color.clear;
            menue.color = Color.clear;
            clickmen.color = Color.clear;
            climen.color = Color.clear;
            backing.gameObject.SetActive(true);
            going.gameObject.SetActive(true);
            go1.color = ao;
            gokai.color = Color.black;
            mensu.color = Color.clear;
            mensuyuu.color = Color.clear;
            ichiji.color = Color.clear;
            teisi.color = Color.clear;
            hae.color = Color.clear;
            ha.color = Color.clear;
        }
        if (page == 4)
        {
            mausu.color = Color.clear;
            ma.color = Color.clear;
            menu.color = Color.clear;
            menue.color = Color.clear;
            clickmen.color = Color.clear;
            climen.color = Color.clear;
            backing.gameObject.SetActive(true);
            going.gameObject.SetActive(true);
            go1.color = Color.clear;
            gokai.color = Color.clear;
            mensu.color = ao;
            mensuyuu.color = Color.black;
            ichiji.color = Color.clear;
            teisi.color = Color.clear;
            hae.color = Color.clear;
            ha.color = Color.clear;
        }
        if (page == 5)
        {

            mausu.color = Color.clear;
            ma.color = Color.clear;
            menu.color = Color.clear;
            menue.color = Color.clear;
            clickmen.color = Color.clear;
            climen.color = Color.clear;
            backing.gameObject.SetActive(true);
            going.gameObject.SetActive(true);
            go1.color = Color.clear;
            gokai.color = Color.clear;
            mensu.color = Color.clear;
            mensuyuu.color = Color.clear;
            ichiji.color = Color.clear;
            teisi.color = Color.clear;
            hae.color = ao;
            ha.color = Color.black;
        }
        if (page == 6)
        {
            mausu.color = Color.clear;
            ma.color = Color.clear;
            menu.color = Color.clear;
            menue.color = Color.clear;
            clickmen.color = Color.clear;
            climen.color = Color.clear;
            backing.gameObject.SetActive(true);
            going.gameObject.SetActive(false);
            go1.color = Color.clear;
            gokai.color = Color.clear;
            mensu.color = Color.clear;
            mensuyuu.color = Color.clear;
            ichiji.color = ao;
            teisi.color = Color.black;
            hae.color = Color.clear;
            ha.color = Color.clear;
        }
        if (dame == 1)
        {
            batsu.enabled = true;
        }else if (dame == 2)
        {
            batsu1.enabled = true;
        }else if (dame >= 3)
        {
            batsu2.enabled = true;
        }
    }
    
}
