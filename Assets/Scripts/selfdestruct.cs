using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class selfdestruct : MonoBehaviour 
{

	public float destroytime;
	void Start () 
	{
		StartCoroutine("Destroy");
	}
	IEnumerator Destroy ()
	{
		yield return new WaitForSeconds(destroytime);
		Destroy (this.gameObject);
	}

}
