using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class InstantiateMeteor : MonoBehaviour
{
    public Transform target;
    public Transform [] points;
    public GameObject[] meteorsPrefab;
    public bool yarat = false;
    public int indisPoints,indisMeteors;

    public static InstantiateMeteor instance;

	private void Awake()
	{
        MakeInstance();
	}

	void MakeInstance()
	{
        if (instance == null) instance = this;
	}
 
    void Update()
    {
        if(yarat)
		{
            InstantiateMeteors();
            yarat = false;
		}
    }

    public void InstantiateMeteors()
	{
		indisPoints = Random.Range(0, 8);
        indisMeteors = Random.Range(0,4);
        GameObject meteor = Instantiate(meteorsPrefab[indisMeteors],points[indisPoints].position, Quaternion.Euler(0.0f, 0.0f, Random.Range(0.0f, 360.0f)));                
	}
}
