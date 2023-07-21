using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class door : MonoBehaviour
{
    public GameObject block;

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Block"))
        {
            Instantiate(block, transform.GetChild(0).position, Quaternion.identity);
            Instantiate(block, transform.GetChild(1).position, Quaternion.identity);
            Instantiate(block, transform.GetChild(2).position, Quaternion.identity);
            Instantiate(block, transform.GetChild(3).position, Quaternion.identity);
        }
    }
}
