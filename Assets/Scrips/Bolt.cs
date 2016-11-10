using UnityEngine;
using System.Collections;

public class Bolt : MonoBehaviour {

	// Use this for initialization

	public float speed;
	public float lifeTime;
	void Start () {
		
		GetComponent<Rigidbody>().velocity = transform.forward *speed;	//好简单的方法
//		Destroy(transform.gameObject, lifeTime);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
