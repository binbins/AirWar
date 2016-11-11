using UnityEngine;
using System.Collections;

public class weaponController : MonoBehaviour {

	public GameObject weapon, selfBoom;
	public Transform weaponStartPos;
	public float delay, interval;

	void Start() {
		InvokeRepeating ("Fire", delay, interval);
	}
	// Update is called once per frame
	void Update () {
	}

	void Fire() {

		GetComponent<AudioSource> ().Play();
		Instantiate (weapon, weaponStartPos.position, weaponStartPos.rotation);
	}

	void OnTriggerEnter(Collider other) {
		if (other.tag == "PlayerBolt") {
			Instantiate (selfBoom, transform.position, transform.rotation);
			Destroy (this.gameObject);
			Destroy (other.gameObject);
			Debug.Log ("击中敌机");
		}
	}
}
