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
    //{//���� ����
    //    if (telo.CompareTag("enemy"){//� ����� enemy ��������� � ���� ��������(��� � ������� � ���� ������)

    //        health -= damage);//������ ��

    //    }
    public void TakeDamagePlayer(int damageEnemy)
    {
        health -= damageEnemy;
    }
}
