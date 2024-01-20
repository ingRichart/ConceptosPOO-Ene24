using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConceptosPOO
{
    public class Persona
    {
        /// <summary>
        /// Constructor de la clase
        /// </summary>
        public Persona()
        {
            Console.WriteLine($"--------------------------------");
            Console.WriteLine($"Esto es el constructor de persona");
            Console.WriteLine($"--------------------------------");

            Telefonos = new List<string>();
            // FechaDeNacimiento = new DateTime();
            // Nombre = "Escribe el nombre del objeto";
        }

        //PROPIEDADES
        /// <summary>
        /// Esto es el nombre
        /// </summary>
        public string Nombre { get; set; }
        /// <summary>
        /// Esta es la fecha de nacimiento
        /// </summary>
        public DateTime FechaDeNacimiento { get; set; }
        public string Direccion { get; set; }
        public string Apellido { get; set; }
        /// <summary>
        /// El salario mensual
        /// </summary>
        public decimal SalarioMensual { get; set; }
        /// <summary>
        /// El salario anual (Salario Mensual multipolicado por 12)
        /// </summary>
        public decimal SalarioAnual 
        {   
            get { return SalarioMensual * 12; } 
        }

        //CAMPOS
        private int distancia;

        // METODOS 
        public void Caminar(ref int pasos)
        {
            Console.WriteLine($"{Nombre} está caminando");
            distancia += pasos;

            pasos++;
            Console.WriteLine($"Valor de pasos en la funcion Caminar {pasos}");
        }

        public List<string> Telefonos { get; set; }

    }
}