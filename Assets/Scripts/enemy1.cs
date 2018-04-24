using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class enemy1 : MonoBehaviour {


    int health = 100;
    GameObject HPforPlayer;

	// Use this for initialization
	void Start () {
        HPforPlayer = GameObject.Find("HPforPlayer");
	}
	int gethealth()
    {

        return health;

    }

   public void jianhealth(int jianduoshao) {

        health -= jianduoshao;
    }
	// Update is called once per frame
	void Update () {
        HPforPlayer.GetComponent<Text>().text = health.ToString();
	}
}
