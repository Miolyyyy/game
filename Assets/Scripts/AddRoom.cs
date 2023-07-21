using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddRoom : MonoBehaviour
{
    [Header("Doors")]
    public GameObject[] doors;

    [Header("Enemies")]
    public GameObject[] enemyTypes;
    public Transform[] enemySpawners;

    [HideInInspector] public List<GameObject> enemies;

    private RoomsVariants variants;
    private bool spawned;
    private bool doorsDestroyed;

    private void Start()
    {
        variants = GameObject.FindGameObjectWithTag("Rooms").GetComponent<RoomsVariants>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !spawned)
        {
            spawned = true;
            foreach(Transform spawner in enemySpawners)
            {
                GameObject enemyType =enemyTypes[Random.Range(0, 2)];
                GameObject enemy = Instantiate(enemyType, spawner.position, Quaternion.identity) as GameObject;
                enemy.transform.parent = transform;
                enemies.Add(enemy);
            }

            StartCoroutine(CheckEnemies());
        }

    }

    IEnumerator CheckEnemies()
    {
        yield return new WaitForSeconds(1f);
        yield return new WaitUntil(() => enemies.Count == 0);
        DestroyDoors();
    }

    public void DestroyDoors()
    {
        foreach(GameObject door in doors)
        {
            if (door != null && door.transform.childCount != 0)
            {
                Destroy(door);
            }
            
        }
        doorsDestroyed = true;
    }

    private void onTriggerStay(Collider other)
    {
        if(doorsDestroyed && other.CompareTag("Door"))
        {
            DestroyDoors();
        }
    }
}
