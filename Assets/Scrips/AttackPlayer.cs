using UnityEngine;
using System.Collections;

public class AttackPlayer : MonoBehaviour {

	public GameObject playerBoom;

	void OnTriggerEnter(Collider other) {
		if (other.tag == "Boundry" || other.tag == "Background" || other.tag == "Rock" || other.tag == "Enemy") {	
			return;
		}
		if (other.tag == "Player") {
			GameObject explo = (GameObject)Instantiate (playerBoom, other.transform.position, other.transform.rotation);
			Destroy (explo, 1);
			Debug.Log ("游戏结束");
		}
			
		Destroy (other.gameObject);
		Destroy (this.gameObject);
	}
}

