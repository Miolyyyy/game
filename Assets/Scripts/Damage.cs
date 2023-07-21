using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{
    public int damageCount = 1;

    //private void OnCollision(Collision collision)
    //{
    //    StartCoroutine(FindObjectOfType<PlayerManager>().Damage(damageCount));
    //}

    void OnTriggerEnter(Collider myTrigger)
    {
        if (myTrigger.gameObject.name == "Player")
        {
            FindObjectOfType<PlayerManager>().Damage(damageCount);
        }
    }
}
