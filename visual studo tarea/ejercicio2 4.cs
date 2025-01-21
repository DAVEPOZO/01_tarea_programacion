using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese un numero del 1 al 7:");

        // Leer la entrada del usuario
        string entradaUsuario = Console.ReadLine();

        // Validar que la entrada sea un numero entero
        if (int.TryParse(entradaUsuario, out int numero))
        {
            // Verificar si el numero está dentro del rango valido
            switch (numero)
            {
                case 1:
                    Console.WriteLine("Lunes");
                    break;
                case 2:
                    Console.WriteLine("Martes");
                    break;
                case 3:
                    Console.WriteLine("Miercoles");
                    break;
                case 4:
                    Console.WriteLine("Jueves");
                    break;
                case 5:
                    Console.WriteLine("Viernes");
                    break;
                case 6:
                    Console.WriteLine("Sabado");
                    break;
                case 7:
                    Console.WriteLine("Domingo");
                    break;
                default:
                    Console.WriteLine("El numero debe estar entre 1 y 7.");
                    break;
            }
        }
        else
        {
            Console.WriteLine("La entrada no es valida.");
        }
    }
}
