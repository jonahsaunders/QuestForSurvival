using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class killers : MonoBehaviour 
{
	void OnTriggerEnter (Collider other)
	{
		if (other.gameObject.tag == "Player")
		{
			GameObject.Find ("CheckpointMaster").GetComponent<CheckpointMaster> ().ifplayerdead = true;
		}
	}

}
