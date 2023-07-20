using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCharacteriticss: MonoBehaviour
{

    public int health;
    public int record;

    void Start()
    {
        
    }

    void Update()
    {
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }

    public void TakeDamage(int damage)
    {
        health -= damage;
    }
}
