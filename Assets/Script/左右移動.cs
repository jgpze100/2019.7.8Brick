using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 左右移動 : MonoBehaviour
{

    public float MoveSpeed = 8f;
    public GameObject racket;
    public Animator anim;
    GameManager GameManager;

   
    void Start()

    {
        anim = racket.GetComponent<Animator>();
        GameManager = GameObject.Find("GM").GetComponent<GameManager>();

        

    }


     void Update()

        {
        
          Move();


        if ( Input.GetKey(KeyCode.W) && GameManager.skill >= 10)
          {
            GameManager.skill -= 10;
            anim.SetBool("scroll",true);

          }
        else
        {
            anim.SetBool("scroll", false);
        }
       
          
        }
    void Move()
    {
        if (Input.GetKey(KeyCode.A))
        {

            //當球拍未超過螢幕左側時移動,否則球拍不能再移動
            if (transform.position.x > -8)
            {
                transform.Translate(Vector3.left * Time.deltaTime * MoveSpeed);
            }
            else
            {
                transform.position = new Vector3(-8, transform.position.y, transform.position.z);
            }




        }
        if (Input.GetKey(KeyCode.D))
        {
            if (transform.position.x < 8)
            {
                transform.Translate(Vector3.left * Time.deltaTime * (-MoveSpeed));
            }
            else
            {
                transform.position = new Vector3(8, transform.position.y, transform.position.z);
            }
        }
    }

        /*private void OnCollisionEnter(Collision c)
        {
            if(c.gameObject.tag == "球" )
            {


            }
        }*/
    
}
