using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Batery_Attack : MonoBehaviour {

    public GameObject Bullets;
    float livintime;
    float shoottime;
    private GameObject allObjects;   //use this to set as the parent of ships
    private int bulletsCount = 3;
    // Use this for initialization
    void Start()
    {
        livintime = 5;
        shoottime=0.3f;
        allObjects = GameObject.Find("rest");
     
    }

    // Update is called once per frame
    void Update()
    {
    
        livintime -= Time.deltaTime;
        if (livintime < 0)
        {
            this.gameObject.SetActive(false);
        }
        if (bulletsCount >0)
        {
            shoottime -= Time.deltaTime;
        }
        if (shoottime < 0&&bulletsCount>0)
        {
            shoottime = 0.3f;
            GameObject bullet = (GameObject)GameObject.Instantiate(Bullets, transform.position, transform.rotation, Bullets.transform);
            bullet.transform.SetParent(allObjects.transform);
            bulletsCount--;
        }

    }
}
