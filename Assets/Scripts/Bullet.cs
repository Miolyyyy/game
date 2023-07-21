using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float lifetime;
    public float distance;
    public int damage;
    public LayerMask whatIsSolid;
    public float speed=0.9f;

    private Rigidbody rb;

    //public GameObject carrot01;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        gameObject.transform.position = gameObject.transform.position - gameObject.transform.up;
        gameObject.GetComponent<Rigidbody>().AddForce(gameObject.transform.up * speed, ForceMode.Impulse);

        RaycastHit hit;
        if (Physics.Raycast(gameObject.transform.position, - gameObject.transform.up, out hit, distance, whatIsSolid)) ;
        {


            if (hit.collider != null)
            {
                if (hit.collider.CompareTag("Enemy"))
                {
                    hit.collider.GetComponent<Enemy>().TakeDamage(damage);

                }
                Destroy(gameObject);
            }
            if (hit.collider != null)
            {
                if (hit.collider.CompareTag("Crab"))
                {
                    hit.collider.GetComponent<CrabEnemy>().TakeDamage(damage);

                }
                Destroy(gameObject);
            }
            if (hit.collider != null)
            {
                Destroy(gameObject);
            }

            //Перепробованные варианты

            //transform.position = transform.position + new Vector3(speed * Time.deltaTime, 0, 0);
            //transform.GetComponent<Rigidbody>().AddForce(transform.forward * speed, ForceMode.Impulse);

            //gameObject.transform.position = gameObject.transform.position + gameObject.transform.forward;
            //gameObject.GetComponent<Rigidbody>().AddForce(gameObject.transform.forward * speed, ForceMode.Impulse);



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
