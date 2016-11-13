using UnityEngine;
using System.Collections;
//using UnityEngine.UI;

public class RockDestory : MonoBehaviour {

	public GameObject selfBoom, playerBoom;
	public int score;
	void Start() {
		
	}

	void OnTriggerEnter(Collider other) {
		if (other.tag == "Boundry" || other.tag == "Background" || other.tag == "Rock" || other.tag == "Enemy") {	
			return;
		}
		if (other.tag == "Player") {
			GameObject explo = (GameObject)Instantiate (playerBoom, other.transform.position, other.transform.rotation);
			Destroy (explo, 1);
			Debug.Log ("游戏结束");
		}
		GameController gc = GameObject.Find ("GameController").transform.GetComponent<GameController>();
		if (gc != null) {
			gc.AddScore (score);
		} else {
			Debug.Log ("does not find scripts");
		}
//		GetComponent<AudioSource> ().Play ();
		GameObject rockexplo = (GameObject)Instantiate (selfBoom, transform.position, transform.rotation);
		Destroy (rockexplo, 1);
		Destroy (other.gameObject);
		Destroy (this.gameObject);
	}
}
