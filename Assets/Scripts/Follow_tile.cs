using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow_tile : MonoBehaviour {

    public GameObject Player;
    float time;

	// Use this for initialization
	void Start () {
        time = 0;
	}
	
	// Update is called once per frame
	void Update () {
        time = Time.deltaTime;
        if (time > 1f)
        {
            Destroy(gameObject);
        }
        gameObject.transform.position = Vector3.MoveTowards(transform.position, Player.transform.position, 3f);
	}
}
