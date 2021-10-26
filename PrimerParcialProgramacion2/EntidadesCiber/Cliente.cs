using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CibercafeEntidades
{
        public class Cliente
    {
        //--------------- Miembro : Atributos --------------//
        // Todos los atributos ,a excepcion de los Enumerados seran private,Encapsulamiento

        private List<Cliente> listaClientes;
        private uint dni;
        private string nombre;
        private string apellido;
        private sbyte edad;
        private EJuegos juegos;
        

        
        //--------------- Miembro : Propiedades --------------//
        public uint Dni 
        {
            get
            {
                return dni;
            }
            set
            {
                this.dni = value;
            }

        }
        public string Nombre 
        {
            get 
            {
                return nombre;
            }
            set 
            {
                nombre = value;
            }
        }
        public string Apellido 
        { get 
            {
                return apellido;
            }
            set
            {
                apellido = value;
            }
        }
       /* public sbyte Edad
        {
            get 
            {
                return edad;
            }
            set 
            {
                edad = value;
            }                                                               
        }
       */
        public List<Cliente> ListaDeClientes
        {
            get 
            {
                return this.listaClientes;
            }
            set 
            {                                                           
                listaClientes = value;
            }
        }

        public sbyte Edad { get => edad; set => edad = value; }
        public EJuegos Juegos { get => juegos; set => juegos = value; }

        //--------------- Miembro : Constructor --------------//
        // con sobrecargas: lo cual  generará mayor flexibilidad a nuestro codigo
        public Cliente()
        {
            this.dni = 0;
            this.nombre = "none ";
            this.apellido = "none";
            this.Edad = 0;

            listaClientes = new List<Cliente>();
        }


        public Cliente(uint dni, string nombre, string apellido, sbyte edad,EJuegos juegos):this()
        {
            this.dni = dni;
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
            this.Juegos = juegos;

        }


          public string MuestroCLientes()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre :{this.Nombre} Apellido: { this.Apellido} Documento:{this.Dni} Edad:{this.Edad}");
            return sb.ToString();

        }

        private void AgregarClientes(Cliente nuevoCliente)
        {
            ListaDeClientes.Add(nuevoCliente);
        }

       

        //* End

    }
}
