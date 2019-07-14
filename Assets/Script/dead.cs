using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class dead : MonoBehaviour
{
    public Text die;
    bool isdie = false;
    // Start is called before the first frame update
   

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space) && isdie == true)
        {
            SceneManager.LoadScene(0);
            
        }
    }

    private void OnTriggerEnter2D(Collider2D c)
    {
        if(c.gameObject.tag =="球")
        {
            c.gameObject.SetActive(false);
            Time.timeScale = 0;
            die.text = "         系阿啦\n按空白鍵可以重來";
            isdie = true;
            
        }
    }
}
