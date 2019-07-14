using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class 被球打到 : MonoBehaviour
{
    int HP = 0;
    GameManager GameManager;

    void Start()
    {
        GameManager = GameObject.Find("GM").GetComponent<GameManager>();
        /*int brick = Random.Range(0, 4);
        switch(brick)
        {
            default:
                break;
            case 3:
                 gameObject.SetActive(false);
                break;

        }*/
    }


    void Update()
    {
        //一鍵通關
        if(Input.GetKey(KeyCode.H))
        {
            gameObject.SetActive(false);
            GameManager.Gr += 3;
            GameManager.boss = true;
        }
        if (GameManager.Gr >= 156)
        {
            GameManager.boss = true;
        }
    }



    private void OnCollisionEnter2D(Collision2D c)
    {
        if(c.gameObject.tag == "球")
        {
            HP += 1 ;
            
            if (HP == 3)
            {
                this.gameObject.SetActive(false);
                
            }
        }
        
    }
    private void OnTriggerEnter2D(Collider2D o)
    {
        if (o.gameObject.tag == "sword")
        {
            HP += 1;

            if (HP == 3)
            {
                this.gameObject.SetActive(false);
            }
        }
    }
}
