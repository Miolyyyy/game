using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
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

    //void OnTriggerStay(Collider telo)
    //{//если тело
    //    if (telo.CompareTag("enemy"){//с тегом enemy находится в зоне триггера(тот о котором я выше сказал)

    //        health -= damage);//отнять хп

    //    }
    public void TakeDamagePlayer(int damageEnemy)
    {
        health -= damageEnemy;
    }
}
