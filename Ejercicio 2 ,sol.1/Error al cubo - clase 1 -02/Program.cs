using System;

namespace valor_al_Cuadrado_Cubo
{
    class Program
    {
        static void Main(string[] args)
        {
            int flag = 0;

            // dato que levanto y devuelve en string

            double number;
            do
            {
               
                Console.WriteLine("Ingrese un numero mayor que cero ");
                if (double.TryParse(Console.ReadLine(), out number))
                {
                    if (number > 0)
                    {

                        Console.WriteLine("NUMERO   INGRESADO {0}", number);
                        double result2=Math.Pow(number,2);
                        double result3 = Math.Pow(number, 3);
                        //int resultado = (int)result;
                        Console.WriteLine("El valor al cuadrado  es:{0}",result2);
                        Console.WriteLine("El valor al cubo es:{0}", result3);
                        flag = 1;
                    }
                    else
                    {
                        Console.WriteLine("Error debe ingresar un valor mayor a cero ");
                        flag = -1;
                    }
                }
                else
                {
                    Console.WriteLine("Error  ingresar un valor valido ");
                    flag = -1;
                }
            } while (flag < 0);


        }
    }

    

}
