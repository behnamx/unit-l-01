﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Forward and backward movement class for Tank Turret
public class TankTurret : MonoBehaviour
{

    public float swizzleSpeed;
    public GameObject bullet;

    void Start()
    {
        // Initializing debugging log
        Debug.Log("Ready to roll out!");
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.E))
        {
            transform.Rotate(0f, 0f, -swizzleSpeed * Time.deltaTime);

        }

        if (Input.GetKey(KeyCode.Q))
        {
            transform.Rotate(0f, 0f, +swizzleSpeed * Time.deltaTime);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject Muzzle = GameObject.Find("Muzzle");
            Instantiate(bullet, Muzzle.transform.position, transform.rotation);
        }


    }
}