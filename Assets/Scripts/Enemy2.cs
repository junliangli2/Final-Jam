// Aiden
using UnityEngine;

/// <summary>
/// Type 2 Enemy placeable by boss-player.
/// Moves sinusoidally. When hit by the hero-player or its bullet, it separates into smaller units that fly off in random direction.
/// </summary>

[RequireComponent(typeof(Rigidbody))]
public class Enemy2 : MonoBehaviour {

	public GameObject miniEnemyPrefab;	// *** NEEDS prefab for the mini version the enemy will split into when hit (called "AIUnit2_Mini")

	[SerializeField]private float speed = 100f;
	[SerializeField]private float amplitude = 10f;
	[SerializeField]private float frequency = .9f;

	private Rigidbody rb;

	private bool debug = false;


	void Start () {
		rb = GetComponent<Rigidbody> ();
		rb.velocity = new Vector3(0, 0, speed);
	}

	void Update () {
		transform.position += amplitude * (Mathf.Sin(2 * Mathf.PI * frequency * Time.time) - Mathf.Sin(2 * Mathf.PI * frequency*(Time.time - Time.deltaTime))) * transform.right;

		// DEBUG: Test death
		if (Input.GetKeyDown(KeyCode.M) && debug) {
			Death ();
		}
	}

	void OnCollisionEnter(Collision2D other){
		// Hitting hero-player or its bullet
		if (other.gameObject.tag == "movepvl" || other.gameObject.tag == "Bullet") {
			//Debug.Log ("{0} has been hit.", gameObject.name);
			Debug.Log ("Ship has been hit.");
		}
	}

	// Handles all Death processes
	void Death() {
		// spawn 3 mini units and destroy current
		for (int i = 0; i < 3; i++){
			Instantiate(miniEnemyPrefab, transform.position, transform.rotation);
		}
		Destroy (gameObject);
	}
}

