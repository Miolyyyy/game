using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerRooms : MonoBehaviour
{
    public Direction direction;

    public enum Direction
    {
        Top,
        Bot,
        Left,
        Right,
        None
    }

    private RoomsVariants variants;
    private int rand;
    private bool spawned = false;
    private float waitTime = 3f;

    void Start()
    {
        variants = GameObject.FindGameObjectWithTag("Rooms").GetComponent<RoomsVariants>();
        Destroy(gameObject, waitTime);
        Invoke("Spawn", 0.3f);
    }

    public void Spawn()
    {
        if (!spawned)
        {
            if (direction == Direction.Top)
            {
                rand = Random.Range(0, variants.topRooms.Length);
                Instantiate(variants.topRooms[rand], transform.position, variants.topRooms[rand].transform.rotation);
            }
            else if (direction == Direction.Bot)
            {
                rand = Random.Range(0, variants.botRooms.Length);
                Instantiate(variants.botRooms[rand], transform.position, variants.botRooms[rand].transform.rotation);
            }
            else if (direction == Direction.Left)
            {
                rand = Random.Range(0, variants.leftRooms.Length);
                Instantiate(variants.leftRooms[rand], transform.position, variants.leftRooms[rand].transform.rotation);
            }
            else if (direction == Direction.Right)
            {
                rand = Random.Range(0, variants.rightRooms.Length);
                Instantiate(variants.rightRooms[rand], transform.position, variants.rightRooms[rand].transform.rotation);
            }
            spawned = true;
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Roompoint") && other.GetComponent<SpawnerRooms>().spawned)
        {
            Destroy(gameObject);
        }
    }

}
