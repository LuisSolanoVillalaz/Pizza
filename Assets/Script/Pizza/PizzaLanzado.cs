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
    public AudioClip lanzar;
    float timer=0;
    public CreadorPizza creador;
    bool despawn=false;
    bool canhit=true;
    void Start()
    {
        body=GetComponent<Rigidbody>();
        source=GameObject.Find("Creador de Pizza").GetComponent<AudioSource>();
        if(source)
                source.PlayOneShot(lanzar);
        uipuntos=GameObject.Find("Puntos").GetComponent<puntaje>();

    }
    public override void comportamiento(){
        if(despawn){
            timer+=Time.deltaTime;
            if(timer>=2f){
                Destroy(gameObject);
            }
        }
    }
    private void OnCollisionEnter(Collision other) {
        if(canhit){
            if(source)
                source.Stop();
            if(other.gameObject.name=="Horno"){
                if(source)
                    source.PlayOneShot(score);
                uipuntos.cambiarpuntos(valor);
                creador.disponible=true;
                Destroy(gameObject);
                
            }else if(other.gameObject.name!="Cinta"){
                if(source)
                    source.PlayOneShot(hit);
                despawn=true;
                creador.disponible=true;
                canhit=false;
            }
        }
    }
}
