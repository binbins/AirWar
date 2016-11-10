using UnityEngine;
using System.Collections;

public class RandomRotation : MonoBehaviour {


	public float turnSpeed;
	// Use this for initialization
	void Start () {
	
		GetComponent<Rigidbody> ().angularVelocity = Random.insideUnitSphere * turnSpeed;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
