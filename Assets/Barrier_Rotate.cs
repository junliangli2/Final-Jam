using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barrier_Rotate : MonoBehaviour {

    public float rotateRate;
    float livintime = 0;
    // Use this for initialization
    void Start () {
        rotateRate = 10;
        livintime = 3;
    }
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(0, 0, -rotateRate);
        livintime -= Time.deltaTime;
        if (livintime < 0)
        {
            this.gameObject.SetActive(false);
        }
    }
}
