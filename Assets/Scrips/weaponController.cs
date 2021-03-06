﻿using UnityEngine;
using System.Collections;

public class weaponController : MonoBehaviour {

	public GameObject weapon, selfBoom;
	public Transform weaponStartPos;
	public float delay, interval;
	public int score;

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
		if (other.tag == "PlayerBolt" || other.tag == "Player") {
			Instantiate (selfBoom, transform.position, transform.rotation);
			Destroy (this.gameObject);
			Destroy (other.gameObject);
			GameObject.Find("GameController").GetComponent<GameController>().audios[1].Play();
			Debug.Log ("敌机被击中或是和主角发生碰撞");
			GameObject.Find("GameController").GetComponent<GameController>().AddBullet(2);
//			GetComponent<AudioSource> ().Play ();
			GameController gc = GameObject.Find ("GameController").transform.GetComponent<GameController>();
			if (gc != null) {
				gc.AddScore (score);
			}
		}
	}
}
