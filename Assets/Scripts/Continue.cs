using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Continue : MonoBehaviour
{
    
    
    
    
    public void OnClickStartButton() {
        
        if(Stage1.Scene=="1")
        {
            SceneManager.LoadScene("Stage1");
        }
        if(Stage2.Scene=="2")
        {
            SceneManager.LoadScene("Stage2");
        }
        if(Stage3.Scene=="3")
        {
            SceneManager.LoadScene("SampleScene");
        }
	    
	}
    
}
    

