using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbitateSimple : MonoBehaviour
{
    public Transform target;
    public Vector3 axis = Vector3.up; 
    public float orbitSpeed = 20.0f; 

    void Update()
    {
        transform.RotateAround(target.position, axis, orbitSpeed * Time.deltaTime);
    }
}
