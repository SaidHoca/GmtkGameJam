using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollusionControl : MonoBehaviour
{

	public void OnTriggerEnter(Collider other)
	{
		Destroy(other.gameObject);
		Debug.Log("çarptı");
	}
}
