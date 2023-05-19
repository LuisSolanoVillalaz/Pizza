using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pizza : MonoBehaviour
{
    public Vector3 direction;
    Rigidbody body;
    bool canthrow= true;
    // Start is called before the first frame update
    void Start()
    {
        body=GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(ArmInput.GetSignalLeftArm()==Vector2.right&&ArmInput.GetSignalRightArm()== Vector2.zero&&canthrow){  //Solo sube el derecho
            body.velocity =direction;
            canthrow=false;
        }
        if(ArmInput.GetSignalLeftArm()==Vector2.zero&&ArmInput.GetSignalRightArm()== Vector2.right&&!canthrow){  //Solo sube el derecho
            body.velocity =Vector3.zero;
            transform.position= new Vector3(-4.53f,1.35f,0);
            canthrow=true;
        }
        
    }

    private void OnCollisionEnter(Collision other) {
        /*if(other.gameObject.name=="RArm"){
            Debug.Log("Lanzar");
        }else if(other.gameObject.name=="LArm"){
            Debug.Log("Fallo");
        }else */
        if(other.gameObject.name=="Horno"){
            Debug.Log("Point");
        }
    }
}
