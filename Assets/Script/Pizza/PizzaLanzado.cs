using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PizzaLanzado : Pizza
{
    
    public int valor=1;
    public puntaje uipuntos;
    Rigidbody body;
    void Start()
    {
        body=GetComponent<Rigidbody>();
    }
    public override void comportamiento(){
        if(ArmInput.GetSignalLeftArm()==Vector2.zero&&ArmInput.GetSignalRightArm()== Vector2.right){  //Solo sube el derecho
            body.velocity =Vector3.zero;
            transform.position= new Vector3(-4.53f,1.35f,6.5f);
            padre.cambiar(0);
        }
    }
    private void OnCollisionEnter(Collision other) {
        if(other.gameObject.name=="Horno"){
            uipuntos.cambiarpuntos(valor);
            body.velocity =Vector3.zero;
            transform.position= new Vector3(-4.53f,1.35f,6.5f);
            padre.cambiar(0);
        }
    }
}
