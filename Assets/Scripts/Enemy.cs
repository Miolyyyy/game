using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    GameObject player;

    public float speed;
    public int health;
    public float rotation_speed;

    private AddRoom room;

    void Start()
    {
        player = GameObject.FindWithTag("Player");
        room = GetComponentInParent<AddRoom>();
    }

    private void Update()
    {
        if (health <= 0)
        {
            Destroy(gameObject);
            room.enemies.Remove(gameObject);
        }

        float direction = player.transform.position.x - transform.position.x;
        float direction1 = player.transform.position.z - transform.position.z;

        if (Mathf.Abs(direction) < 7)
        {
            Vector3 pos = transform.position;
            pos.x += Mathf.Sign(direction) * speed * Time.deltaTime;
            pos.z += Mathf.Sign(direction1) * speed * Time.deltaTime;
            transform.position = pos;

            var look_dir = player.transform.position - transform.position;
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(look_dir), rotation_speed * Time.deltaTime);
        }
    }

    public void TakeDamage(int damage)
    {
        health -= damage;
    }
}
