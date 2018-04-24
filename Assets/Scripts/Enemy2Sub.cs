using UnityEngine;

/// <summary>
/// Enemy2 sub type - bursts from Enemy2 type.
/// </summary>
[RequireComponent(typeof(Rigidbody2D))]
public class Enemy2Sub : MonoBehaviour {

	private Rigidbody2D rb;
	private Vector2 direction;

	void Start () {
		rb =  GetComponent<Rigidbody2D> ();

		// calculate random angle to go off in a direction in radians
		float angle = Random.Range(30f, 15) + Random.Range(0, 2) * 180f;
		float radAngle = angle * Mathf.Deg2Rad;


	}

	void Update () {

		// TO DO: mov ement
	}

	// Destroy upon going off screen
	void OnBecameInvisible() {
		Destroy (gameObject);
	}

	void OnCollisionEnter2D(Collision2D other) {
		if (other.gameObject.tag == "Player" || other.gameObject.tag == "Bullet") {
			Death ();
		}
	}

	void Death() {
		Destroy (gameObject);
	}
}
