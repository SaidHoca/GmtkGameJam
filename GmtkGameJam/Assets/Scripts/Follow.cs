using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour
{

    public GameObject DirectTarget, LeftTarget, RightTarget, Ship, CenterShip;
    public GameObject planet;
    public float ShipRotateSpeed = 10f;
    public float ShipRotateAround = 0.2f;
    public float RotateSpeed = 5f;
    public float SmoothFactor = 0.1f;
    public int Target = 0; // 0 directiontarget,  1 right target, -1 left target
    public int SlidingSide = 0; // 0 no sliding.. 1 sliding right, -1 sliding left
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.A))
        {
            Target = -1;
            SlidingSide = -1;

		}else if (Input.GetKey(KeyCode.D))
        {
            Target = 1;
            SlidingSide = 1;
		}
		else
		{
            Target = 0;
		}
        
        
        if (Target == 1)
		{
            Ship.transform.RotateAround(CenterShip.transform.position,Vector3.up,Time.deltaTime*50f);          
            transform.position = Vector3.MoveTowards(transform.position, RightTarget.transform.position, Time.deltaTime*SmoothFactor);
            SmoothFactor += 0.01f;

        }
        else if (Target == -1)
        {
            Ship.transform.RotateAround(CenterShip.transform.position, -Vector3.up, Time.deltaTime * 50f);
            //Ship.transform.Rotate(0,0 , -Time.deltaTime * ShipRotateSpeed);
            transform.position = Vector3.MoveTowards(transform.position, LeftTarget.transform.position, Time.deltaTime * SmoothFactor);
            SmoothFactor += 0.01f;

		}
		else
		{
            SmoothFactor = 0.1f;
        }

        if(SlidingSide == -1) transform.position = Vector3.MoveTowards(transform.position, LeftTarget.transform.position, Time.deltaTime * SmoothFactor);
        else if (SlidingSide == 1 ) transform.position = Vector3.MoveTowards(transform.position, RightTarget.transform.position, Time.deltaTime * SmoothFactor);

        transform.RotateAround(planet.transform.position, Vector3.up, -1 * RotateSpeed * Time.deltaTime);
        DirectTarget.transform.RotateAround(planet.transform.position, Vector3.up, -1 * RotateSpeed * Time.deltaTime);
        //if(Target ==0)
        Ship.transform.Rotate(Vector3.up * ShipRotateAround);
        
       

    }

	
}
