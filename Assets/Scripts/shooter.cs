using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooter : MonoBehaviour
{

	public GameObject bullet;



	void Start () 
	{
		StartCoroutine("Shoot");
	}
	
	IEnumerator Shoot ()
	{

		GameObject enemy = Instantiate (bullet) as GameObject;
		enemy.transform.position = this.gameObject.transform.position;
		yield return new WaitForSeconds(10);
		StartCoroutine("Shoot");
	}
}
