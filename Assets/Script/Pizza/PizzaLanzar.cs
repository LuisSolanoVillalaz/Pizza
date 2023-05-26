using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PizzaLanzar : Pizza
{   
    public Vector3 direction;
    Rigidbody body;
    void Start()
    {
        body=GetComponent<Rigidbody>();
    }
    public override void comportamiento(){
        if(ArmInput.GetSignalLeftArm()==Vector2.right&&ArmInput.GetSignalRightArm()== Vector2.zero){ 
            body.velocity =direction;
            padre.cambiar(2);
        }
    }
}
