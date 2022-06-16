using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio : MonoBehaviour
{
    //Realizar un programa que muestre los numeros entre dos enteros ingresados por el usuario. Chequear que no sean iguales.
    // Start is called before the first frame update

    public int num1;
    public int num2;
    void Start()
    {
        if (num1 == num2)
        {
            Debug.Log("Los numeros son iguales");
        }
        else
        {
            int i = num1;
            while (num1 < num2)
            {
                Debug.Log(i);
                i++;
            }
            while (num2 < num1)
            {
                Debug.Log(i);
                i++;
            }
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
