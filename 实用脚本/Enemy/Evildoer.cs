using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Evildoer : MonoBehaviour {

	public float startSpeed = 10f;
	[HideInInspector]
	public float speed;
	public GameObject deathEffect;

	[Header("Unity Stuff")]
	public Image healthBar;

	public float startHealth = 100f;
	private float health;

	void Start(){
		speed = startSpeed;
		health = startHealth;
	}

	public void TakeDamage(float damage){
		health -= damage;

		healthBar.fillAmount = health / startHealth;

		if(health<=0){
			Die ();
		}

	}

	void Die(){

		GameObject effect = Instantiate (deathEffect, transform.position, transform.rotation)as GameObject;
		Destroy (effect, 2f);

		EnemyBorn.EnemiesAlive--;
		Destroy (gameObject);

	}
}
