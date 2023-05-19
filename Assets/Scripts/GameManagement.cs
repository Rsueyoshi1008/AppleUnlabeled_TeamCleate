using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagement : MonoBehaviour
{
    public bool Cursor=true;
    public bool Mouse=true;
    public int Heart;
    
    void Start()
    {
        
    }
    
    public void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag=="Enemy")
        {
            
            SceneManager.LoadScene("GameOverScene");
        }
        if(other.gameObject.tag=="Heart")
        {
            Heart--;
            if(Heart==0)
            {
                if(Stage1.Scene=="1")
                {
                    SceneManager.LoadScene("Clear1");
                }
                if(Stage2.Scene=="2")
                {
                    SceneManager.LoadScene("Clear2");
                }
                if(Stage3.Scene=="3")
                {
                    SceneManager.LoadScene("Clear3");
                }
            }
        }
    }
    
}
