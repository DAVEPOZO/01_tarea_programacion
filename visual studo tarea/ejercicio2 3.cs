using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese un numero:");

        // Leer la entrada del usuario
        string entradaUsuario = Console.ReadLine();

        // Validar que la entrada sea valida
        if (int.TryParse(entradaUsuario, out int numero))
        {
            // Determinar el rango del numero
            if (numero < 10)
            {
                Console.WriteLine("El numero es menor que 10.");
            }
            else if (numero >= 10 && numero <= 20)
            {
                Console.WriteLine("El numero está entre 10 y 20.");
            }
            else
            {
                Console.WriteLine("El numero es mayor que 20.");
            }
        }
        else
        {
            Console.WriteLine("Ingrese un numero entero.");
        }
    }
}