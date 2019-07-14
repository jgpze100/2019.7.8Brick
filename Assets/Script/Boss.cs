using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : MonoBehaviour
{
    
    public bool Attack;
    GameManager GameManager;
    Animator anim;
    int Atk;
   
    void Start()
    {
        GameManager = GameObject.Find("GM").GetComponent<GameManager>();
        anim = GetComponent<Animator>();
        
        Attack = false;

    }

    
    void Update()
    {
        if (GameManager.BOSS_Score >= 156)
        {
            anim.SetBool("angry", true);
            GameManager.BOSS_Score = 0;
            anim.SetBool("Reach", true);
            
            print("ATK是TRUE");

        }
        else
        {
            anim.SetBool("angry", false);
        }

        if (Attack == true)
        {
            int t = Random.Range(0, 2);
            switch (t)
            {
                case 0:
                    Attack = false;
                    print("ATK是false 1");
                    break;
                case 1:
                    Attack = false;
                    print("ATK是false 2");
                    break;
            }






        }



       /* if (Attack == true)
        {
            Invoke("等待執行", 3);
            
            if (Atk == 1)
            {
                anim.SetBool("attack1", true);
                Attack = false;
            }
            if (Atk == 2)
            {
                anim.SetBool("attack2", true);
                Attack = false;
            }*/




            /*if( Atk == 0)
            {
                anim.SetBool("attack_1", true); 
                Attack = false;
            }
            else
            {
                anim.SetBool("attack_1", false);
            }
            if()
            {
                anim.SetBool("attack_2", true);
            }
            else
            {
                anim.SetBool("attack_2", false);
                Attack = false;
            }*/

        }
        
    }
    
