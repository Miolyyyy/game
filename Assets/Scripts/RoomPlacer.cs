using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomPlacer : MonoBehaviour
{
    public Vector3 playerChangePos;
    public Vector3 cameraChangePos;
    private Camera cam;

    void Start()
    {
        cam = Camera.main.GetComponent<Camera>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")){
            other.transform.position += playerChangePos;
            cam.transform.position += cameraChangePos;
        }
    }

}

