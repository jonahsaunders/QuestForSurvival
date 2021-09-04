using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointMaster : MonoBehaviour 
{
	public GameObject [] checkpoints;
	public int activecheckpoint;

	public GameObject player;

	public bool ifplayerdead;

	void OnTriggerEnter (Collider other)
	{
		if(other.gameObject.tag == "Player")
		{
			Debug.Log ("player is dead");
			player = GameObject.FindGameObjectWithTag("Player");
			player.transform.position = checkpoints [activecheckpoint].transform.position;
		}
	}
	void Update ()
	{
		if (ifplayerdead)
		{
			ifplayerdead = false;
			player = GameObject.FindGameObjectWithTag("Player");
			player.transform.position = checkpoints [activecheckpoint].transform.position;
		}
	}

}
