using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving : MonoBehaviour
{
    void Update()
    {
        if(Input.GetKey(KeyCode.A))
        {
            var pos = transform.position;
            pos.x -= 1f * Time.deltaTime;
            transform.position = pos;
        }
        if (Input.GetKey(KeyCode.D))
        {
            var pos = transform.position;
            pos.x += 1f * Time.deltaTime;
            transform.position = pos;
        }
        if (Input.GetKey(KeyCode.W))
        {
            var pos = transform.position;
            pos.z += 1f * Time.deltaTime;
            transform.position = pos;
        }
        if (Input.GetKey(KeyCode.S))
        {
            var pos = transform.position;
            pos.z -= 1f * Time.deltaTime;
            transform.position = pos;
        }
    }
}
