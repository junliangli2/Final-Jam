using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ucup : MonoBehaviour {
      float livintime=0;
	// Use this for initialization
	void Start () {
		
	}

   public void Resettime()
    {
        livintime = 0;
    }
    // Update is called once per frame
    void Update () {
        livintime += Time.deltaTime;
        transform.localPosition += new Vector3(0, 0, 14);
        if (livintime > 3)
        {
            this.gameObject.SetActive(false);
        }
	}
}
