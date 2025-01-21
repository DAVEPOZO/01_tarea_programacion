using System;

class Punto
{
    // Atributos de la clase
    private double x;
    private double y;

    // Constructor de la clase
    public Punto(double x, double y)
    {
        this.x = x;
        this.y = y;
    }

    // Obtener x
    public double ObtenerX()
    {
        return x;
    }

    // Establecer x
    public void EstablecerX(double x)
    {
        this.x = x;
    }

    // Obtener y
    public double ObtenerY()
    {
        return y;
    }

    // Establecer y
    public void EstablecerY(double y)
    {
        this.y = y;
    }

    // mostrar las coordenadas del punto
    public void MostrarCoordenadas()
    {
        Console.WriteLine($"Coordenadas del punto: ({x}, {y})");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Crear la clase Punto
        Punto punto = new Punto(3.5, 7.2);

        // Mostrar las coordenadas iniciales del punto
        punto.MostrarCoordenadas();

        // Cambiar las coordenadas utilizando los métodos
        punto.EstablecerX(10.0);
        punto.EstablecerY(15.5);

        // Mostrar las nuevas coordenadas
        Console.WriteLine("\nCoordenadas Actualizadas:");
        punto.MostrarCoordenadas();
    }
}