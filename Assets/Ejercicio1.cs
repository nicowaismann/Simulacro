using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio1 : MonoBehaviour
{

    public int primerValor;
    public int segundoValor;

    // Start is called before the first frame update
    void Start()
    {
        if (primerValor == segundoValor)
        {
            Debug.Log("Son iguales");
        }

        else
        {
            Debug.Log("No son iguales");
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
