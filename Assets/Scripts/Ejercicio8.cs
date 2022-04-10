using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio8 : MonoBehaviour
{
    public int diaSemana;
    void Start()
    {
        if (diaSemana > 7)
        {
            Debug.Log(" El día ingresado no es válido");
        }
        else if (diaSemana <= 0)
        {
            Debug.Log(" El día ingresado no es válido");
        }
       else if (diaSemana == 1)
        {
            Debug.Log("El día ingresasdo corresponde al lunes");
        }
        else if (diaSemana == 2)
        {
            Debug.Log("El día ingresasdo corresponde al martes");
        }
        else if (diaSemana == 3)
        {
            Debug.Log("El día ingresasdo corresponde al miercoles");
        }
        else if (diaSemana == 4)
        {
            Debug.Log("El día ingresasdo corresponde al jueves");
        }
        else if (diaSemana == 5)
        {
            Debug.Log("El día ingresasdo corresponde al viernes");
        }
        else if (diaSemana == 6)
        {
            Debug.Log("El día ingresasdo corresponde al sabado");
        }
        else if (diaSemana == 7)
        {
            Debug.Log("El día ingresasdo corresponde al domingo");
        }
    }

   
}
