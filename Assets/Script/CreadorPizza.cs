using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreadorPizza : MonoBehaviour
{
  public GameObject[] lugares;
    public GameObject[] Pizza;
    float timer=0;
    public float timerlimit=.5f;
    float limitRandom=0;
    GameObject creado;
    public bool disponible=true;

    // Update is called once per frame
    void Update()
    {
        timer+=Time.deltaTime;

        if(timer>timerlimit+limitRandom){
            if(disponible){
            creado=Instantiate(Pizza[Random.Range(0,Pizza.Length)], lugares[lugar()].transform.position,Quaternion.identity);
            creado.GetComponent<PizzaLanzado>().creador=this;
            disponible=false;
            }
            limitRandom=Random.Range(0f,1f);
            timer=0;
        }
        
    }

    int lugar(){
        return Random.Range(0,lugares.Length);
    }
}
