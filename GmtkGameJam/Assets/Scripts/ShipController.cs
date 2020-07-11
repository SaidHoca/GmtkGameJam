using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipController : MonoBehaviour
{

    // Gemi kontrol değişkenleri
    public Transform TargetDirection;
    public float RotateSpeed = 20f;


    public GameObject Planet;
    public float ShipSpeed = 20f;
    public bool crash = false;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {


        transform.RotateAround(Planet.transform.position, Vector3.up, -1*ShipSpeed*Time.deltaTime);

		// Player inputs
		if (Input.GetKey(KeyCode.A))
		{
            transform.RotateAround(TargetDirection.position, Vector3.up, RotateSpeed * Time.deltaTime);
           
		}
        if (Input.GetKey(KeyCode.D))
        {
            transform.RotateAround(TargetDirection.position, Vector3.down, RotateSpeed * Time.deltaTime);

        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.RotateAround(TargetDirection.position, Vector3.left, RotateSpeed * Time.deltaTime);

        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.RotateAround(TargetDirection.position, Vector3.right, RotateSpeed * Time.deltaTime);

        }
    }
}
