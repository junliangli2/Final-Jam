using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SuperFlash : MonoBehaviour {

    float sumtime;
    float eachtime;
    Color currentcolor;
    bool flash;

	// Use this for initialization
	void Start () {
        sumtime = 0;
        eachtime = 0;
        flash = false;
	}
	
	// Update is called once per frame
	void Update () {
        sumtime += Time.deltaTime;
        eachtime += Time.deltaTime;
        if (sumtime >= 0.5f)
        {
            sumtime = 0;
            gameObject.SetActive(false);
        }
        currentcolor = gameObject.GetComponent<Image>().color;

        if( currentcolor.a >= 1)
        {
            flash = true;
        }
        if (currentcolor.a <= 0)
        {
            flash = false;
        }

        if (flash)
        {
            currentcolor.a -= Time.deltaTime * 10;
        }
        else
        {
            currentcolor.a += Time.deltaTime * 10;
        }

        gameObject.GetComponent<Image>().color = currentcolor;
    }
}
