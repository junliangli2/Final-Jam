using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movtl : MonoBehaviour {
    public int ges = 0; float livintime = 0;
    // Use this for initialization

    void Start()
    {

    }
    public void Resettime()
    {
        livintime = 0;
    }
    // Update is called once per frame
     
    // Use this for initialization

	
	// Update is called once per frame
	void Update () {

        livintime += Time.deltaTime;
       
        if (livintime > 3)
        {
            this.gameObject.SetActive(false);
        }
        if (ges == 6)
        {
            this.transform.position += new Vector3(-Mathf.Sqrt(1.25f), 0, 14.5f);
        }
       else if (ges == 1)
        {
            this.transform.position += new Vector3(-Mathf.Sqrt(1.25f), 0, 14.5f);
        }
        else if (ges == 2)
        {
            this.transform.position += new Vector3(Mathf.Sqrt(1.25f), 0, -7.5f);
        }
        else if (ges == 3)
        {
            this.transform.position += new Vector3(-Mathf.Sqrt(1.25f), 0, -7.5f);
        }
        else if (ges == 4)
        {
            this.transform.position += new Vector3(0, 0, 14.5f);
        }
        else if (ges == 5)
        {
            this.transform.position += new Vector3(0, 0, -7.5f);
        }
         




    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "EditorOnly"){
            this.gameObject.SetActive(false);
         }
    }



}

