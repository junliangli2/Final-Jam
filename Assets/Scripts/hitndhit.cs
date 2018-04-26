using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class hitndhit : MonoBehaviour {
    Animator anim;
    public Image xuetiao;
	// Use this for initialization
	void Start () {
        anim = this.transform.GetChild(0).GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        if (anim.GetCurrentAnimatorStateInfo(0).IsName("explosionxiao"))
        {
            anim.SetBool("hit", false);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        print(other.tag);
        if (this.tag == "duo")
        {
            this.GetComponentInParent<enemy1>().jianhealth(2);
        }
        else if (this.tag == "shao") {
            this.GetComponentInParent<enemy1>().jianhealth(1);

        }

        if (other.tag == "Respawn")
        {
            this.GetComponentInParent<enemy1>().jianhealth(1);
            xuetiao.fillAmount -= .01f;
            other.gameObject.SetActive(false);
            anim.SetBool("hit", true);
            print(true);
        }
       
    }
}
