using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class followcamera : MonoBehaviour
{
    [SerializeField] 
    private GameObject thingsToFollow;

    [SerializeField] 
    [Range(-10, 10)] 
    private float yOffSet;
    private void LateUpdate()
    {
        transform.position = 
            new Vector3(transform.position.x, thingsToFollow.transform.position.y+yOffSet,transform.position.z);
    }
}
