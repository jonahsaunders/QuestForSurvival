using UnityEngine;
using System.Collections;

public class aibasic : MonoBehaviour 
{

	public GameObject player;
	public float distance;
	public float speed;
	public float updatetime;

	void Start ()
	{
		StartCoroutine("Hunt");
		player = GameObject.FindWithTag("Player");
	}
	void Update ()
	{
		if (Vector3.Distance (player.transform.position, this.gameObject.transform.position) < distance)
		{
			transform.Translate (Vector3.forward * Time.deltaTime * speed);
		}
	}




	IEnumerator Hunt ()
	{
		
		yield return new WaitForSeconds(updatetime);
		player = GameObject.FindWithTag("Player");
		if (Vector3.Distance (player.transform.position, this.gameObject.transform.position) < distance)
		{
			transform.LookAt(player.transform);
		}
		StartCoroutine("Hunt");
	}
}
