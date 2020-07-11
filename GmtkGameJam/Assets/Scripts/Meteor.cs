using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meteor : MonoBehaviour
{

    public Transform target;
    public float Force = 5f;



    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<Rigidbody>().AddForce((InstantiateMeteor.instance.target.position - transform.position) * Force);
    }
    // Update is called once per frame
    void FixedUpdate()
    {
       
       //transform.position = Vector3.MoveTowards(transform.position, InstantiateMeteor.instance.target.position, Time.deltaTime*meteorVelecity);
    }
}
