using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class bossbattle : MonoBehaviour 
{
	public GameObject starttext;
	public GameObject spawnerone;
	public GameObject spawnerfour;
	public GameObject spawnerthree;
	public GameObject spawnerfive;
	public GameObject surviveone;
	public GameObject survivetwo;
	public GameObject survivethree;
	public GameObject survivefour;
	public GameObject win;
	public bool spawnable;

	public GameObject enemyone;
	public GameObject enemytwo;

	public bool iscollided;

	void Update ()
	{
		if (iscollided) 
		{
			iscollided = false;
			StartCoroutine("Battle");
			StartCoroutine("Spawner");
		}
	}
	IEnumerator Spawner ()
	{
		if (spawnable) 
		{
			GameObject enemy = Instantiate (enemyone) as GameObject;
			enemy.transform.position = spawnerone.transform.position;
			GameObject eney = Instantiate (enemytwo) as GameObject;
			eney.transform.position = spawnerfour.transform.position;
			GameObject annoy = Instantiate (enemyone) as GameObject;
			annoy.transform.position = spawnerthree.transform.position;
			GameObject attack = Instantiate (enemytwo) as GameObject;
			attack.transform.position = spawnerfive.transform.position;
			GameObject arg = Instantiate (enemyone) as GameObject;
			arg.transform.position = spawnerone.transform.position;
			GameObject e = Instantiate (enemytwo) as GameObject;
			e.transform.position = spawnerfour.transform.position;
			GameObject uh = Instantiate (enemyone) as GameObject;
			uh.transform.position = spawnerthree.transform.position;
			GameObject ut = Instantiate (enemytwo) as GameObject;
			ut.transform.position = spawnerfive.transform.position;
		}
		yield return new WaitForSeconds(3);
		StartCoroutine("Spawner");
	}
	IEnumerator Battle ()
	{
		spawnable = true;
		surviveone.SetActive (true);
		yield return new WaitForSeconds(1);
		surviveone.SetActive (false);
		yield return new WaitForSeconds(15);
		survivetwo.SetActive(true);
		yield return new WaitForSeconds(1);
		survivetwo.SetActive (false);
		spawnable = false;
		yield return new WaitForSeconds(15);
		survivethree.SetActive(true);
		yield return new WaitForSeconds(1);
		survivethree.SetActive (false);
		spawnable = true;
		yield return new WaitForSeconds(15);
		survivefour.SetActive (true);
		yield return new WaitForSeconds (1);
		survivefour.SetActive (false);
		spawnable = false;
		win.SetActive (true);
		yield return new WaitForSeconds(15);
		SceneManager.LoadScene ("MainMenu");
	}
}
