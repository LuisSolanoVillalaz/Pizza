using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class CreadorBasura : MonoBehaviour
{
    public GameObject[] lugares;
    public GameObject[] Basuras;
    float timer=0;
    public float timerlimit=.5f;
    float limitRandom=0;
    GameObject creado;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer+=Time.deltaTime;

        if(timer>timerlimit+limitRandom){
            if(!creado){
            creado=Instantiate(Basuras[Random.Range(0,Basuras.Length)], lugares[lugar()].transform.position,Quaternion.identity);
            }
            limitRandom=Random.Range(0f,1f);
            timer=0;
        }
        
    }

    int lugar(){
        return Random.Range(0,lugares.Length);
        switch(Random.Range(0,100)){   
        }
    }
}
