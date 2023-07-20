using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{

    public GameObject bullet;
    public Transform spawnBullet;

    private float timeBtwShots;
    public float startTimeBtwShots;


    void Update()
    {
        if (timeBtwShots <= 0)
        {
            if (Input.GetKey(KeyCode.UpArrow))
            {
                transform.rotation = Quaternion.Euler(-90, -90, 90);
                Instantiate(bullet, spawnBullet.position, transform.rotation);
                timeBtwShots = startTimeBtwShots;
            }
            if (Input.GetKey(KeyCode.DownArrow))
            {
                transform.rotation = Quaternion.Euler(-90, 90, 90);
                Instantiate(bullet, spawnBullet.position, transform.rotation);
                timeBtwShots = startTimeBtwShots;
            }
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                transform.rotation = Quaternion.Euler(-90, 0, -90);
                Instantiate(bullet, spawnBullet.position, transform.rotation);
                timeBtwShots = startTimeBtwShots;

                
            }
            if (Input.GetKey(KeyCode.RightArrow))
            {
                transform.rotation = Quaternion.Euler(-90, 0, 90);
                Instantiate(bullet, spawnBullet.position, transform.rotation);
                timeBtwShots = startTimeBtwShots;
            }
        }
        else
        {
            timeBtwShots -= Time.deltaTime;
        }
    }

}
