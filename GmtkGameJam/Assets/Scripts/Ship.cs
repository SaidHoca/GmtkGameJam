using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ship : MonoBehaviour
{
    public static Ship instance;

   // public Transform leftPoint, rightPoint, topPoint, bottomPoint;

    public bool kuvvet = false;


	// Start is called before the first frame update
	private void Awake()
	{
        MakeInstance();
	}

	private void Start()
	{
       
	}

	void MakeInstance()
	{
        if (instance == null) instance = this;
	}

	// Update is called once per frame
	void Update() {
		//if (!kuvvet)
		//{
		//	transform.Rotate(0, Time.deltaTime * 5.0f, 0);
		//}
  //      else if (kuvvet)
		//{
		//	transform.Rotate(0, -Time.deltaTime * 5.0f, 0);
		//}
    }

    //public void OnTriggerEnter(Collider other)
    //{
    //    Destroy(other.gameObject);
    //    Debug.Log("çarptı");
    //    transform.rotation = Quaternion.Slerp(transform.rotation, new Quaternion(0,0,-70,0), 0.2f);
    //}

    
}
