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
        //var miMascota = DeterminarPerro(TipoPerro.Mediano);

        var miMascota = new PerroGrande();
        miMascota.FechaDeNacimiento = new DateTime(2000, 7, 22);
        miMascota.Tamano = TipoPerro.Grande;

        Console.WriteLine(miMascota.Edad);

        miMascota.Ladrar();
        miMascota.Ladrar(false);

        miMascota.Morder(10);


    }

    public static ITipoPerro DeterminarPerro(TipoPerro tipo)
    {
        switch (tipo)
        {
            case TipoPerro.Chica :
                return new PerroChico();

            case TipoPerro.Mediano :
                return new PerroMediano();

            case TipoPerro.Grande :
                return new PerroGrande();

            default :
                throw new NotImplementedException();
        }
    }
}

