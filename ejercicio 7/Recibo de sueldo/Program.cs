using System;
/*
 *Consigna#

Escribir un programa que imprima por consola un triángulo como el siguiente:
El usuario indicará cuál será la altura del triángulo ingresando un número entero positivo.
Para el ejemplo anterior, la altura ingresada fue de 5.
 * 
 */
namespace Recibo_de_sueldo
{
    class Program
    {
        static void Main(string[] args)
        {
            int pisos;
            int pisoActual = 0;
            bool valido = true;
            do
            {
                Console.WriteLine("Ingrese el numero de pisos del triangulo");
                if (int.TryParse(Console.ReadLine(), out pisos))
                {
                     do
                     {
                        for (int i = 0; i < pisos; i++)
                        {
                            Console.Write("#");
                        }
                       

                        pisoActual++;

                     } while (pisoActual!=pisos);
                    
                    valido = true;
                }
                else
                {
                    Console.WriteLine("Error ,ingrese un numero positivo");
                    valido = false;
                }





            } while (valido ==false);
          
                
            
          
           

        }
    }
}
