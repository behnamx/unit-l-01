using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    public float bulletSpeed;
    public int destroyTime = 1;

    void Start()
    {
        // Initializing debugging log
        Debug.Log("Ready to roll out!");
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.up * bulletSpeed * Time.deltaTime;
        Destroy(gameObject, destroyTime);
    }
}