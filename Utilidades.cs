using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConceptosPOO
{
    public static class Utilidades
    {
        public static int CalcularEdad(DateTime fechaNac, TipoPerro tipo) 
        {
            var edad = DateTime.Today.Year - fechaNac.Year;
            var temp = new DateTime( 
                DateTime.Today.Year, fechaNac.Month, fechaNac.Day);

            if (temp > DateTime.Today) {
                edad--;
            }
            
            return edad * (tipo == TipoPerro.Chica ? 3 
                        : tipo == TipoPerro.Mediano ? 5 
                        : 7);

        }
    }
}