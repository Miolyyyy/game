using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    GameObject player;

    public float speed;
    public int health;

    void Start()
    {
        player = GameObject.FindWithTag("Player");
    }

    private void Update()
    {
        if (health <= 0)
        {
            Destroy(gameObject);
        }

        float direction = player.transform.position.x - transform.position.x;
        float direction1 = player.transform.position.z - transform.position.z;

        if (Mathf.Abs(direction) < 20)
        {
            Vector3 pos = transform.position;
            pos.x += Mathf.Sign(direction) * speed * Time.deltaTime;
            pos.z += Mathf.Sign(direction1) * speed * Time.deltaTime;
            transform.position = pos;
        }
    }

    public void TakeDamage(int damage)
    {
        health -= damage;
    }
}
