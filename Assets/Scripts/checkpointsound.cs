using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkpointsound : MonoBehaviour 
{
	public AudioClip checkpoint;
	public AudioSource source;
	
	void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.tag == "checkpoint")
		{
			float vol = Random.Range (0, 1);
			source.PlayOneShot(checkpoint, vol);
		}
	}
}
