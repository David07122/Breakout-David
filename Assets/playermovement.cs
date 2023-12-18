using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovement : MonoBehaviour
{
    Rigidbody2D rigi; 
    void Start()
    {
        rigi = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rigi.AddForce(new Vector3(100, 0, 0));
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rigi.AddForce(new Vector3(-100, 0, 0));
        }
    }
}
