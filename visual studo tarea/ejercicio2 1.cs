using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese un nmero para evaluar si es positivo, negativo o cero:");

        // Variable para la entrada del usuario
        string entradaUsuario = Console.ReadLine();

        // Validamos que la entrada sea un número válido
        if (double.TryParse(entradaUsuario, out double numero))
        {
            // Evaluamos si el número es positivo, negativo o cero
            if (numero > 0)
            {
                Console.WriteLine("El numero ingresado es positivo.");
            }
            // Evaluamos si el número es negativo
            else if (numero < 0)
            {
                Console.WriteLine("El numero ingresado es negativo.");
            }
            // Evaluamos si el número es  cero
            else
            {
                Console.WriteLine("El numero ingresado es cero.");
            }
        }
        else
        {
            // Mensaje de error si la entrada no es válida
            Console.WriteLine("La entrada no es un numero ");
        }
    }
}
