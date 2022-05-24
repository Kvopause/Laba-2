using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving : MonoBehaviour
{
    public float speed;
    public Rigidbody rigbd;

    void FixedUpdate()
    {
        if (Input.GetAxis("Horizontal") == -1)
        {
            rigbd.AddForce(-speed * Time.deltaTime, 0, 0);
        }
        if (Input.GetAxis("Vertical") == 1)
        {
            rigbd.AddForce(0, 0, speed * Time.deltaTime);
        }
        if (Input.GetAxis("Horizontal") == 1)
        {
            rigbd.AddForce(speed * Time.deltaTime, 0, 0);
        }
        if (Input.GetAxis("Vertical") == -1)
        {
            rigbd.AddForce(0, 0, -speed * Time.deltaTime);
        }
        if (Input.GetKeyDown(KeyCode.Space) && transform.position.y == 0.5)
        {
            rigbd.AddForce(0, 500f, 0);
        }
    }
}
