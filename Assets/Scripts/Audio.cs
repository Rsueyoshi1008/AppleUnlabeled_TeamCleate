using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour
{
    public PlayerController playercontroller;
    int WalkFlag=0;
    public float WalkcountLimit;
    public float RuncountLimit;
    bool kasokuFlag=true;
    bool AudioFlag=false;
    float count=0.0f;
    AudioSource audio;
    public AudioClip SE1;
    public AudioClip SE2;
    // Start is called before the first frame update
    void Start()
    {
        audio=GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        WalkFlag=(playercontroller.inputAxisZ);
        kasokuFlag=(playercontroller.Flag);
       count++;
       
       if(count%RuncountLimit==0&&kasokuFlag==false&&WalkFlag==1)
       {
        AudioSound();
       }
       else if(count%WalkcountLimit==0&&WalkFlag==1)
       {
        AudioSound();
       }
        
        
    }
    void AudioSound()
    {
        audio.PlayOneShot(SE1,1f);
        // 
        // if(WalkFlag!=0&&AudioFlag==false)
        // {
        //     AudioFlag=true;
            
            
        //     count++;
        //     Debug.Log(count);
        //     if(count>=0.7f)
        //     {
        //         AudioFlag=false;
        //         count=0.0f;
        //     }
        // }
    }
    void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag=="Heart")
        {
            audio.PlayOneShot(SE2,1f);
        }
    }
}
