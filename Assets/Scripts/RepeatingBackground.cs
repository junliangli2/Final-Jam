using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatingBackground : MonoBehaviour
{
    private BoxCollider m_backgroundCollider;
    public float m_BackgroundSize;

	void Start ()
    {
        m_backgroundCollider = GetComponent<BoxCollider>();
        m_BackgroundSize = m_backgroundCollider.size.y * 56;

	}
	
	
	void Update ()
    {
        if (transform.localPosition.z < - 28.5f)
        {
            RepeatBackground();
 
        }
	}

    void RepeatBackground()
    {

        transform.localPosition = new Vector3(transform.localPosition.x, transform.localPosition.y, 62.6f);
    }
}
