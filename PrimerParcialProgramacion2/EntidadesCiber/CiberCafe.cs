using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CibercafeEntidades
{
    public class CiberCafe

    {
        
        public enum ETipo
        {
            Cabinas,Computadoras, Todos
        }
        //----------------Miembro : Atributos-----------//
        private List<Servicio> servicios;
        private int lugarDisponible;
        private int cabDisponibles;
        private int compDisponibles;
        //----------------Miembro : Propiedades-----------//

        public int LugarDisponible
        {

            get
            {
                return this.lugarDisponible;
            }
            set
            {
                if (lugarDisponible > 0)
                {
                    this.lugarDisponible = value;
                }
            }

        }

        public List<Servicio> ListaDeServicio
        {
            get
            {
                return servicios;
            }

        }

        //----------------Miembro : Constructores-----------//
        private CiberCafe()
        {
            this.servicios = new List<Servicio>();

        }
        public CiberCafe(int lugarDisponible) : this()
        {

            this.lugarDisponible = lugarDisponible;
        }


        //----------------Miembro : Metodos -----------//
        

        public override string ToString()
        {
            return Listar(this, ETipo.Todos);
        }


        public static string Listar(CiberCafe ciber, ETipo tipo)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("-----------------CIBERCAFE----------------------");
            sb.AppendFormat("Tenemos {0} dispositivos ocupados de un total de {1} disponibles", ciber.ListaDeServicio.Count, ciber.LugarDisponible);
            sb.AppendLine("---------------------------------------");


            foreach (Servicio s in ciber.ListaDeServicio)
            {
                switch (tipo)
                {
                    case ETipo.Cabinas:
                        sb.AppendLine(s.Mostrar());
                        break;
                    case ETipo:
                        sb.AppendLine(s.Mostrar());
                        break;             
                    default:
                        sb.AppendLine(s.Mostrar());
                        break;
                }
            }

            return sb.ToString();
        }
        //----------------Miembro : Sobrecarga de operadores -----------//


        public static CiberCafe operator +(CiberCafe ciberCafe, Servicio servicio)
        {
            if (ciberCafe.ListaDeServicio.Count < ciberCafe.lugarDisponible)
            {
                foreach (Servicio v in ciberCafe.ListaDeServicio)
                {
                    if (v == servicio)


                        return ciberCafe;
                }
                ciberCafe.ListaDeServicio.Add(servicio);
            }
            return ciberCafe;
        }

        public static CiberCafe operator -(CiberCafe ciberCafe, Servicio servicio)
        {
            foreach (Servicio s in ciberCafe.ListaDeServicio)
            {
                if (s == servicio)
                {
                    ciberCafe.ListaDeServicio.Remove(s);
                    DateTime stop = new DateTime();
                    break;
                }
            }

            return ciberCafe;
        }






    }
}
