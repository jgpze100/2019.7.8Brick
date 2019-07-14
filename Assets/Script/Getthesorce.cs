using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Getthesorce : MonoBehaviour
{
    GameManager GameManager;
    
   
    
    
    void Start()
    {
        GameManager = GameObject.Find("GM").GetComponent<GameManager>();
        
    }

    
    void Update()
    {

    }

    
    private void OnCollisionEnter2D(Collision2D c)
    {
        if(c.gameObject.tag =="磚塊")
        {
            GameManager.Gr++;
            GameManager.skill ++;
            

        }
    }
}
