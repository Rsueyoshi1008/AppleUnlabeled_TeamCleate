using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CursorController : MonoBehaviour
{
    public GameManagement gameManagement;
    float Heart;
    
    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        Heart=(gameManagement.Heart);
    }
    void OnMouseDown()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision other)
    {
        
        Heart=(gameManagement.Heart);
        if(other.gameObject.tag=="Enemy")
        {
            //Debug.Log("AAAAAA");
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
            //SceneManager.LoadScene("GameOverScene");
        }
        if(Heart==0)
        {
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }
            
        
        
    }
}