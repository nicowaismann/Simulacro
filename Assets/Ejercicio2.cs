using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2 : MonoBehaviour
{
    public float precio1;
    public float precio2;
    public float precio3;
    public float capitalDisponible;
    float precioTotal;
    float capitalSobrante;
    float capitalFaltante;

    // Start is called before the first frame update
    void Start()
    {
        
        precioTotal = precio1 + precio2 + precio3;
        capitalSobrante = capitalDisponible - precioTotal;
        capitalFaltante = (capitalDisponible - precioTotal) * (-1); 

        if (precioTotal > capitalDisponible)
        {
            Debug.Log("El precio supera al capital disponible y te faltan " + capitalFaltante);
        }

        else
        {
            Debug.Log("El precio no supera al capital disponible y te sobran " + capitalSobrante);
        }



    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
