using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 球移動 : MonoBehaviour
{
    public float 速度;
    float HF;
    GameManager GameManager;
    
    





    void Start()
    {
        GameManager = GameObject.Find("GM").GetComponent<GameManager>();

        int start = Random.Range(1, 4);
        switch (start)
        {
            case 1:
                
                GetComponent<Rigidbody2D>().velocity = Vector2.up * 速度;
                break;
            case 2:
                
                GetComponent<Rigidbody2D>().velocity = Vector2.left * 速度;
                break;
            case 3:
                
                GetComponent<Rigidbody2D>().velocity = Vector2.right* 速度;
                break;
        }
        

    }

  


    //可以通過簡單地將球的 x  坐標除以球拍的寬度來實現。
    float hitFactor(Vector2 ballPos, Vector2 racketPos, float racketWidth)
    {
        // ascii art:
        //
        // 1  -0.5  0  0.5   1  <- x value
        // ===================  <- racket
        //
        //減去  racketPos.x  從價值  ballPos.x  值，以獲得相對位置
        return (ballPos.x - racketPos.x) / racketWidth;
    }


    private void OnCollisionEnter2D(Collision2D ion)
    {
        if(ion.gameObject.tag == "球拍")
        {
            //計算命中位子
            float x = hitFactor(transform.position, ion.transform.position, ion.collider.bounds.size.x);
            //計算方向，將長度設置為1
            Vector2 dir = new Vector2(x, 1).normalized;
            //用dir *速度當命中球拍後的速度
            GetComponent<Rigidbody2D>().velocity = dir * 速度;

        }
        if(ion.gameObject.tag == "磚塊")
        {
            switch (GameManager.Gr)
            {
                default:
                    break;
                case 9:
                    速度 = 7;
                    break;
                case 19:
                    速度 = 9;
                    break;
                case 29:
                    速度 = 11;
                    break;

            }
        }

        if (ion.gameObject.CompareTag("boss"))
        {

          GameManager.BOSS_HP++;
          if (GameManager.BOSS_HP == 10)
          {
            ion.gameObject.SetActive(false);
          }
                
        }
    }

   
}
