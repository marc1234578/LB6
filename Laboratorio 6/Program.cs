using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Ingrese un número máximo de personas:");
        int maxPersonas = int.Parse(Console.ReadLine());

        int asistentesActuales = 0;
        int historialIngresos = 0;
        int historialSalidas = 0;
        int vecesSeLleno = 0;
        int vecesVacio = 0;

        Console.Clear();

        while (true)
        {
            Console.WriteLine($"Asistentes actuales:" + asistentesActuales);
            Console.WriteLine($"Aforo: %" + (asistentesActuales * 100.0) / maxPersonas);
            Console.WriteLine($"Máximo personas: "  + maxPersonas );
            Console.WriteLine("\nPresione: ");
            Console.WriteLine("[ i ] si ingresa una persona");
            Console.WriteLine("[ s ] si sale una persona");
            Console.WriteLine("[ x ] para terminar");

            char opcion = Console.ReadKey().KeyChar;

            Console.Clear();

            switch (opcion)
            {
                case 'i':
                case 'I':
                    if (asistentesActuales < maxPersonas)
                    {
                        asistentesActuales++;
                        historialIngresos++;
                    }
                    else
                    {
                        vecesSeLleno++;
                    }
                    break;

                case 's':
                case 'S':
                    if (asistentesActuales > 0)
                    {
                        asistentesActuales--;
                        historialSalidas++;
                    }
                    else
                    {
                        vecesVacio++;
                    }
                    break;

                case 'x':
                case 'X':
                    Console.Clear();
                    Console.WriteLine("El programa ha terminado");
                    Console.WriteLine("Estadísticas:");
                    Console.WriteLine("----------------------------------");
                    Console.WriteLine($"{historialIngresos} personas ingresaron");
                    Console.WriteLine($"{historialSalidas} personas salieron");
                    Console.WriteLine($"{vecesSeLleno} veces se llenó el local");
                    Console.WriteLine($"Estuvo vacío {vecesVacio} veces");
                    return;
            }
        }
    }
}
