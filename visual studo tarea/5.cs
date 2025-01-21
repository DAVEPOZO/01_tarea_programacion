using System;

class Program
{
    static void Main(string[] args)
    {
        int i = 1; 
        int suma = 0;

        while (i <= 100) 
        {
            suma += i; 
            i++; 
        }

        Console.WriteLine("La suma de los 100 numeros es: " + suma);
    }
}
