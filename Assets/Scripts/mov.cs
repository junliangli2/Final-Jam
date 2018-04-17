using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mov : MonoBehaviour {
    public bool shouldstart=false;
	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    void Update()
    {
        if (shouldstart == true)
        {
            this.gameObject.transform.position += new Vector3(0, 0, 7);
        }
    }
}
