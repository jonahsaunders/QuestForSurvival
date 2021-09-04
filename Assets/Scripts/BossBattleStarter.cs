using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossBattleStarter : MonoBehaviour 
{

	void OnTriggerEnter (Collider other)
	{
		if(other.gameObject.tag == "Player")
		{
			Destroy (this.gameObject);
			GameObject.Find ("BossBattleMaster").GetComponent<bossbattle> ().iscollided = true;
		}
	}
}
