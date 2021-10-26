using System.Text;

namespace CibercafeEntidades
{
    public   class Servicio
    {

        //--------------- Miembro : Atributos --------------//
        // Todos los atributos ,a excepcion de los Enumerados seran private,Encapsulamiento
      

        public enum EtipoServicio { cabinas,computadoras}

        protected EtipoServicio tipoServicio;
        protected float duracion;


        //--------------- Miembro : Propiedades --------------//

        protected EtipoServicio TipoServicio 
        {get 
            {
                return tipoServicio;
            }
        }
        public float Duracion 
        {get 
            {
                return duracion;
            }
        }

        //--------------- Miembro : Constructor --------------//
        protected Servicio(EtipoServicio tipoServicio, float duracion)
        {
            this.tipoServicio = tipoServicio;
            this.duracion = duracion;
        }

        //--------------- Miembro : Metodos --------------//
        public virtual string Mostrar()
        {
            return ((string)this);
        }

        public  virtual float CostoServicio { get; }

        public virtual float CostoServicioConIva { get; }



        public static explicit operator string(Servicio servicio)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("---------------------");
            sb.AppendLine("Clase : Servicio");
            sb.AppendLine($"Tipo de Servicio: {servicio.TipoServicio}\r\n");
            sb.AppendLine($"Duracion : {servicio.Duracion}\r\n");
            sb.AppendLine($"Costo s/iva:$ {servicio.CostoServicio} //  Costo c/iva incluido: ${servicio.CostoServicioConIva}\r\n");
            sb.AppendLine("---------------------");

            return sb.ToString();
        }


        //end
    }
}
