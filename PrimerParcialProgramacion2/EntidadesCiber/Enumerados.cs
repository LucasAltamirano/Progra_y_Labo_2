using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CibercafeEntidades
{

    public enum EIdentificador
    {

        C01, C02, C03, C04, C05, C06, C07, C08, C09, C10,T01,T02,T03,T04,T05,

    }

    public enum  ESoftware
       
    {   
        office,
        messenger,
        icq, 
        ares,
    }
    public enum  EPerifericos
    {
        cámara,
        auriculares, 
        micrófono,
        tecladoMouse,
    }

    public enum EJuegos
    {

        CounterStrike,
        DiabloII, 
        MuOnline,
        LineageII,
        WarcraftIII,
        AgeofEmpiresII,
    }

    public enum EHardware
    {
        procesador,
        ram, 
        placavideo,
        
    }
    public enum EMarcaTelefono
    { 
        motorola,
        samsumg,
        huawei,
    }

    public enum ETipoTelefono
    {
        disco,
        teclado,
    }
}
