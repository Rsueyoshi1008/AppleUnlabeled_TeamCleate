using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraContoller : MonoBehaviour
{
    //カメラを格納する変数
    public Camera Camera;
    public Camera subCamera;
 
    //キャンバスを格納
    public GameObject Canvas;
    //Start is called before the first frame update
    void Start()
    {
        //初めはサブカメラをオフにしておく
        subCamera.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        //InputUpdate();
    }
    //ボタンを押した時の処理
    // public void InputUpdate()
    // {
    //     if(Input.GetKey(KeyCode.K))
    //     {
            
        
    //     }
    // }
    public void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag=="Acceleration")
        {
            //もしサブカメラがオフだったら
            if (!subCamera.enabled)
        {
            //サブカメラをオンにして
            subCamera.enabled = true;
 
            //カメラをオフにする
            Camera.enabled = false;
 
            //キャンバスを映すカメラをサブカメラオブジェクトにする
            Canvas.GetComponent<Canvas>().worldCamera = subCamera;
        }
        //もしサブカメラがオンだったら
        else
        {
            //サブカメラをオフにして
            subCamera.enabled = false;
 
            //カメラをオンにする
            Camera.enabled = true;
 
            //キャンバスを映すカメラをカメラオブジェクトにする
            Canvas.GetComponent<Canvas>().worldCamera = Camera;
        }
        }
         
    }
}
