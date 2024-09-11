using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ship : MonoBehaviour
{
    [Header("Ship Speed ")]
    [SerializeField] 
    float moveSpeed ;
    [SerializeField] 
    private float movement ;
    [SerializeField] 
    [Range(0, 5)]
    private float speedScaleUp;
    
    [Header("UI")]
    [SerializeField]
    private TMP_Text healthText;
    [SerializeField] 
    private TMP_Text countScore;
    
    public UIManger UIManger;
    private const float Xmin = -2.2f;
    private const float Xmax = 2.5f;
    private int _health= 3;
    private bool _gameOver=false;
    private float _score=0;
    public void Start()
    {
        healthText.text = _health.ToString();
        countScore.text = _score.ToString();
    }

    void Update()
    {
        CountScore();
        float steerAmount = Input.GetAxis("Horizontal")*movement;
        var x = Mathf.Clamp(transform.position.x, Xmin, Xmax);
        transform.position = new Vector3(x, transform.position.y);
        if(_gameOver==false)
        {
         transform.Translate(steerAmount,moveSpeed*(_score/speedScaleUp),0);
        
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
        healthText.text = _health.ToString();
        if (_health > 0)
        {
            Debug.Log("Player Health" + _health);
        }
        else
        {
            _gameOver = true;
        }
        
    }

    private void CountScore()
    {
        _score = _score + Time.deltaTime;
       int _intScore=Convert.ToInt32(_score);
        countScore.text = _intScore.ToString();
    }
      
}
