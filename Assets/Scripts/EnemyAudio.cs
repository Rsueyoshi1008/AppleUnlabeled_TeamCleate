using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAudio : MonoBehaviour
{
    AudioSource audio;
    public PlayerController playercontroller;
    public AudioClip SE2;
    bool Enemystp;
    float count=0.0f;
    // Start is called before the first frame update
    void Start()
    {
        audio=GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
        Enemystp=(playercontroller.EnemyStopFlag);
        count++;
        if(count%120==0)
       {
        if(Enemystp==false)
        {

        }
        else
        {
            Enemyaudio();
        }
        
       }
    }
    void Enemyaudio()
    {
        audio.PlayOneShot(SE2,1f);
    }
}
