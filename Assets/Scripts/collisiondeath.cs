using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisiondeath : MonoBehaviour 
{
	public GameObject rigidbody;
	void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.tag == "Player")
		{
			GameObject rigid = Instantiate (rigidbody) as GameObject;
			rigid.transform.position = this.gameObject.transform.position;
			Destroy (this.gameObject.gameObject);
		}
	}
}
