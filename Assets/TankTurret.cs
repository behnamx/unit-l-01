using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// Forward and backward movement class for Tank Turret
public class TankTurret : MonoBehaviour
{

    public float swizzleSpeed;
    public GameObject bullet;
    public GameObject textObject;
    public int Bullets = 0;
    public Text bulletText;


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
            ++Bullets;
            GameObject Muzzle = GameObject.Find("Muzzle");
            Instantiate(bullet, Muzzle.transform.position, transform.rotation);
            bulletText.text = "I love text. I love it good!";

        }
        bulletText.text = "Bullets: " + Bullets;


    }
}