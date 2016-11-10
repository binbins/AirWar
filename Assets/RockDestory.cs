using UnityEngine;
using System.Collections;

public class RockDestory : MonoBehaviour {

	public GameObject rockBoom, playerBoom;

	void OnTriggerEnter(Collider other) {
		if (other.tag == "Boundry" || other.tag == "Background") {	//你太笨了
			return;
		}
		if (other.tag == "Player") {
			Instantiate (playerBoom, other.transform.position, other.transform.rotation);
			Debug.Log ("飞机爆炸");
		}

		Instantiate (rockBoom, transform.position, transform.rotation);
		Destroy (other.gameObject);
		Destroy (this.gameObject);
	}
}
