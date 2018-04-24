using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingObject : MonoBehaviour
{
    private Rigidbody RIGIDBODY;
    private float m_speed = -100f;

    [SerializeField]
    private bool m_StopScrolling;

	void Start ()
    {
        RIGIDBODY = GetComponent<Rigidbody>();
        RIGIDBODY.velocity = new Vector3 (0, 0, m_speed);
	}
	
	
	void Update ()
    {
        if (m_StopScrolling)
        {
            RIGIDBODY.velocity = Vector3.zero;
        }
        else
        {
            RIGIDBODY.velocity = new Vector3(0, 0, m_speed);
        }
	}
}
