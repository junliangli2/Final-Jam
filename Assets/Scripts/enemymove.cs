using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemymove : MonoBehaviour
{
    GameObject nexttgt;
    public bool starto = false;
    int i = 0;
    int previ = 0;
    public bool duo = false;
    float time = 0;
    public GameObject nimasile;
    // Use this for initialization
    void Start()
    {
        nexttgt = this.transform.parent.transform.GetChild(0).gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        nimasile.GetComponent<movtl>().Resettime();
        if (starto == true)
        {

            if (time > 0.2f)
            {
                GameObject temp = Instantiate(nimasile, new Vector3(this.transform.GetChild(3).transform.position.x,400,this.transform.position.z), this.transform.rotation);
                time = 0;
            }



            if (duo == false)
            {



                if (nexttgt.tag != "movepvl")
                {
                    if (Mathf.Abs(nexttgt.transform.localPosition.x - this.transform.localPosition.x) > 1)
                    {
                        if ((nexttgt.transform.localPosition.x - this.transform.localPosition.x) > 0.5f)
                        {
                            this.transform.localPosition += new Vector3(125f, 0, 0) * Time.deltaTime;

                        }
                        else if (((nexttgt.transform.localPosition.x - this.transform.localPosition.x) < -0.5f)) { this.transform.localPosition -= new Vector3(125f, 0, 0) * Time.deltaTime; }

                    }
                    if (Mathf.Abs(nexttgt.transform.localPosition.z - this.transform.localPosition.z) > 1)
                    {
                        if ((nexttgt.transform.localPosition.z - this.transform.localPosition.z) > 0)
                        {
                            this.transform.localPosition += new Vector3(0, 0, 125f) * Time.deltaTime;

                        }
                        else if (((nexttgt.transform.localPosition.z - this.transform.localPosition.z) < -0.5f)) { this.transform.localPosition -= new Vector3(0, 0, 125f) * Time.deltaTime; }



                    }

                    if (Mathf.Abs(nexttgt.transform.localPosition.z - this.transform.localPosition.z) <= 1 && Mathf.Abs(nexttgt.transform.localPosition.x - this.transform.localPosition.x) < 1 && i < 10)
                    {
                        if (nexttgt.tag == "enmblt")
                        {
                            GameObject temp = Instantiate(nimasile, new Vector3(this.transform.GetChild(3).transform.position.x, 400, this.transform.position.z), this.transform.rotation);
                            temp.GetComponent<movtl>().ges = 5;

                        }


                        previ = i;
                        while(i==previ|| this.transform.parent.transform.GetChild(i).tag== "movepvl")
                        {
                            i = Random.Range(0, 5);
                        }

                        
                        nexttgt = this.transform.parent.transform.GetChild(i).gameObject;

                    }



                }
                else
                {
                    i = 0;
                    nexttgt = this.transform.parent.transform.GetChild(0).gameObject;
                }
            }
        }
    }
}