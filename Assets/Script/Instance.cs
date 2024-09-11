using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Instance : MonoBehaviour
{
    public Transform[] instancePoint;

    public GameObject[] ObsticleObjects;
    
    void Start()
    {
        StartCoroutine(InstansObsticle());
    }

    private IEnumerator InstansObsticle()
    {
        int ObsricleIndex = Random.Range(0, ObsticleObjects.Length);
        int instancePointIndex = Random.Range(0, instancePoint.Length);
        Instantiate(ObsticleObjects[ObsricleIndex], instancePoint[instancePointIndex].position,
            instancePoint[instancePointIndex].rotation);
        yield return new WaitForSeconds(1.5f);
        StartCoroutine(InstansObsticle());
    }

   
}
