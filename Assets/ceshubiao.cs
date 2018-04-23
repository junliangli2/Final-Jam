using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ceshubiao : MonoBehaviour
{
    public Camera c;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {

            print(c.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, c.nearClipPlane, Input.mousePosition.y)));


        }
    }
}