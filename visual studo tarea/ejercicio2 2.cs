using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese su calificacion (0-100):");

        // Leer la entrada del usuario
        string entradaUsuario = Console.ReadLine();

        // Validar que la entrada sea un número entero
        if (int.TryParse(entradaUsuario, out int calificacion))
        {
            // Verificar el rango válido
            if (calificacion >= 0 && calificacion <= 100)
            {
                // Determinar si esta aprobado o reprobado
                if (calificacion >= 60)
                {
                    Console.WriteLine("Aprobado");
                }
                else
                {
                    Console.WriteLine("Reprobado");
                }
            }
            else
            {
                Console.WriteLine("La calificacion ingresada debe estar entre 0 y 100.");
            }
        }
        else
        {
            Console.WriteLine("La entrada no valida. Ingrese un numero entero.");
        }
    }
}