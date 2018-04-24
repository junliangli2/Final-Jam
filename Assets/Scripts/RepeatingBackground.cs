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
        if (transform.position.z < - m_BackgroundSize)
        {
            RepeatBackground();
            Debug.Log("ll");
        }
	}

    void RepeatBackground()
    {
        Vector3 BG0ffset = new Vector3(0, 0, m_BackgroundSize * 2f);
        transform.position = transform.position + BG0ffset;
    }
}
