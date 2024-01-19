using ConceptosPOO;

internal class Program
{
    private static void Main(string[] args)
    {
        var persona1 = new Persona() 
        {
            Nombre = "Ricardo",
            Apellido = "Elizalde"
        };

        var persona2 = new Persona();

        Console.Clear();
        
        Console.WriteLine(persona1.Nombre);
        Console.WriteLine(persona1.Apellido);

        Console.ReadKey();

        int pasos = 7;
        persona1.Caminar(ref pasos);
        Console.WriteLine($"Valor de pasos en principal {pasos}");

        

        // persona1.Nombre = "Juan";
        // persona1.Apellido = "Perez";
        
        // Console.WriteLine(persona1.Nombre);
        // Console.WriteLine(persona1.Apellido);
        // Console.WriteLine(persona2.Nombre);
        // Console.WriteLine(persona2.Apellido);
        //Console.WriteLine($"Escriba el Salario Mensual de {persona1.Nombre} {persona1.Apellido} :");


        // persona1.SalarioMensual = Convert.ToDecimal(Console.ReadLine());
        // Console.WriteLine();
        
        // Console.Write($"El Salario Anual de: {persona1.Nombre} {persona1.Apellido} es: {persona1.SalarioAnual}");
        // Console.WriteLine();
        // persona1.FechaDeNacimiento = new DateTime(1979, 7, 22);

        // persona1.Caminar(7);
    }
}

