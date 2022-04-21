using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class While01 : MonoBehaviour
{
    //Realizar un programa que muestre los numeros del 1 al 100 utilizando la instrucción while
    int counter = 1;
    int counterMax = 100;
    // Start is called before the first frame update
    void Start()
    {
        while (counter <= counterMax)
        {
            Debug.Log(counter);
            counter++;
        }
        Debug.Log("Terminó el while");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
