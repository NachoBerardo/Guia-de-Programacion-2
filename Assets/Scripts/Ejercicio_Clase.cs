using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio_Clase : MonoBehaviour
{

    public int num1, num2;

    void Start()
    {
        if (num1 > num2)
        {
            while (num1 >= num2)
            {
                Debug.Log(num2);
                num2++;
            }
        }

        else if (num1 < num2)
        {
            while (num1 <= num2)
            {
                Debug.Log(num1);
                num1++;
            }
        }

        else
        {
            Debug.Log("No pueden ser iguales");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
