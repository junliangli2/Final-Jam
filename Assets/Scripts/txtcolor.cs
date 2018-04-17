using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class txtcolor : MonoBehaviour {
    Color c;
    float r=.5f;
    float g=.5f;
    float b=.5f;
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
    Color c1;
    Color c11;
    Color c2;
    Color c22;
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
            img3.GetComponent<RectTransform>().sizeDelta += new Vector2(0, 2);
            img3.transform.GetChild(0).GetComponent<RectTransform>().sizeDelta += new Vector2(0, 2);

        }
        
        if(kaistate==true&&mei==false&& img3.GetComponent<RectTransform>().sizeDelta.y >= 50)
        {

            tingtime += Time.deltaTime;


        }
        if (tingtime > 2) { mei = true; }
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
