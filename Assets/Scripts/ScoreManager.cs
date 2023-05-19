using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ScoreManager : MonoBehaviour
{
    public GameManagement gameManagement;
    public PlayerController playerController;
    int Heart;
    public bool Flag=true;
    int Acceleration=0;
    bool KeyFlag=false;
    //テキストとスコアの変数宣言
    public Text Scoretext;
    public Text Accelerationtext;
    

    void Start()
    {
        Heart=(gameManagement.Heart);
        
    }
    void Update()
    {
        
            if(Acceleration!=0)
            {
                KeyFlag=true;
            }
            else
            {
                KeyFlag=false;
            }
        if(KeyFlag==true)
        {
            Debug.Log(KeyFlag);
            if(Input.GetKeyDown(KeyCode.E)){
                Acceleration--;
                Accelerationtext.text=string.Format("加速アイテム"+Acceleration);
                
            }
        }
        
    }
    public void OnCollisionEnter(Collision other)
    {
        //Heartに当たったらscoreが一つずつ減る
        if(other.gameObject.tag=="Heart")
        {
            Heart--;
            Scoretext.text=string.Format("ハート残り"+Heart);
        }
        if(other.gameObject.tag=="Acceleration")
        {
            Acceleration=(playerController.Item);
            Accelerationtext.text=string.Format("加速アイテム"+Acceleration);
            
        }
    }
    
}
