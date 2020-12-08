using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWalk2 : MonoBehaviour
{
    public int playerSpeed;

    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetButton("Fire1"))
        {
            transform.position = transform.position + Camera.main.transform.forward * playerSpeed * Time.deltaTime;
        }
    }
}
