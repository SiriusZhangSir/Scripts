using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyBorn : MonoBehaviour {

	public static int EnemiesAlive = 0;
	public Transform startPoint;
	public Wave[] waves;
	public Text waveCountdownText;

	public float timeBetween = 1f;
	private float countdown = 5f;

	private int waveIndex = 0;

	void Update(){
		if (EnemiesAlive > 0)
		{
			return;
		}

		 
		if(waveIndex == waves.Length){
			this.enabled = false;
		}

		if(countdown<=0){
			StartCoroutine (EnemySys ());
			countdown = timeBetween;
			return;

		}

		countdown -= Time.deltaTime;
		countdown = Mathf.Clamp (countdown, 0f, Mathf.Infinity);

		waveCountdownText.text = string.Format ("{0:00:00}", countdown);

	}

	void EnemyGo(GameObject enemy){
		Instantiate (enemy, startPoint.position, startPoint.rotation);
	}

	IEnumerator EnemySys(){

		Wave wave = waves[waveIndex];
		EnemiesAlive = wave.count;

		for(int i = 0;i<wave.count;i++){
			EnemyGo (wave.enemy);
			yield return new WaitForSeconds(1f/wave.rate);
		}

		waveIndex++;

	}

}
