using System;
using CibercafeEntidades;
using System.Collections.Generic;

namespace Cibercafe.Negocios
{
    public class ClienteServicio
    {

            
        public static float CostoServicioPc (Servicio servicio)
        {

            return servicio.Duracion  * 0.50f;
        }

        







    }
}
