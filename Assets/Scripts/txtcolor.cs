using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class txtcolor : MonoBehaviour {
    Color c;
    float r=.5f;
    float g=.5f;
    float b=.5f;
    float a5 = 0;
    GameObject sub;
    [SerializeField]
    Image img1;
    [SerializeField]
    Image img2;
    [SerializeField]
    Image img3;
    [SerializeField]
    Text txt1;
    [SerializeField]
    Text txt2;
    public GameObject yi;
    public GameObject er;
    public GameObject wu;
    public GameObject liu;
    public Image im1;
    public Image im2;
    public Image im3;
    public Image im4;
    Color c1;
    Color c11;
    Color c2;
    Color c22;

    Color c3;
    Color c33;
    Color c333;
    Color c3333;
    Color c33333;
    Color c333333;
    public float a1 = 1;
     float a2 = 1;
    bool fdstate = false;
    bool kaistate = false;
    bool mei = false;
    float tingtime = 0;
    // Use this for initialization
    void Start () {
        sub = GameObject.Find("rest");
        this.GetComponent<Text>().color = Color.white;
         c3=im1.color;
         c33=im2.color;
         c333=im3.color;
         c3333=im4.color;
        c33333 = wu.GetComponent<Text>().color;
        c333333 = liu.GetComponent<Text>().color;
    }

    // Update is called once per frame
    void Update()
    {   
        if (a1 <= 0.2f)
        {
            sub.GetComponent<mov>().shouldstart = true;
            kaistate = true;

        }
        if (kaistate == true && mei == false && img3.GetComponent<RectTransform>().sizeDelta.y < 50)
        {
         
            a5 += .04f;
            c3.a = a5;
            c33.a = a5;
            c333.a = a5;
            c3333.a = a5;
            c33333.a = a5;
            c333333.a = a5;
            im1.color=c3 ;
            im2.color = c33;
            im3.color = c333;
             im4.color = c3333;
            wu.GetComponent<Text>().color = c33333;
            liu.GetComponent<Text>().color = c333333;
            img3.GetComponent<RectTransform>().sizeDelta += new Vector2(0, 2);
            img3.transform.GetChild(0).GetComponent<RectTransform>().sizeDelta += new Vector2(0, 2);

        }
        
        if(kaistate==true&&mei==false&& img3.GetComponent<RectTransform>().sizeDelta.y >= 50)
        {

            tingtime += Time.deltaTime;


        }
        if (tingtime > 2) { mei = true;yi.GetComponent<danmu>().starto = true;
            er.GetComponent<enemymove>().starto = true;
            yi.GetComponent<SpawnShips>().starto = true;
        }
        if (mei == true&& img3.GetComponent<RectTransform>().sizeDelta.y>0)
        {
            img3.GetComponent<RectTransform>().sizeDelta += new Vector2(0, -2);
            img3.transform.GetChild(0).GetComponent<RectTransform>().sizeDelta += new Vector2(0, -2);
        }

        c1 = img1.color;
        c11 = txt1.color;
        c2 = img2.color;
        c22 = txt2.color;

        c1.a = a1;
        c11.a = a1;
        c2.a = a1;
        c22.a = a1;
        if (Input.GetKeyDown(KeyCode.Space))
        {
            fdstate = true;

        }
        if (fdstate == true)
        {
            a1 -= .02f;
            img1.color = c1;
            img2.color = c2;
            txt1.color = c11;
            txt2.color = c22;

        }


        if (fdstate == false)
        {
            r = r + Random.Range(-.01f, .01f);
            g = g + Random.Range(-.01f, .01f);
            b = b + Random.Range(-.01f, .01f);

            c.r = r;
            c.g = g;
            c.b = b;
            c.a = 1;
            this.GetComponent<Text>().color = c;
        }

      
    }
}
