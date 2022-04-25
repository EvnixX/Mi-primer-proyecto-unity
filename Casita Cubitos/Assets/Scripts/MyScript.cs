using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyScript : MonoBehaviour
{
    public string mensajeBienvenida;
    public string miNombre;
    public string elNombreamigo;
    public int edad;
    public int edadAmigo;
    public int total;
    public bool estaArriba;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hola, bienvenido al mundo de " + miNombre);
        Debug.Log("Nos llamamos" + miNombre + "y" + elNombreamigo);
        Debug.Log(miNombre + elNombreamigo);

        Debug.Log("Este es el " + mensajeBienvenida);
        Debug.Log("Esta es la suma dee nuestras edades" + total);


        





    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Omjump()
    {

    }



}

// public int a; public float b;  Debug.Log("tengo" + a); Debug.Log("tiene" + b);

