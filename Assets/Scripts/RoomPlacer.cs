using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomPlacer : MonoBehaviour
{
    public Vector3 playerChangePos;
    private Camera cam;

    void Start()
    {
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")){
            other.transform.position += playerChangePos;
        }
    }
}

