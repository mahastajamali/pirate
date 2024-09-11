using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ship : MonoBehaviour
{
    [SerializeField] float moveSpeed = 0.01f;
    [SerializeField] private float movement = 0.01f;
    private const float Xmin = -2.2f;
    private const float Xmax = 2.5f;
    private int _health= 3;
    private bool _gameOver=false;
    void Update()
    {
        float steerAmount = Input.GetAxis("Horizontal")*movement;
        var x = Mathf.Clamp(transform.position.x, Xmin, Xmax);
        transform.position = new Vector3(x, transform.position.y);
        if(_gameOver==false)
        {
         transform.Translate(steerAmount,moveSpeed,0);
        
        }
     
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        var otherGameObject = other.gameObject;
        if (otherGameObject.tag == "OB")
        {
            DecreaseHealth();
            if (_gameOver)
            {
                Debug.Log("GAME OVER");
                Time.timeScale = 0;
            }
            else
                Destroy(other.gameObject);
        }
    }

    private void DecreaseHealth()
    {
        _health--;
        if (_health > 0)
        {
            Debug.Log("Player Health" + _health);
        }
        else
        {
            _gameOver = true;
        }
    }
}
