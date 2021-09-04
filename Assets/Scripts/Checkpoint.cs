using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Checkpoint : MonoBehaviour 
{


	void OnTriggerExit(Collider other)
	{
		if(other.gameObject.tag == "Player")
		{
			Destroy (this.gameObject.gameObject);
			GameObject.Find("CheckpointMaster").GetComponent<CheckpointMaster>().activecheckpoint += 1;
		}
	}
}
