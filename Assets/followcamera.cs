using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followcamera : MonoBehaviour
{
    [SerializeField] private GameObject thingsToFollow;

    private void LateUpdate()
    {
        transform.position = thingsToFollow.transform.position + new Vector3(0, 0, -10);
    }
}
