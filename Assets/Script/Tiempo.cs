using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tiempo : MonoBehaviour
{
    public TMPro.TextMeshProUGUI texto;
    public float maximo;
    float tiempo;

    // Update is called once per frame
    void Update()
    {
        tiempo+=Time.deltaTime;
        texto.text=((int)((maximo-tiempo)/60)).ToString()+":"+((int)((maximo-tiempo)%60)).ToString();
    }
}
