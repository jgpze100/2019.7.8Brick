using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordGetsorce : MonoBehaviour
{
    
    GameManager GameManager;
    bool sorce;
    
    // Start is called before the first frame update
    void Start()
    {

        GameManager = GameObject.Find("GM").GetComponent<GameManager>();
        
    }

    private void OnTriggerEnter2D(Collider2D c)
   {

        if (c.gameObject.tag == "磚塊")
        {
            GameManager.Gr++;
            
        }
    }
}
