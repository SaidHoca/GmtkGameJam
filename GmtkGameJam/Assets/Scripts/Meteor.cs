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
}
