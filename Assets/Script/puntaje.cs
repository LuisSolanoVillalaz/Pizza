using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class puntaje : MonoBehaviour
{
    int puntos=0;
    TMPro.TextMeshProUGUI texto;
    public GameObject Win;
    // Start is called before the first frame update
    void Start()
    {
        texto=GetComponent<TMPro.TextMeshProUGUI>();
    }

   public void cambiarpuntos(int p){
    puntos+=p;
    texto.text=puntos.ToString()+"/10";
    if(puntos>=10){
        Time.timeScale = 0f;
        Win.SetActive(true);
    }
   }
}
