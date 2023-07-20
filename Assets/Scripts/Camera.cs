using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
        public GameObject player;
        private Vector3 offset;

        void Start()
        {
            offset = transform.position;
        }

        void LateUpdate()
        {
            transform.position = player.transform.position + offset;
        }
}
