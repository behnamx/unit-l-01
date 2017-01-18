using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Forward and backward movement class for Tank Sprite
public class TankMovement : MonoBehaviour
{

    public float forwardMovement;
    public float backwardMovement;
    public float turnRate;

    void Start()
    {
        // Initializing debugging log
        Debug.Log("Ready to roll out!");
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.W))
        {
            gameObject.transform.position += gameObject.transform.up * forwardMovement * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.S))
        {
            gameObject.transform.position += gameObject.transform.up * backwardMovement * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0f, 0f, -turnRate * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0f, 0f, +turnRate * Time.deltaTime);
        }

    }
}