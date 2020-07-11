using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateEarth : MonoBehaviour
{
    public float RotateSpeed =0.05f;
    void FixedUpdate()
    {
        transform.Rotate(Vector3.right* Time.deltaTime*RotateSpeed);
    }
}
