using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy1 : MonoBehaviour {
    int health=100;
	// Use this for initialization
	void Start () {
		
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
		
	}
}
