using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PizzaMover : Pizza
{   
    public Vector3 Pposition;
    public float speed;

    public override void comportamiento(){
        transform.position=Vector3.MoveTowards(transform.position,Pposition,speed);
        if(transform.position==Pposition){
            padre.cambiar(1);
        }
    }
}
