using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pistola : MonoBehaviour
{
    public int da�o = 10;
    public float cadenciaDeDisparo = 0.5f;
    public int munici�n = 30;
    public Transform puntoDeDisparo; 
    public GameObject balaP; 
    private float tiempoSiguienteDisparo = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1") && Time.time > tiempoSiguienteDisparo)
        {
            Disparar();
            tiempoSiguienteDisparo = Time.time + cadenciaDeDisparo;
        }
    }
    void Disparar()
    {
        if (munici�n > 0)
        {
            // Crea una instancia de la bala en el punto de disparo
            Instantiate(balaP, puntoDeDisparo.position, puntoDeDisparo.rotation);
            munici�n--; // Reduce la munici�n
        }
    }
}
