using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AvoidBullets : MonoBehaviour {

    [SerializeField]
    float movetime;
    [SerializeField]
    int movedirection;
    int speed;

	// Use this for initialization
	void Start () {
        movetime = 0;
        movedirection = 0;
        speed = 1;
	}
	
	// Update is called once per frame
	void Update () {
		if (movetime > 0)
        {
            movetime -= Time.deltaTime;
            if (movedirection == 1)
            {
                transform.Translate( -200 * Time.deltaTime, 0f, 0f);
            }
            else if (movedirection == 2)
            {
                transform.Translate( 200 * Time.deltaTime, 0f, 0f);
            }
        }
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Respawn")
        {
            //Debug.Log("well");
            movetime = 0.5f;
            if (other.transform.position.x > transform.position.x)
            {
                movedirection = 1;
            }
            else
            {
                movedirection = 2;
            }
        }
    }
}
