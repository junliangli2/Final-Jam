using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class explosionshi : MonoBehaviour
{
    Animator anim;

    // Use this for initialization
    void Start()
    {
        anim = this.transform.GetChild(0).GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (anim.GetCurrentAnimatorStateInfo(0).IsName("explosionxiao"))
        {
            anim.SetBool("hit", false);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        
    

        if (other.tag == "EditorOnly")
        {
             
            anim.SetBool("hit", true);
         
        }

    }
}
