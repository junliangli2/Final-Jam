using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class AvoidBullets : MonoBehaviour {

    [SerializeField]
    float movetime;
    [SerializeField]
    int movedirection;
    [SerializeField]
    GameObject Bullets;
    public GameObject ZIS;
    int speed = 100;
  
    [SerializeField]
    Image SuperFlash;

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
            int supercharger = Random.Range(0, 50);
            movetime = 0.5f;
            if (other.transform.position.x > transform.position.x)
            {
                movedirection = 1;
            }
            else
            {
                movedirection = 2;
            }
            if (supercharger == 25)
            {
                for (int i = 0; i < Bullets.transform.childCount; i++)
                {
                    Destroy(Bullets.transform.GetChild(i).gameObject);
                    SuperFlash.GetComponent<SuperFlash>().currentcolor.a = 1;
                    
                }
            }
        }
    }
}
