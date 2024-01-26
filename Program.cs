using System.Drawing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ConceptosPOO;


internal class Program
{
    private static void Main(string[] args)
    {
        // string descipcion = "Hola";
        // int variableTamano = new int();
        Perro miMascota = new Perro();
        miMascota.Ladrar();
        miMascota.Ladrar(false);

        miMascota.Morder(10);

    }
}

