using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemymove : MonoBehaviour {
    GameObject nexttgt;
    int i = 0;
    public GameObject nimasile;
    // Use this for initialization
    void Start () {
        nexttgt = this.transform.parent.transform.GetChild(0).gameObject;
	}
	
	// Update is called once per frame
	void Update () {
        nimasile.GetComponent<movtl>().Resettime();
        if (nexttgt.tag!="movepvl")
        {
            if (Mathf.Abs(nexttgt.transform.localPosition.x - this.transform.localPosition.x) > 1)
            {
                if ((nexttgt.transform.localPosition.x - this.transform.localPosition.x) > 0.5f)
                {
                    this.transform.localPosition += new Vector3(125f, 0, 0)*Time.deltaTime;

                }
                else if( ((nexttgt.transform.localPosition.x - this.transform.localPosition.x) <- 0.5f)){ this.transform.localPosition -= new Vector3(125f, 0, 0) * Time.deltaTime; }

            }
            if (Mathf.Abs(nexttgt.transform.localPosition.z - this.transform.localPosition.z) > 1)
            {
                if ((nexttgt.transform.localPosition.z - this.transform.localPosition.z) > 0)
                {
                    this.transform.localPosition += new Vector3(0, 0, 125f) * Time.deltaTime;

                }
                else if (((nexttgt.transform.localPosition.z - this.transform.localPosition.z) < -0.5f)) { this.transform.localPosition -= new Vector3(0, 0, 125f) * Time.deltaTime; }



            }

            if(Mathf.Abs(nexttgt.transform.localPosition.z - this.transform.localPosition.z) <= 1&& Mathf.Abs(nexttgt.transform.localPosition.x - this.transform.localPosition.x) < 1&&i<10)
            {
                if (nexttgt.tag == "enmblt")
                {GameObject temp=Instantiate(nimasile, this.transform.position, this.transform.rotation);
                    temp.GetComponent<movtl>().ges = 5;
                    
                } 



                i++;
                nexttgt = this.transform.parent.transform.GetChild(i).gameObject;

            }



        }
        else
        {
            i=0;
            nexttgt = this.transform.parent.transform.GetChild(0).gameObject;
        }

        }
}
