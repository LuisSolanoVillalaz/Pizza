using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PizzaManager : MonoBehaviour
{

    public List<Pizza> scripts;

    Pizza Activo;
    // Start is called before the first frame update
    void Start()
    {
        Activo=scripts[0];
        Activo.padre=this;
        Activo.enabled=true;
    }

    // Update is called once per frame
    void Update()
    {
        Activo.comportamiento();
    }

    public void cambiar(int nuevo){
        if(nuevo<scripts.Count){
            Activo.enabled=false;
            Activo=scripts[nuevo];
            Activo.padre=this;
            Activo.enabled=true;
        }
    }
   
}
