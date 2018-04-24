using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class danmu : MonoBehaviour
{   public bool starto=false;
    public GameObject damu;
    float p = 0;
    int g = 3;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.K)&&starto==true&&g>0)
        {
            g--;

            for (int i = 0; i < 25; i++)
            {
                Instantiate(damu, this.transform.position, Quaternion.Euler(new Vector3(90, 0, p)));
                p += 14.4f;
            }

        }
    }
}
