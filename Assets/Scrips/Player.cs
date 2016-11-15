using UnityEngine;
using System.Collections;

[System.Serializable]
public class Boundary	//这个是边界
{
	public float max_X = 4;
	public float min_X = -4;
	public float max_Z = 4;
	public float min_Z = -4;
}

public class Player : MonoBehaviour {

	public float speed;
	public GameObject shot;
	public Transform shotSpawn;

	public Boundary boundary;


	public float fireRate;	//最短的发射间隔
	public float nextFire;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		GameController gc = GameObject.Find("GameController").GetComponent<GameController>();
		if (Input.GetKey("space") && Time.time > nextFire && gc.bulletNum > 0) {	
			
			gc.AddBullet (-1);
			nextFire = Time.time + fireRate;
			Instantiate (shot, shotSpawn.position, shotSpawn.rotation);
			GetComponent<AudioSource> ().Play();
		} 
	}
	void FixedUpdate(){	//固定的调用时间
		
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");
		Vector3 movement = new Vector3 (moveHorizontal, 0f, moveVertical);
		GetComponent<Rigidbody> ().velocity = movement * speed;
		transform.position = new Vector3 (Mathf.Clamp(transform.position.x, boundary.min_X, boundary.max_X), 0, Mathf.Clamp(transform.position.z, boundary.min_Z, boundary.max_Z));
	}

	void OnTriggerEnter(Collider other){
		if (other.tag == "Background" || other.tag == "Boundry") {
			return;

		}
			
		GameController gc = GameObject.Find ("GameController").transform.GetComponent<GameController>();
		GameObject.Find("GameController").GetComponent<GameController>().audios[2].Play();
		gc.GameOver ();
	}


}
