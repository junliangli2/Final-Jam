using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnShips : MonoBehaviour {
    public bool starto;
    public enum SpawnType
    {
        Empty, //default type
        Suicider,
        Barrier,
        Batery
    }

    //The maximum storage limit for a ship
    private int suiciderCount;
    private int barrierCount;
    private int bateryCount;

    //The CD required to generate a new ship
    private float generateSuiciderTime;
    private float generateBarrierTime;
    private float generateBateryTime;

    //prefab of spawning ships
    public GameObject Suicider;
    public GameObject Barrier;
    public GameObject Batery;

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
        barrierCount = 3;
        bateryCount = 1;

        //initialize the CD of ships
        generateSuiciderTime = 2.0f;
        generateBarrierTime = 3.0f;
        generateBateryTime = 3.0f;
    }
	
	// Update is called once per frame
	void Update () {

        
        //reset the spawning type
        if (Input.GetKeyUp(KeyCode.Space))
        {
            spawnType = SpawnType.Empty;
        }
        if (starto == true)
        {
            if (Input.GetKeyUp(KeyCode.U))
            {
                spawnType = SpawnType.Suicider;
            }

            if (Input.GetKeyUp(KeyCode.I))
            {
                spawnType = SpawnType.Barrier;
            }

            if (Input.GetKeyUp(KeyCode.O))
            {
                spawnType = SpawnType.Batery;
            }

            if (Input.GetMouseButtonDown(0))
            {
                Vector3 worldVector = _camera.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y,524.6f));  ////screen position to world position
               // Debug.Log(worldVector);
                worldVector.y = transform.position.y;
               // Debug.Log(worldVector);
                switch (spawnType)
                {
                    case SpawnType.Suicider:
                        if (suiciderCount > 0)
                        {
                            GameObject suiciderIns = (GameObject)GameObject.Instantiate(Suicider, worldVector, transform.rotation);
                            suiciderIns.transform.SetParent(allObjects.transform);
                            suiciderCount -= 1;
                        }
                        break;

                    case SpawnType.Barrier:
                        if (barrierCount > 0)
                        {
                            GameObject barrierIns = (GameObject)GameObject.Instantiate(Barrier, worldVector, transform.rotation);
                            // barrierIns.transform.SetParent(allObjects.transform);
                            barrierCount -= 1;
                        }
                        break;

                    case SpawnType.Batery:
                        if (bateryCount > 0)
                        {
                            GameObject bateryIns = (GameObject)GameObject.Instantiate(Batery, worldVector, transform.rotation);
                            //bateryIns.transform.SetParent(allObjects.transform);
                            bateryCount -= 1;
                        }
                        break;
                }
            }

            checkShipsCount(Time.deltaTime);

        }

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

        //barrier
        if (barrierCount < 3)
        {

            if (generateBarrierTime < 0)
            {
                barrierCount += 1;
                generateBarrierTime = 3.0f;
            }
            else
            {
                generateBarrierTime -= time;
            }
        }

        //batery
        if (bateryCount < 1)
        {

            if (generateBateryTime < 0)
            {
                bateryCount += 1;
                generateBateryTime = 3.0f;
            }
            else
            {
                generateBateryTime -= time;
            }
        }
    }




}
