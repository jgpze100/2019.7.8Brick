using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    static GameManager instacne;
    public GameObject SGT;
    public GameObject Grade;
    public GameObject Skill_A;
    public GameObject Blue;
    public GameObject FinalB;
    public Text Score;
    public Text SkillPoint;
    //分數
    public int Gr = 0;
    public int skill = 0;
    public int BOSS_HP = 0;
    public int BOSS_Score = 0;
    //第一個磚塊的位置
    public int StartX = -2;
    public int StartY = 4;
    public bool start;
    public bool boss;
    
   
    int LV;

// Start is called before the first frame update
    void Awake()
    {
        //如果不想被重置紀錄的話
        /*if(instacne == null)
        {
            instacne = this;
            DontDestroyOnLoad(this);
            name = "GM";
        }*/
        start = true;
        boss = false;
        FinalB.SetActive(false);
        Grade.SetActive(false);
        Skill_A.SetActive(false);
        SGT.GetComponent<Text>().text = "按下空白鍵開始遊戲";
        
        Time.timeScale = 0;
        




    }


    // Update is called once per frame
    void Update()
    {
        Score.text = "" + Gr;
        SkillPoint.text = "" + skill;
        BOSS_Score = Gr;
        if (Input.GetKey(KeyCode.Space) && start == true)
        {
            Time.timeScale = 1;
            Destroy(SGT.gameObject);
            Gr = 0;
            skill = 0;
            BOSS_HP = 0;
            
            Grade.SetActive(true);
            Skill_A.SetActive(true);
            start = false;


            for (int i = -4; i <= 8; i++)
            {
                for (int j = 0; j <= 3; j++)
                {

                    //複製磚塊
                    Instantiate(Blue, new Vector3(StartX + i, StartY - j, 0), Quaternion.identity);

                }

            }
            
        }
        if(Gr >= 156 && boss == true)
        {
            FinalB.gameObject.SetActive(true);
            boss = false;
        }
    }
}
