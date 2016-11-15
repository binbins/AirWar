using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

	public Text scoreText, gameOverText, restartText, bulletText;
	public GameObject[] rocks;
	public AudioSource[] audios;
	public GameObject enemy;
	public Vector3 RockbitrthPos;
	public float groupWait, buildInterval;
	public int groupMaxCount, bulletNum;
	public Transform rockParent;
	bool isGameOver;

	private int curScore;

//	private  GameController gc;
//	public static GameController GetInstance(){
//		if(gc == null){
//			gc = new GameController();
//		}
//		return gc;
//	}
	// Use this for initialization
	void Start () {
		StartCoroutine (BuildRock());

		gameOverText.text = "";
		restartText.text = "";
		curScore = 0;
		bulletNum = 10;
		UpdateScore ();
		isGameOver = false;
	}
	
	// Update is called once per frame
	void Update () {
		
		UpdateScore ();
		if (isGameOver) {
			if (Input.GetKeyDown (KeyCode.R)) {
				GameRestart ();
			}
		}
	}

	IEnumerator BuildRock(){

		yield return new WaitForSeconds (buildInterval);

		while (true) {
			for(int i = 0; i < groupMaxCount; i++) {
				GameObject rock = rocks[Random.Range(0,rocks.Length)];
				Vector3 curPos = new Vector3 (Random.Range(-RockbitrthPos.x, RockbitrthPos.x), RockbitrthPos.y, RockbitrthPos.z);
				GameObject arock = (GameObject)Instantiate (rock, curPos, Quaternion.identity);
				arock.transform.SetParent (rockParent);
				yield return new WaitForSeconds (buildInterval);
			}
			Vector3 enemyPos = new Vector3 (Random.Range(-RockbitrthPos.x, RockbitrthPos.x), RockbitrthPos.y, RockbitrthPos.z);
			Instantiate (enemy, enemyPos, Quaternion.Euler(new Vector3(0, 180, 0)));
			bulletNum++;
			yield return new WaitForSeconds (groupWait);	//have a rest when finish building a group of rocks everytime

			if (isGameOver) {
				break;
			}
		}

	}

	public void UpdateScore() {
		scoreText.text = "分数:" + curScore;
		bulletText.text = "弹药:" + bulletNum;	

	}

	public void AddScore(int score) {
		curScore += score;
	}
	public void AddBullet(int num) {
		bulletNum += num;
	}

	public void GameOver() {
		isGameOver = true;
		gameOverText.text = "Game Over";
		restartText.text = "Click 'R' To Restart";
	}
	public void GameRestart() {
		Application.LoadLevel (Application.loadedLevel);

	}
}
