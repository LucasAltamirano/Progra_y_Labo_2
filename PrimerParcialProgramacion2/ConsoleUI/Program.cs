using System;
using System.Collections.Generic;
using CibercafeEntidades;


namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            
            CiberCafe myCiberCafe = new CiberCafe(15);


            Cabinas cab1 = new Cabinas(Servicio.EtipoServicio.cabinas,0.50f, Cabinas.EIdentificador.t02, ETipoTelefono.teclado, EMarcaTelefono.huawei, Cabinas.Edistancia.Local);
            Cabinas cab2 = new Cabinas(Servicio.EtipoServicio.cabinas,0.50f,Cabinas.EIdentificador.t02,ETipoTelefono.teclado,EMarcaTelefono.huawei,Cabinas.Edistancia.Internacional);
            Computadoras comp1 = new Computadoras(Servicio.EtipoServicio.computadoras,1.00f,Computadoras.EIdentificador.c01,ESoftware.office,EPerifericos.tecladoMouse,EJuegos.CounterStrike,EHardware.placavideo);
            Computadoras comp2 = new Computadoras(Servicio.EtipoServicio.computadoras, 5.00f, Computadoras.EIdentificador.c05, ESoftware.office, EPerifericos.tecladoMouse, EJuegos.DiabloII, EHardware.procesador);


            myCiberCafe += cab1;
            myCiberCafe += cab2;
            myCiberCafe += comp1;
            myCiberCafe += comp2;


            Console.WriteLine(myCiberCafe.ToString());

            myCiberCafe -= cab2;

            Console.WriteLine(myCiberCafe.ToString());
            List<Cliente> listaClientes = new List<Cliente>();

            Cliente cliente1 = new Cliente(37023165, "lucas", "alta", 28, EJuegos.DiabloII);
            listaClientes.Add(cliente1);
            Cliente cliente2 = new Cliente(12246, "pedro ", "mujica", 25, EJuegos.AgeofEmpiresII);
            listaClientes.Add(cliente2);
            Cliente cliente3 = new Cliente(12246, "jose ", "mujica", 25,EJuegos.CounterStrike);
            listaClientes.Add(cliente3);


            foreach (var item in listaClientes)
            {
                Console.WriteLine($"{item.Juegos}");
            }
            
            /*
            Console.WriteLine("funciona");
            foreach (Servicio se in myCiberCafe.ListaDeServicio )
            {

                Console.WriteLine($" tipo {cab1.TipoTelefono} marcaTelfono{cab1.MarcaTelefono} distancia{cab1.Distancia}");
                Console.WriteLine($" tipo {cab2.TipoTelefono} marcaTelfono{cab2.MarcaTelefono} distancia{cab2.Distancia}");
                Console.WriteLine($" tipo {cab3.TipoTelefono} marcaTelfono{cab3.MarcaTelefono} distancia{cab3.Distancia}");

                //Console.WriteLine($"Dni :{c.Dni} Nombre :{c.Nombre} Apellido : {c.Apellido} Edad: {c.Edad} ");
            }
            */
            Console.Read();
        
        }
    }
}
