using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnShips : MonoBehaviour {
    public enum SpawnType
    {
        Empty, //default type
        Suicider
    }

    //The maximum storage limit for a ship
    private int suiciderCount;


    //The CD required to generate a new ship
    private float generateSuiciderTime;

    //prefab of spawning ships
    public GameObject Suicider;

    public SpawnType spawnType;
    private GameObject allObjects;   //use this to set as the parent of ships
    private Camera _camera;


    // Use this for initialization
    void Start () {
        spawnType = SpawnType.Empty;
        _camera = Camera.main;
        allObjects = GameObject.Find("rest");


        //initialize the maximum limit
        suiciderCount = 6;

        //initialize the CD of ships
        generateSuiciderTime = 2.0f;
    }
	
	// Update is called once per frame
	void Update () {
        //reset the spawning type
        if (Input.GetKeyUp(KeyCode.Space))
        {
            spawnType = SpawnType.Empty;
        }

        if (Input.GetKeyUp(KeyCode.U))
        {
            spawnType = SpawnType.Suicider;
        }

        if (Input.GetMouseButtonDown(0))
        {
            switch (spawnType)
            {
                case SpawnType.Suicider:
                    if (suiciderCount > 0)
                    { 
                        Vector3 worldVector = _camera.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 525));  ////screen position to world position
                        worldVector.y = transform.position.y;
                        GameObject suiciderIns = (GameObject)GameObject.Instantiate(Suicider, worldVector, transform.rotation);
                        suiciderIns.transform.SetParent(allObjects.transform);
                        suiciderCount -= 1;
                    }
                    break;
            }
        }

        checkShipsCount(Time.deltaTime);

        

    }

    //check the count of ships and generate new one
    void checkShipsCount(float time)
    {
        //suicider
        if (suiciderCount<6)
        {
            
            if (generateSuiciderTime < 0)
            {
                suiciderCount += 1;
                generateSuiciderTime = 2.0f;
            }
            else
            {
                generateSuiciderTime -= time;
            }
        }
    }




}
