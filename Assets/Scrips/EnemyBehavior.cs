using UnityEngine;
using System.Collections;

public class EnemyBehavior : MonoBehaviour {

	public Boundary boundry;
	public Vector2 delayTime, behaviorTime, behaviorInterval, distance;
	public float curTargetPosX, curSpeedX, turnAngle;
	// Use this for initialization
	void Start () {
//		curSpeedZ = GetComponent<Rigidbody> ().velocity.z;	//速度的z轴分量
		StartCoroutine (SetCoTarget() );
	}

	IEnumerator SetCoTarget() {
		//z轴的速度是不变的，改变x的位置,x的初始位置0
		yield return new WaitForSeconds(Random.Range(delayTime.x, delayTime.y));
		while (true) {
			curTargetPosX = -Random.Range (distance.x, distance.y) * Mathf.Sign (transform.position.x);
			yield return new WaitForSeconds (Random.Range(behaviorTime.x, behaviorTime.y));	//设置目标后给敌机时间去移动
//			curTargetPosX = 0;
//			yield return new  WaitForSeconds (Random.Range(behaviorInterval.x, behaviorInterval.y));
		}
	}

	void FixedUpdate() {

		float curPositionX = Mathf.MoveTowards (transform.position.x, curTargetPosX, curSpeedX * Time.deltaTime);
		GetComponent<Rigidbody> ().velocity = new Vector3 (curPositionX, 0, -1);
		transform.position = new Vector3 (Mathf.Clamp(curPositionX, boundry.min_X, boundry.max_X), 0, transform.position.z);
//		GetComponent<Rigidbody> ().rotation = Quaternion.Euler(0, 180, GetComponent<Rigidbody> ().velocity.x * turnAngle);
	}
	// Update is called once per frame
	void Update () {
	
	}
}
