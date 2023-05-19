using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IyemController : MonoBehaviour
{
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb=GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag=="Player")
        {
            Destroy(gameObject);
        }
         
    }
}
