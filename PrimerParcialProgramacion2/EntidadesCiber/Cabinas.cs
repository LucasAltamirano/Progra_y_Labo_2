using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CibercafeEntidades
{
    public class Cabinas : Servicio
    {
        public enum EIdentificador 
        {
            t01, t02, t03, t04, t05,Todas,
        }
        public enum Edistancia
        {
            Local, LargaDistancia , Internacional,Todas,
        }
        //--------------- Miembro : Atributos --------------//
        // Todos los atributos ,a excepcion de los Enumerados seran private,Encapsulamiento
        private EIdentificador identificador;
        private ETipoTelefono tipoTelefono;
        private EMarcaTelefono marcaTelefono;
        private Edistancia distancia;

        //--------------- Miembro : Propiedades --------------//
        // Metodo seguro que nos permite acceder a los atributos manteniendo el principio de encapsulamiento

        /// <summary>
        /// Se renovaron los equipos del local
        /// El valor por defecto sera tipo: teclado
        /// </summary>
        public ETipoTelefono TipoTelefono
        {
            get
            {
                return ETipoTelefono.teclado;
            }
        }
        public EIdentificador Identificador { get => identificador; set => identificador = value; }
        public EMarcaTelefono MarcaTelefono { get => marcaTelefono; set => marcaTelefono = value; }
        public Edistancia Distancia { get => distancia; set => distancia = value; }



        //--------------- Miembro : Constructores --------------//
        // Sobrecarga de constructores: nos da mayor flexibilidad a nuestro codigo
       
        public Cabinas(EtipoServicio tipoServicio,float duracion ,EIdentificador identificador, 
            ETipoTelefono tipoTelefono, EMarcaTelefono marcaTelefono, Edistancia distancia)
            :base(tipoServicio,duracion )
        {
            this.identificador = identificador;
            this.tipoTelefono = tipoTelefono;
            this.marcaTelefono = marcaTelefono;
            this.distancia = distancia;
            this.tipoServicio = EtipoServicio.cabinas;
        }


        //--------------- Miembro : Metodos --------------//

        public override float CostoServicio
        {
            get
            {
                return this.CalcularCosto();
            }
        }


        public override float CostoServicioConIva
        {
            get
            {
                return this.CostoConIva();
            }
        }


        public static explicit operator float(Cabinas v)
        {
            throw new NotImplementedException();
        }

        private  float CostoConIva()
        {
            float costo = CalcularCosto();
            return  (costo + (costo* 21 / 100));
        }


        private float CalcularCosto()
        {
           float value= 0;
            if (this.Distancia == Edistancia.Local)
            {value = this.Duracion * 1.00f;}

            else if(this.Distancia==Edistancia.LargaDistancia)
            { value = this.Duracion * 2.50f; }

            else 
            { value = this.Duracion * 5.00f; }

            return value;
        }

        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.Mostrar());

            sb.AppendLine("Cabina Telefonica : Detalles de dispositivo\r\n");
            sb.AppendLine( $"Identificador de Dispositivo : [{this.Identificador}]\r\n" +
                $"Tipo telefono: {this.TipoTelefono}\r\n" +
                $"Marca Telefono: {this.MarcaTelefono}\r\n" +
                $"Distancia llamada: {this.Distancia}\r\n");
            return sb.ToString();
           

        }
    }

       

        //end
    
}
