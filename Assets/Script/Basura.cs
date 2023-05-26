using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Basura : MonoBehaviour
{
     Rigidbody body;
    void Start()
    {
        body=GetComponent<Rigidbody>();
        body.velocity=new Vector3(0,0,10);
    }
}
