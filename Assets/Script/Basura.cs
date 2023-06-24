using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Basura : MonoBehaviour
{
    Rigidbody body;
    float direction;
    public float min=0;
    public float max=1;
    void Start()
    {

        body=GetComponent<Rigidbody>();
        direction=Random.Range(5f,10f)*Mathf.Sign(transform.position.z)*-1;
        body.angularVelocity= new Vector3(Random.Range(min,max),Random.Range(min,max),Random.Range(min,max));
    }
    void Update() {
        body.velocity=new Vector3(body.velocity.x,body.velocity.y,direction);
    }
    void OnBecameInvisible(){
        Destroy(gameObject);
    }
}
