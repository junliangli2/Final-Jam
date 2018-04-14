﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {
    GameObject ship;
    GameObject l1left;
    GameObject l1right;
    GameObject l1up;
    GameObject l1down;
    GameObject bullp1;
    GameObject bullp2;
    GameObject bullp3;
    GameObject bullp4;
  
    [SerializeField]
    GameObject li;
 
    bool leftstate = false;
    bool rightstate = false;
    bool upstate = false;
    bool downstate = false;
    bool shootstate = false;
    float shoottime = 0;
    float speed = 3;
	// Use this for initialization
	void Start () {
        ship = GameObject.Find("ship");
        l1left = GameObject.Find("l1left");
        l1right = GameObject.Find("l1right");
        l1up = GameObject.Find("l1up");
        l1down = GameObject.Find("l1down");
        bullp1 = GameObject.Find("bullleft1");
        bullp2 = GameObject.Find("bullleft2");
        bullp3 = GameObject.Find("bullleft3");
        bullp4 = GameObject.Find("bullleft4");
        
    }
	
	// Update is called once per frame
	void Update () {
        li.GetComponent<ucup>().Resettime();
        ship.transform.localEulerAngles = new Vector3(ship.transform.localEulerAngles.x, -90, -90);
   
 



        if (leftstate == true && ship.transform.localPosition.x>l1left.transform.localPosition.x)
        {
           
            ship.transform.localPosition += new Vector3(-speed, 0, 0);
 
        }
        if (rightstate == true && ship.transform.localPosition.x < l1right.transform.localPosition.x)
        {
            ship.transform.localPosition += new Vector3(speed, 0, 0);
 
        }
        if (upstate == true && ship.transform.localPosition.z < l1up.transform.localPosition.z)
        {
            ship.transform.localPosition += new Vector3(0, 0, speed);
 
        }
        if (downstate == true && ship.transform.localPosition.z > l1down.transform.localPosition.z)
        {
            ship.transform.localPosition += new Vector3(0, 0, -speed);
 
        }
        if (shootstate == true)
        {
           
            shoottime += Time.deltaTime;
            if (shoottime >= .3f) {
                shoottime = 0;
                GameObject bul1 = Instantiate(li, bullp1.transform.position, bullp1.transform.rotation);
                bul1.transform.GetChild(0).localScale = new Vector3(36.23188f, 10, 0);
                bul1.GetComponent<ucup>().Resettime();
                GameObject bul2 = Instantiate(li, bullp2.transform.position, bullp2.transform.rotation);
                bul2.transform.GetChild(0).localScale = new Vector3(36.23188f, 10, 0);
                bul2.GetComponent<ucup>().Resettime();
                GameObject bul3 = Instantiate(li, bullp3.transform.position, bullp3.transform.rotation);
                bul3.transform.GetChild(0).localScale = new Vector3(36.23188f, 10, 0);
                bul3.GetComponent<ucup>().Resettime();
                GameObject bul4 = Instantiate(li, bullp4.transform.position, bullp4.transform.rotation);
                bul4.transform.GetChild(0).localScale = new Vector3(36.23188f, 10, 0);
                bul4.GetComponent<ucup>().Resettime();


            }

        }
        if (Input.GetKeyDown(KeyCode.J))
        {
            shootstate = true;
            shoottime = 0;
            GameObject bul1 = Instantiate(li, bullp1.transform.position, bullp1.transform.rotation);
            bul1.transform.GetChild(0).localScale = new Vector3(36.23188f, 10, 0);
            bul1.GetComponent<ucup>().Resettime();
            GameObject bul2 = Instantiate(li, bullp2.transform.position, bullp2.transform.rotation);
            bul2.transform.GetChild(0).localScale = new Vector3(36.23188f, 10, 0);
            bul2.GetComponent<ucup>().Resettime();
            GameObject bul3 = Instantiate(li, bullp3.transform.position, bullp3.transform.rotation);
            bul3.transform.GetChild(0).localScale = new Vector3(36.23188f, 10, 0);
            bul3.GetComponent<ucup>().Resettime();
            GameObject bul4 = Instantiate(li, bullp4.transform.position, bullp4.transform.rotation);
            bul4.transform.GetChild(0).localScale = new Vector3(36.23188f, 10, 0);
            bul4.GetComponent<ucup>().Resettime();
        }
        if (Input.GetKeyUp(KeyCode.J))
        {
            shootstate = false;
        }
        if (Input.GetKeyDown(KeyCode.A)){
            leftstate = true;

        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            leftstate = false;
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            rightstate = true;

        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            rightstate = false;
        }


        if (Input.GetKeyDown(KeyCode.W))
        {
            upstate = true;

        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            upstate = false;
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            downstate = true;

        }


        if (Input.GetKeyUp(KeyCode.S))
        {
            downstate = false;
        }



	}
}