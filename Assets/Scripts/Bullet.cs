using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float lifetime;
    public float distance;
    public int damage;
    public LayerMask whatIsSolid;
    public float speed=2f;

    private Rigidbody rb;

 

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.forward, out hit, distance, whatIsSolid))
        {
            if (hit.collider != null)
            {
                if (hit.collider.CompareTag("Enemy"))
                {
                    hit.collider.GetComponent<Enemy>().TakeDamage(damage);
                }
                Destroy(gameObject);
            }

            //Перепробованные варианты
            //gameObject.GetComponent<Rigidbody>().AddForce(transform.forward * speed, ForceMode.Impulse);
            transform.position = transform.position + new Vector3(speed * Time.deltaTime, 0, 0);
            //transform.Translate(transform.forward * speed);
            //rb.AddForce(transform.forward * speed);
        }
        if (lifetime <= 0)
        {
            Destroy(gameObject);
        }
        else
        {
            lifetime -= Time.deltaTime;
        }
    }
}
