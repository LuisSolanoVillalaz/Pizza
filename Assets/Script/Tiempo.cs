using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tiempo : MonoBehaviour
{
    public TMPro.TextMeshProUGUI texto;
    public float maximo;
    float tiempo;
    public GameObject Fail;

    // Update is called once per frame
    void Update()
    {
        tiempo+=Time.deltaTime;
        texto.text=((int)((maximo-tiempo)%61)).ToString();
        if(tiempo>=59){
            Time.timeScale = 0f;
            Fail.SetActive(true);
        }
    }
}
