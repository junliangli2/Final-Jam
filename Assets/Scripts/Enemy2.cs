// Aiden
using UnityEngine;

/// <summary>
/// Type 2 Enemy placeable by boss-player.
/// Moves sinusoidally. When hit by the hero-player or its bullet, it separates into smaller units that fly off in random direction.
/// </summary>

[RequireComponent(typeof(Rigidbody2D))]
public class Enemy2 : MonoBehaviour {

	public GameObject miniEnemyPrefab;	// prefab for the mini version the enemy will split into when hit

	[SerializeField]private float speed = 3f;
	[SerializeField]private float amplitude = 1f;
	[SerializeField]private float frequency = .7f;

	private Rigidbody2D rb;


	void Start () {
		rb = GetComponent<Rigidbody2D> ();
		rb.velocity = new Vector2(0, speed);
	}

	void Update () {
		transform.position += amplitude * (Mathf.Sin(2 * Mathf.PI * frequency * Time.time) - Mathf.Sin(2 * Mathf.PI * frequency*(Time.time - Time.deltaTime))) * transform.forward;

		// test death
		if (Input.GetKeyDown(KeyCode.K)) {
			Death ();
		}
	}

	void OnCollisionEnter2D(Collision2D other){
		// Hitting hero-player or its bullet
		if (other.gameObject.tag == "Player" || other.gameObject.tag == "Bullet") {
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

