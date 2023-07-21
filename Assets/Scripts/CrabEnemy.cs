using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrabEnemy : MonoBehaviour
{

    //public float speed;

    public int health;
    public Transform player;
    public float move_speed;
    public float rotation_speed;
    public Transform enemy;

    private AddRoom room;


    void Start()
    {
        room = GetComponentInParent<AddRoom>();
    }

    void Update()
    {
        if (health <= 0)
        {
            Destroy(gameObject);
            room.enemies.Remove(gameObject);
        }

        var look_dir = player.position - enemy.position;
        look_dir.z = 0;
        enemy.rotation = Quaternion.Slerp(enemy.rotation, Quaternion.LookRotation(look_dir), rotation_speed * Time.deltaTime);
        enemy.position += enemy.forward * move_speed * Time.deltaTime;
    }

    public void TakeDamage(int damage)
    {
        health -= damage;
    }
}
