using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Changer : MonoBehaviour 
{

	public GameObject clickerone;
	public GameObject clickertwo;
	public GameObject clickerthree;
	public GameObject defaultForm;
	public GameObject formone;
	public GameObject formtwo;
	public GameObject formthree;
	public GameObject playerposition;
	public GameObject transformable;
	public GameObject nontransforable;

	public float ChangeTime;
	//max changetime will be 10
	public float MaxChangeTime;
	public float PlayerAmountNeeded;
	public float WaitToChangeForms;

	void Start ()
	{
		clickerone.SetActive (false);
		clickertwo.SetActive (false);
		clickerthree.SetActive (false);
		StartCoroutine("Add");
	}
	IEnumerator Add ()
	{
		ChangeTime += 1;
		yield return new WaitForSeconds(WaitToChangeForms);
		StartCoroutine("Add");
	}


	void Update () 
	{
		if (ChangeTime > 9) 
		{
			transformable.SetActive (true);
			nontransforable.SetActive (false);
		}
		else
		{
			transformable.SetActive (false);
			nontransforable.SetActive (true);
		}
		if (ChangeTime > MaxChangeTime) 
		{
			ChangeTime = MaxChangeTime;
		
		} 
		if (Input.GetKeyUp (KeyCode.Alpha1) && ChangeTime >= PlayerAmountNeeded) 
		{
			formone.SetActive (true);
			defaultForm.SetActive (false);
			formtwo.SetActive (false);
			formthree.SetActive (false);
			formone.transform.position = playerposition.transform.position;
			playerposition = GameObject.FindGameObjectWithTag("location");
			ChangeTime -= PlayerAmountNeeded;
			clickerone.SetActive (true);
			clickertwo.SetActive (false);
			clickerthree.SetActive (false);
		}
		if (Input.GetKeyUp (KeyCode.Alpha2) && ChangeTime >= PlayerAmountNeeded) 
		{
			formtwo.SetActive (true);
			defaultForm.SetActive (false);
			formone.SetActive (false);
			formthree.SetActive (false);
			formtwo.transform.position = playerposition.transform.position;
			playerposition = GameObject.FindGameObjectWithTag("location");
			ChangeTime -= PlayerAmountNeeded;
			clickerone.SetActive (false);
			clickertwo.SetActive (true);
			clickerthree.SetActive (false);
		}
		if (Input.GetKeyUp (KeyCode.Alpha3) && ChangeTime >= PlayerAmountNeeded) 
		{
			formthree.SetActive (true);
			defaultForm.SetActive (false);
			formone.SetActive (false);
			formtwo.SetActive (false);
			formthree.transform.position = playerposition.transform.position;
			playerposition = GameObject.FindGameObjectWithTag("location");
			ChangeTime -= PlayerAmountNeeded;
			clickerone.SetActive (false);
			clickertwo.SetActive (false);
			clickerthree.SetActive (true);
		}
	}
}
