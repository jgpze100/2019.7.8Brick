using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 生成磚塊 : MonoBehaviour
{
    //第一個磚塊的位置
    public int StartX = -4;
    public int StartY = 4;
    //磚塊單位
    public GameObject Blue;
    
    // Start is called before the first frame update
    void Start()
    {
        for(int i=0;i <= 10;i++)
        {
            for(int j=0;j <=10 ;j++)
            {
              
                //複製磚塊
                Instantiate(Blue,new Vector3(StartX + i , StartY - j, 0),  Quaternion.identity);
            }

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
