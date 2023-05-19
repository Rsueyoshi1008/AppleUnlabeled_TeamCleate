using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class SlimeController : MonoBehaviour
{
    public Transform target;
    private NavMeshAgent myAgent;
    public PlayerController playercontroller;
    UnityEngine.AI.NavMeshAgent rend;
    bool isHearted=true;
    bool EnemyStopFlag=true;
    float countup=0f;
    float timeLimit= 5.0f;


    //int EnemyCount=0;
    void Start()
    {
        rend = GetComponent<UnityEngine.AI.NavMeshAgent>();
        rend.enabled = true;
        myAgent=GetComponent<NavMeshAgent>(); 
    }

    void Update()
    {
        
        EnemyStopFlag=(playercontroller.EnemyStopFlag);
        if(EnemyStopFlag==false)
        {
            enemydelete();
        }
        if(EnemyStopFlag==true)
        {
           enemyappear();
           myAgent.SetDestination(target.position);
        }

    }
    // void InputUpdate()
    // {
        
    // }
    void OnCollisionEnter(Collision other)
    {
        // if(other.gameObject.tag=="Heart")
        // {
        //     EnemyCount++;
        // } 
    }
    void enemydelete()
    {
        rend.enabled = false;
    }
    void enemyappear()
    {
        rend.enabled = true;
    }
    
}
