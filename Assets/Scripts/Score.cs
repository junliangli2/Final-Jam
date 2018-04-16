using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Score : MonoBehaviour {
	[SerializeField]
	private TextMeshProUGUI sscore;
	private float score;
	private float previousscore=0;


	//private Text sscore;


	void Start ()
	{
		
	}
	

	void Update ()
	{
		if (Input.GetKeyDown(KeyCode.Space)) 
		{
			score = previousscore + 1;
			previousscore = score;
			sscore.text = score.ToString();
		}
	}
}
