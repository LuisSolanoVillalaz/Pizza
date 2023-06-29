using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PizzaLanzar : Pizza
{   
    public Vector3 direction;
    Rigidbody body;
    float timerR=0;
    float timerL=0;
    float timerLimit=0.1f;
    void Start()
    {
        body=GetComponent<Rigidbody>();
    }
    public override void comportamiento(){
        if(ArmInput.GetSignalLeftArm()==Vector2.right){ 
           timerR+=Time.deltaTime;
        }else{
            timerR=0;
        }

        if(ArmInput.GetSignalRightArm()== Vector2.right){
            timerL+=Time.deltaTime;
        }else{
            timerL=0;
        }

        if(timerR>=timerLimit&&!(timerL>=timerLimit)){
            body.velocity =direction;
            padre.cambiar(2);
        }
        
    }
}
