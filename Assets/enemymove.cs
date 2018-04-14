using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemymove : MonoBehaviour {
    GameObject nexttgt;
    int i = 0;
	// Use this for initialization
	void Start () {
        nexttgt = this.transform.parent.transform.GetChild(0).gameObject;
	}
	
	// Update is called once per frame
	void Update () {
        if (i < 10)
        {
            if (Mathf.Abs(nexttgt.transform.localPosition.x - this.transform.localPosition.x) > 1)
            {
                if ((nexttgt.transform.localPosition.x - this.transform.localPosition.x) > 0.5f)
                {
                    this.transform.localPosition += new Vector3(.5f, 0, 0);

                }
                else if( ((nexttgt.transform.localPosition.x - this.transform.localPosition.x) <- 0.5f)){ this.transform.localPosition -= new Vector3(.5f, 0, 0); }

            }
            if (Mathf.Abs(nexttgt.transform.localPosition.z - this.transform.localPosition.z) > 1)
            {
                if ((nexttgt.transform.localPosition.z - this.transform.localPosition.z) > 0)
                {
                    this.transform.localPosition += new Vector3(0, 0, .5f);

                }
                else if (((nexttgt.transform.localPosition.z - this.transform.localPosition.z) < -0.5f)) { this.transform.localPosition -= new Vector3(0, 0, .5f); }



            }

            if(Mathf.Abs(nexttgt.transform.localPosition.z - this.transform.localPosition.z) <= 1&& Mathf.Abs(nexttgt.transform.localPosition.x - this.transform.localPosition.x) < 1&&i<10)
            {
                i++;
                nexttgt = this.transform.parent.transform.GetChild(i).gameObject;

            }



        }


        }
}
