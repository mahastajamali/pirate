using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ship : MonoBehaviour
{
    [SerializeField] float moveSpeed = 0.01f;
    [SerializeField] private float movement = 0.01f;
    private const float Xmin = -2.2f;
    private const float Xmax = 2.5f;
  
    
    void Update()
    {
        float steerAmount = Input.GetAxis("Horizontal")*movement;
        var x = Mathf.Clamp(transform.position.x, Xmin, Xmax);
        transform.position = new Vector3(x, transform.position.y);
        transform.Translate(steerAmount,moveSpeed,0);
     
    }
    bool gameOver;
    private void OnTriggerEnter2D(Collider2D other)
    {
       
        var otherGameObject = other.gameObject;
        if (otherGameObject.tag=="OB"&& gameOver)
        {
            Debug.Log("GAME OVER");
        }

        if (otherGameObject.tag=="OB" && !gameOver)
        {
            Destroy(other.gameObject);
        }
    }
}
