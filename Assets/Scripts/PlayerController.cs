using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.EventSystems;

public class PlayerController : MonoBehaviour
{
    
    Rigidbody rb;
    
    public ScoreManager scoreManager;
    [SerializeField]
    private float speed = 10;

    float runMagnification = 2;
    public int Item=0;
    [SerializeField]
    private Transform follow_camera;
    [SerializeField]
    private Transform follow_Subcamera;
    //bool inputJumpButton;
    //bool isAcceleration=true;
    // [SerializeField]
    // private float jumpPower=2;
    [SerializeField]
    private Vector3 localGravity;
   
    public int inputAxisZ;
    int inputAxisX;
    bool isShift;
    
    //カウントアップ
    public float countup = 0.0f;
    int RunFlag=0;//0初期1走る2止まる
    public bool Flag=true;
    //タイムリミット
    float timeLimit = 5.0f;
   public bool EnemyStopFlag=true;
   int Key=0;
    void Start()
    {
        

        rb=GetComponent<Rigidbody>();
        
       
       //StartCoroutine("Coroutine");
        //Cursor.visible = false;
        //ほかのオブジェクトの呼び出し
        
    }
    
    // Update is called once per frame
    void Update()
    {
        if(Item!=0)
        {
            if(Input.GetKeyDown(KeyCode.E))
            {
                Flag=false;
                Item--;
            }
             
        }
        if(countup >= timeLimit)
        {
            RunFlag=2;
            countup=0.0f;
            EnemyStopFlag=true;
            
            Flag=true;
            Debug.Log(EnemyStopFlag);
            Debug.Log(countup);
            //countup=0.0f;
        }
        if(Flag==false)
        {
            CountUp();
            runFlag();
            
            Debug.Log(countup);
        }
        if(EnemyStopFlag==false)
        {
            CountUp();
            
        }
        InputUpdate();
        
        
    }
    void InputUpdate()
    {
        inputAxisX=0;
        inputAxisZ=0;
        //inputJumpButton=Input.GetKey(KeyCode.Space);
        if(Input.GetKey(KeyCode.W)){
          
            

            inputAxisZ=1;
        }
        
        
        
        //isShift=Input.GetKey(KeyCode.LeftShift);
       
    }
    void FixedUpdate()
    {
        //Move();
        CameraBasedMove();
        //Jump();
        SetLocalGravity();
    }
    // void Jump()
    // {

    //     if(inputJumpButton&&isGrounded){
    //         isGrounded=false;
    //         rb.velocity+=new Vector3(0,jumpPower,0);
    //     }
    // }
    void SetLocalGravity()
    {
        rb.AddForce(localGravity,ForceMode.Acceleration);
    }

    // void Move()
    // {
    //    Vector3 vec=new Vector3();
    //    vec.x=speed*inputAxisX;
    //    vec.y=rb.velocity.y;
    //    vec.z=speed*inputAxisZ;
    //    rb.velocity=vec;
    //    if(isShift){
    //     rb.velocity*=runMagnification;
    //    }
      
    // }
    // void OnMouseDown()
    // {
        
        
    // }
    void CameraBasedMove()
    {
        Vector3 vec =new Vector3();

        //vec =follow_camera.right*inputAxisX;
        vec+=follow_camera.forward*inputAxisZ;
        
        vec*=speed;
        // vec.y=rb.velocity.y;
        // rb.velocity=vec*speed;
        if(RunFlag==1){
            vec*=runMagnification;
        }
        vec.y=rb.velocity.y;
        rb.velocity=vec;
        if(vec.x!=0||vec.z!=0){
            Vector3 dir=vec;
            dir.y=0f;
            transform.LookAt(transform.position+dir);
        }
    }
    void SubCameraBasedMove()
    {
        Vector3 vec =new Vector3();

        //vec =follow_camera.right*inputAxisX;
        vec+=follow_Subcamera.forward*inputAxisZ;

        vec*=speed;
        // vec.y=rb.velocity.y;
        // rb.velocity=vec*speed;
        // if(RunFlag==1){
        //     vec*=runMagnification;
        // }
        vec.y=rb.velocity.y;
        rb.velocity=vec;
        if(vec.x!=0||vec.z!=0){
            Vector3 dir=vec;
            dir.y=0f;
            transform.LookAt(transform.position-dir);
        }
    }
    public void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag=="Acceleration")
        {
            Item++;
        }
        if(other.gameObject.tag=="EnemyStop")
        {
            EnemyStopFlag=false;
            
        }
         
    }
    void CountUp()
    {
        
        //時間をカウントする
        countup += Time.deltaTime;
        
        //Debug.Log(RunFlag);
        //   Debug.Log("RunFlag2");
        //   Debug.Log(RunFlag);
                
        
        
        
        
    }
    void runFlag()
    {
        RunFlag=1;
        if(RunFlag==2)
        {
            //countup=0.0f;
            //Flag=true;
            RunFlag=0;
            // Debug.Log("Flag2");
            // Debug.Log(Flag);
        }
    }
    
    
}
