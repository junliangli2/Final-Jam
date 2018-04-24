using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class batery_bullets : MonoBehaviour {

 
   
    public float speed;
    private Vector3 velocity;
    float livintime;


    // Use this for initialization
    void Start()
    {
        GameObject parentOfAIShip = GameObject.Find("enemystuffs");
        GameObject AIShip = GameObject.Find("enmship");
        Vector3 aiShipPos = parentOfAIShip.transform.localPosition + AIShip.transform.localPosition;
        Vector3 bulletsPos = transform.localPosition;
        Vector3 directionVec = aiShipPos - bulletsPos;
        velocity = directionVec / 60 * speed;
        livintime = 3;
    }

    // Update is called once per frame
    void Update()
    {
        transform.localPosition += velocity;
        livintime -= Time.deltaTime;
        if (livintime < 0)
        {
            this.gameObject.SetActive(false);
        }
    }
}
