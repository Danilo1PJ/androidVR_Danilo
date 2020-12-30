using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCube: MonoBehaviour
{
    public float SpinForce;

    void Start()
    {
        
    }

    void Update()
    {
        transform.Rotate(0, SpinForce * Time.deltaTime, 0);
    }

    public void ChangeSpin()
    {
        SpinForce = -SpinForce;
    }
}
