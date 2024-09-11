using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class followcamera : MonoBehaviour
{
    [SerializeField] 
    private GameObject thingsToFollow;

    private void LateUpdate()
    {
        transform.position = 
            new Vector3(transform.position.x, thingsToFollow.transform.position.y,transform.position.z);
    }
}
