using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Suicider_Attack : MonoBehaviour {

   // public GameObject AIShip;
    public float speed;
    private Vector3 velocity;
    float livintime = 0;

    // Use this for initialization
    void Start () {
        //Get the coordinates of the AIship and attack that point
        GameObject parentOfAIShip = GameObject.Find("enemystuffs");
        GameObject AIShip = GameObject.Find("enmship"); 
        Vector3 aiShipPos = parentOfAIShip.transform.localPosition+AIShip.transform.localPosition;
       // Debug.Log(AIShip.transform.position);
        //Debug.Log(transform.position);
        Vector3 directionVec = aiShipPos - transform.localPosition;
        velocity = directionVec / 60 * speed;
        livintime = 3;
    }
	
	// Update is called once per frame
	void Update () {
        transform.localPosition += velocity;
        livintime -= Time.deltaTime;
        if (livintime < 0)
        {
            this.gameObject.SetActive(false);
        }
    }
}
