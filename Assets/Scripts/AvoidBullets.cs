using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AvoidBullets : MonoBehaviour {

    [SerializeField]
    float movetime;
    [SerializeField]
    int movedirection;
    public GameObject ZIS;
    int speed = 100;
<<<<<<< HEAD
=======
    [SerializeField]
    GameObject SuperFlash;
>>>>>>> parent of 9a807ef... 不给力啊

	// Use this for initialization
	void Start () {
        movetime = 0;
        movedirection = 0;
        speed = 100;
	}
	
	// Update is called once per frame
	void Update () {
		if (movetime > 0)
        {
            movetime -= Time.deltaTime;
            if (movedirection == 1)
            {
                transform.Translate( -speed * Time.deltaTime, 0f, 0f);
            }
            else if (movedirection == 2)
            {
                transform.Translate( speed * Time.deltaTime, 0f, 0f);
            }
        }
        else { ZIS.GetComponent<enemymove>().duo = false; }
	}

    private void OnTriggerEnter(Collider other)
    {   ZIS.GetComponent<enemymove>().duo = true; 
        if (other.tag == "Respawn")
        {
            //Debug.Log("well");
<<<<<<< HEAD
=======
            int supercharger = Random.Range(0, 100);
>>>>>>> parent of 9a807ef... 不给力啊
            movetime = 0.5f;
            if (other.transform.position.x > transform.position.x)
            {
                movedirection = 1;
            }
            else
            {
                movedirection = 2;
            }
<<<<<<< HEAD
=======
            if (supercharger == 50)
            {
                for (int i = 0; i < Bullets.transform.childCount; i++)
                {
                    Destroy(Bullets.transform.GetChild(i).gameObject);
                    SuperFlash.SetActive(true);
                }
            }
>>>>>>> parent of 9a807ef... 不给力啊
        }
    }
}
