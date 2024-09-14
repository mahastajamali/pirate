using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManger : MonoBehaviour
{
    [SerializeField] 
    private Button puaseButton;
    // Start is called before the first frame update
    void Start()
    {
        puaseButton.onClick.AddListener(OnButtonClick);
    }
    
    public void OnButtonClick()
    {
        Debug.Log("Button Clicked ");
    }
}
