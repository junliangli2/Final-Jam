using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SuperFlash : MonoBehaviour {

    float sumtime;
    float eachtime;
    public Color currentcolor;
    bool flash;

	// Use this for initialization
	void Start () {
        sumtime = 0;
        eachtime = 0;
        flash = false;
        currentcolor = gameObject.GetComponent<Image>().color;
    }
	
	// Update is called once per frame
	void Update () {
 
      
        currentcolor.a -= .01f;
  
 

        gameObject.GetComponent<Image>().color = currentcolor;
    }
}
