using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {



	public GameObject[] rocks;
	public Vector3 RockbitrthPos;
	public float groupWait, buildInterval;
	public int groupMaxCount ;
	// Use this for initialization
	void Start () {
		StartCoroutine (BuildRock());
	}
	
	// Update is called once per frame
	void Update () {
		

	}

	IEnumerator BuildRock(){

		yield return new WaitForSeconds (buildInterval);

		while (true) {
			for(int i = 0; i < groupMaxCount; i++) {
				GameObject rock = rocks[Random.Range(0,rocks.Length)];
				Vector3 curPos = new Vector3 (Random.Range(-RockbitrthPos.x, RockbitrthPos.x), RockbitrthPos.y, RockbitrthPos.z);
				Instantiate (rock, curPos, Quaternion.identity);
				yield return new WaitForSeconds (buildInterval);
			}
			yield return new WaitForSeconds (groupWait);	//have a rest when finish building a group of rocks everytime
		}

	}
}
