using UnityEngine;
using System.Collections;

public class DestoryByBoundry : MonoBehaviour {

	void OnTriggerExit(Collider other) {	
		if (other != null) {
			Destroy (other.gameObject);

		}
	}

}
