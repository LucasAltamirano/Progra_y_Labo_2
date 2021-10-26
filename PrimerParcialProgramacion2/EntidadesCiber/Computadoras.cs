using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CibercafeEntidades    
{
    public class Computadoras : Servicio

    {
        public enum EIdentificador
        {
            c01, c02, c03, c04, c05, c06, c07, c08, c09, c10,
        }

        //--------------- Miembro : atributos --------------//
        private EIdentificador identificador;
        private ESoftware software;
        private EPerifericos perifericos;
        private EJuegos juegos;
        private EHardware hardware;
        

        public Computadoras(EtipoServicio tipoServicio ,float duracion,EIdentificador identificador, ESoftware software, EPerifericos perifericos, EJuegos juegos, EHardware hardware ):base(tipoServicio,duracion)
        {
          
            this.identificador = identificador;
            this.software = software;
            this.perifericos = perifericos;
            this.juegos = juegos;
            this.hardware = hardware;
            this.tipoServicio = EtipoServicio.computadoras;

           
        }


        //--------------- Miembro : Propiedades --------------//
        public ESoftware Software { get => software; set => software = value; }
        public EPerifericos Perifericos {  get => perifericos; set => perifericos = value;  }
        public EJuegos Juegos {  get => juegos; set => juegos = value;  }
        public EHardware Hardware {  get => hardware; set => hardware = value; }
        internal EIdentificador Identificador { get => identificador; set => identificador = value; }

        //--------------- Miembro : Contructores --------------//


        public  override float CostoServicio
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


        private float CalcularCosto()
        {
            return this.Duracion * 0.50f;
        }

        private float CostoConIva()
        {
            float valorConIva = this.CalcularCosto();
            valorConIva = valorConIva + (valorConIva * 21 / 100);
            return valorConIva;

        }
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.Mostrar());

            sb.AppendLine("Computadoras: mas detalles del dispositivo\r\n");


            sb.AppendLine($"identificador de Dispositivo{this.Identificador}\r\n" +
               $"Sotfware: {this.Software}\r\n" +
               $"Perifericos: {this.Perifericos} \r\n" +
               $"Juegos: {this.Juegos}\r\n" +
               $"Hardware: {this.Hardware}"+
               $"hora comienzo :{DateTime.Now.ToString("hh: mm:ss")}\r\n"); 
            return sb.ToString();



        }

    }
}
