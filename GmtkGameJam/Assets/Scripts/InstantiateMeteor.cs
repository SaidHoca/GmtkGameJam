using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class InstantiateMeteor : MonoBehaviour
{
    public Transform target;
    public Transform [] points;
    public GameObject[] meteorsPrefab;
    [HideInInspector]public bool yarat = true;
    public bool start = false;
    public int indisPoints,indisMeteors;
    [HideInInspector] public float waitTime = 1.5f;


    public static InstantiateMeteor instance;

	private void Awake()
	{
        MakeInstance();

	}

	private void Start()
	{
        StartCoroutine(InstantiateMeteors());
    }

	void MakeInstance()
	{
        if (instance == null) instance = this;
	}

	private IEnumerator InstantiateMeteors()
    {
        Debug.Log("bu oldu");
        while (yarat)
        
        Debug.Log("buda oldu");
        indisPoints = Random.Range(0, 8);
        indisMeteors = Random.Range(0, 4);
        GameObject meteor = Instantiate(meteorsPrefab[indisMeteors], points[indisPoints].position, Quaternion.Euler(0.0f, 0.0f, Random.Range(0.0f, 360.0f)));
        yield return new WaitForSeconds(waitTime);
        StartCoroutine(InstantiateMeteors());
           
        
    }
}
