using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class TextScript : MonoBehaviour {
    private Text bulletText;
    public int Bullets = 0;

    // Use this for initialization
    void Start () {
        bulletText = GetComponent<Text>();

    }

    // Update is called once per frame
    void Update () {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ++Bullets;
            bulletText.text = "Bullets: " + Bullets;

        }

    }
}
