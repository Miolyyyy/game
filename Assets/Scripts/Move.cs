using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float Speed;

    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += Vector3.forward * Speed * Time.deltaTime;
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position -= Vector3.forward * Speed * Time.deltaTime;
            transform.rotation = Quaternion.Euler(0, 180, 0);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position -= Vector3.right * Speed * Time.deltaTime;
            transform.rotation = Quaternion.Euler(0, -90 , 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += Vector3.right * Speed * Time.deltaTime;
            transform.rotation = Quaternion.Euler(0, 90, 0);
        }
    }
}
