using UnityEngine;
using System.Collections;

public class randomjRotation : MonoBehaviour {

	public float offset;
	// Use this for initialization
	void Start () {
		GetComponent<Rigidbody> ().angularVelocity = Random.insideUnitSphere * offset;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
