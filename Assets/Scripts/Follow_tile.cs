using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow_tile : MonoBehaviour {

    GameObject Player;
    float time;

	// Use this for initialization
	void Start () {
        time = 0;
        Player = GameObject.Find("enmship");
	}
	
	// Update is called once per frame
	void Update () {
        time += Time.deltaTime;
        gameObject.transform.position = Vector3.MoveTowards(transform.position, Player.transform.position, 3f);
        if (time > 2.5f)
        {
            Destroy(gameObject);
        }
        transform.Rotate(0, 0, Time.deltaTime * 360);
	}
}
