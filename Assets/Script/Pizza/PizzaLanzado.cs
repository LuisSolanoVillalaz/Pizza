using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PizzaLanzado : Pizza
{
    public int valor=1;
    public puntaje uipuntos;
    Rigidbody body;
    AudioSource source;
    public AudioClip score;
    public AudioClip hit;
    void Start()
    {
        body=GetComponent<Rigidbody>();
        source=GetComponent<AudioSource>();
        source.PlayDelayed(0f);

    }
    public override void comportamiento(){
        if(ArmInput.GetSignalLeftArm()==Vector2.zero&&ArmInput.GetSignalRightArm()== Vector2.right){  //Solo sube el derecho
            body.velocity =Vector3.zero;
            transform.position= new Vector3(-4.53f,1.35f,6.5f);
            padre.cambiar(0);
        }
    }
    private void OnCollisionEnter(Collision other) {
        if(source)
            source.Stop();
        if(other.gameObject.name=="Horno"){
            if(source)
                source.PlayOneShot(score);
            uipuntos.cambiarpuntos(valor);
            body.velocity =Vector3.zero;
            transform.position= new Vector3(-4.53f,1.35f,6.5f);
            padre.cambiar(0);
        }else if(other.gameObject.name!="Cinta"){
            if(source)
                source.PlayOneShot(hit);
        }
    }
}
