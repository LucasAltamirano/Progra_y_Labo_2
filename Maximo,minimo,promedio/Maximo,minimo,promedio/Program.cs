using System;

namespace Maximo_minimo_promedio
{
    /*
     * Ingresar 5 números por consola, guardándolos en una variable escalar.
     * Luego calcular y mostrar: el valor máximo, el valor mínimo y el promedio.
         Información
        Un escalar es una constante o variable que contiene un dato atómico y
        unidimensional. En contraposición al concepto de escalar, 
        están los conceptos de array, lista y objeto, que pueden tener 
        almacenado en su estructura más de un valor.​ Ver en Wikipedia 
     */

    class Program
    {
        public static object Int { get; private set; }

        static void Main(string[] args)
        {
            int i, numero;
            int mayor =0;
            int menor = 0;
            int sumador = 0;
            double promedio = 0;
            for (i = 0; i < 5; i++)
            {
                Console.WriteLine("Ingrese un numero ");
                int.TryParse(Console.ReadLine(), out numero);
               if (i==0)
                {
                    mayor = numero;
                    menor = numero;
                }
                if (numero < menor)
                {
                    menor = numero;
                }
                else
                {
                    if(numero > mayor)
                    {
                        mayor = numero;
                    }
                }
                sumador = sumador + numero;
            }
            promedio = ((double)sumador / 5);

            Console.WriteLine("El numero mayor es:{0}", mayor);
            Console.WriteLine("El numero menor es:{0}", menor);
            Console.WriteLine("El promedio es :{0}", promedio);
            Console.ReadKey();
            
        }
    }
}
