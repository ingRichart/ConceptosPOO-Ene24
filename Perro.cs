using System.Drawing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConceptosPOO
{
    public enum TipoPerro
    {
        Chica = 1,
        Mediano = 2,
        Grande = 3
    }

    public enum Genero 
    {
        Macho = 1,
        Hembra = 2
    }

    public class Perro
    {
        public TipoPerro Tamano { get; set; }

        public Color ColorPerro { get; set; }

        public Genero GeneroPerro { get; set; }

        public string Raza { get; set; }

        public int Edad { get; set; }

        public void Ladrar() 
        {
            Console.WriteLine("El perro esta ladrando");
        }

        public void Ladrar(bool? fuerte) 
        {
            if (fuerte.HasValue && fuerte.Value) 
            {
                Console.WriteLine("El perro esta ladrando fuerte");
            }
            else if (fuerte.HasValue && !fuerte.Value)
            {
                Console.WriteLine("El perro esta ladrando debil");
            }
            else 
            {
                Console.WriteLine("El perro esta callado");
            }
        }


        public void Morder()
        {
            Console.WriteLine("El perro esta mordiendo");
        }
        public void Morder(int? Cantidad)
        {
            if (Cantidad.HasValue && Cantidad.Value > 0) 
            {
                Console.WriteLine($"El perro esta mordiendo a {Cantidad.Value} personas");
            }
            else if (Cantidad.HasValue && Cantidad.Value == 0)
            {
                Console.WriteLine($"El perro esta mordiendo");
            }
            else {
                Console.WriteLine($"El perro no mordio");
            }
        }
    }
}