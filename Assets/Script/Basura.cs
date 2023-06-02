using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Basura : MonoBehaviour
{
    Rigidbody body;
    float direction;
    void Start()
    {

        body=GetComponent<Rigidbody>();
        direction=Random.Range(5f,10f)*Mathf.Sign(transform.position.z)*-1;
        
    }
    void Update() {
        body.velocity=new Vector3(body.velocity.x,body.velocity.y,direction);
    }
    void OnBecameInvisible(){
        Destroy(gameObject);
    }
}
