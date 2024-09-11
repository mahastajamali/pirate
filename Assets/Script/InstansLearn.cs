using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstansLearn : MonoBehaviour
{
    public GameObject Stone;

    public Transform instansPoint;
    
    void Start()
    {
        StartCoroutine(InstansObsticle());
        Debug.Log("HE HE HE HE ");
    }

    private IEnumerator InstansObsticle()
    {
        Instantiate(Stone, instansPoint.position, instansPoint.rotation);
        Debug.Log("Create Stone");
        yield return new WaitForSeconds(2);
        Debug.Log("Call Instans ");
        StartCoroutine(InstansObsticle());

    }

   
}
