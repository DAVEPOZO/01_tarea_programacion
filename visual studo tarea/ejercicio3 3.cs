using System;

class Circulo
{
    // Atributos de la clase
    private double x;
    private double y;
    private double radio;

    // Constructor de la clase
    public Circulo(double x, double y, double radio)
    {
        this.x = x;
        this.y = y;
        this.radio = radio;
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

    // Obtener radio
    public double ObtenerRadio()
    {
        return radio;
    }

    // Establecer radio
    public void EstablecerRadio(double radio)
    {
        if (radio > 0)
        {
            this.radio = radio;
        }
        else
        {
            Console.WriteLine("El radio debe ser mayor que 0.");
        }
    }

    // calcular el area del circulo
    public double CalcularArea()
    {
        return Math.PI * Math.Pow(radio, 2);
    }

    // mostrar la informacion del circulo
    public void MostrarInformacion()
    {
        Console.WriteLine($"Coordenadas: ({x}, {y})");
        Console.WriteLine($"Radio: {radio}");
        Console.WriteLine($"area: {CalcularArea():F2}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Crear la clase Circulo
        Circulo circulo = new Circulo(5.0, 7.0, 10.0);

        // Mostrar la informacion inicial
        circulo.MostrarInformacion();

        // Cambiar las coordenadas y el radio 
        circulo.EstablecerX(8.0);
        circulo.EstablecerY(12.0);
        circulo.EstablecerRadio(15.0);

        // Mostrar la nueva informacion
        Console.WriteLine("\nDespues de actualizar:");
        circulo.MostrarInformacion();
    }
}
