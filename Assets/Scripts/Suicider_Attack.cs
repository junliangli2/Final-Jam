using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Suicider_Attack : MonoBehaviour {

    public GameObject AIShip;
    public float speed;
    private Vector3 velocity;


    // Use this for initialization
    void Start () {
        GameObject parentOfAIShip = GameObject.Find("enemystuffs");
        Vector3 aiShipPos = parentOfAIShip.transform.localPosition+AIShip.transform.localPosition;
        Vector3 directionVec = aiShipPos - transform.localPosition;
        velocity = directionVec / 60 * speed;
    }
	
	// Update is called once per frame
	void Update () {
        transform.localPosition += velocity;
    }
}
