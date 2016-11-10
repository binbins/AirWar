using UnityEngine;
using System.Collections;

public class DestorySelf : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggetEnter(Collider other){
//		if (other.tag == "Boundry") {
//			Debug.Log ("触发");
//			return;
//		}
		Destroy (other.gameObject);
		Destroy (this.gameObject);
	}
}
