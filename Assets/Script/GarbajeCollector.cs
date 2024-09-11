using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GarbajeCollector : MonoBehaviour
{
    private const int YOffSet = 30;
    private void OnTriggerEnter2D(Collider2D other)
    {
        
        var otherGameObject = other.gameObject;
        if (otherGameObject.CompareTag("BG"))
        {
            var backGroundTransform = otherGameObject.transform;
            var position = backGroundTransform.position;
            var yNewPos = (position.y) + YOffSet;
            position = new Vector3(position.x, yNewPos, position.z);
            backGroundTransform.position = position;
        }
        if (otherGameObject.tag=="OB")
        {
            Destroy(other.gameObject);
        }
    }

  
}
