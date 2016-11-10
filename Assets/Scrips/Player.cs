using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	public float speed;
	public GameObject shot;
	public Transform shotSpawn;

	[System.Serializable]
	public class Boundary	//这个是边界
	{
		 public float max_X = 4;
		 public float min_X = -4;
		 public float max_Z = 4;
		 public float min_Z = -4;
	}
	public Boundary boundary;


	public float fireRate;	//最短的发射间隔
	public float nextFire;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey("space") && Time.time > nextFire) {	//

			nextFire = Time.time + fireRate;
			Instantiate (shot, shotSpawn.position, shotSpawn.rotation);
		} 
	}
	void FixedUpdate(){	//固定的调用时间
		
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");
		Vector3 movement = new Vector3 (moveHorizontal, 0f, moveVertical);

		GetComponent<Rigidbody> ().velocity = movement * speed;
		transform.position = new Vector3 (Mathf.Clamp(transform.position.x, boundary.min_X, boundary.max_X), 0, Mathf.Clamp(transform.position.z, boundary.min_Z, boundary.max_Z));
	}
}
