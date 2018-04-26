using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class enemy1 : MonoBehaviour {

    public GameObject Bosswin;
    int health = 100;
    GameObject HPforPlayer;

	// Use this for initialization
	void Start () {
        HPforPlayer = GameObject.Find("HPforPlayer");
        //Bosswin = GameObject.Find("Bosswin");
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
        if (health <= 0)
        {
            Bosswin.SetActive(true);
            Time.timeScale = 0;
        }
	}
}
