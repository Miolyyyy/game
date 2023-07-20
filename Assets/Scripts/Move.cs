using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float Speed;

    public Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(Vector3.forward * Speed);
            //transform.position += Vector3.forward * Speed * Time.deltaTime;
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }
        if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(Vector3.back * Speed);
            //transform.position -= Vector3.forward * Speed * Time.deltaTime;
            transform.rotation = Quaternion.Euler(0, 180, 0);
        }
        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(Vector3.left * Speed);
            //transform.position -= Vector3.right * Speed * Time.deltaTime;
            transform.rotation = Quaternion.Euler(0, -90 , 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(Vector3.right * Speed);
            //transform.position += Vector3.right * Speed * Time.deltaTime;
            transform.rotation = Quaternion.Euler(0, 90, 0);
        }

    }
}
