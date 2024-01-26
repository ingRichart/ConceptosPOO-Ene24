using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConceptosPOO
{
    public interface ITipoPerro
    {
        
        void Dormir();

        void Morder(int? valor);

        void Morder();

        void Ladrar(bool? fuerte);

        void Ladrar();

        // void Jugar();

        // void Lamer();

        // void Olfatear();
    }
}