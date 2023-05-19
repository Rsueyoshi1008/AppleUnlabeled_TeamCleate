using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Stage1 : MonoBehaviour
{
    public static string Scene;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnClickStartButton(){
       SceneManager.LoadScene("Stage1");
       Scene="1";
    }
}
