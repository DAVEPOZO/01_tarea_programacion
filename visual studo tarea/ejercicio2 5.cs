using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese el primer numero:");
        string entradaNumero1 = Console.ReadLine();

        Console.WriteLine("Ingrese el segundo numero:");
        string entradaNumero2 = Console.ReadLine();

        Console.WriteLine("Ingrese la operacion (+, -, *, /):");
        string entradaOperacion = Console.ReadLine();

        // Validar los datos ingresados
        if (double.TryParse(entradaNumero1, out double numero1) && double.TryParse(entradaNumero2, out double numero2))
        {
            // Realizar la operación 
            switch (entradaOperacion)
            {
                case "+":
                    Console.WriteLine("Resultado: " + (numero1 + numero2));
                    break;
                case "-":
                    Console.WriteLine("Resultado: " + (numero1 - numero2));
                    break;
                case "*":
                    Console.WriteLine("Resultado: " + (numero1 * numero2));
                    break;
                case "/":
                    // Validar división por cero
                    if (numero2 != 0)
                    {
                        Console.WriteLine("Resultado: " + (numero1 / numero2));
                    }
                    else
                    {
                        Console.WriteLine("Error: No se puede dividir por cero.");
                    }
                    break;
                default:
                    Console.WriteLine("Operacion no valida. Use +, -, *, o /.");
                    break;
            }
        }
        else
        {
            Console.WriteLine("Uno o ambos numeros no son validos.");
        }
    }
}