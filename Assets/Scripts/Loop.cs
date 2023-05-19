using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loop : MonoBehaviour
{
    public float speed;
    float counter=0.0f;
    public float countLimt;
    bool Flag=false;
    Rigidbody rb;
    //float Move=0.0f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 vec=new Vector3(0,speed,0);
        transform.Translate(vec);
        counter+=Time.deltaTime;
        if(counter>=countLimt)
        {
            counter=0.0f;
            speed*=-1;
           
        }


    }
    

}
