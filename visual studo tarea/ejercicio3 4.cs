using System;

class Persona
{
    // Atributos de la clase
    private string nombre;
    private string apellido;
    private int edad;
    private string genero;

    // Constructor de la clase
    public Persona(string nombre, string apellido, int edad, string genero)
    {
        this.nombre = nombre;
        this.apellido = apellido;
        this.edad = edad;
    }


    // Obtener nombre
    public string ObtenerNombre()
    {
        return nombre;
    }

    // Establecer nombre
    public void EstablecerNombre(string nombre)
    {
        this.nombre = nombre;
    }

    // Obtener apellido
    public string ObtenerApellido()
    {
        return apellido;
    }

    // Establecer apellido
    public void EstablecerApellido(string apellido)
    {
        this.apellido = apellido;
    }

    // Obtener edad
    public int ObtenerEdad()
    {
        return edad;
    }

    // Establecer edad
    public void EstablecerEdad(int edad)
    {
        if (edad > 0)
        {
            this.edad = edad;
        }
        else
        {
            Console.WriteLine("La edad debe ser mayor a 0.");
        }
    }

    // Obtener genero
    public string ObtenerGenero()
    {
        return genero;
    }

    // Establecer genero
    public void EstablecerGenero(string genero)
    {
        this.genero = genero;
    }

    //imprimir la informacion de la persona
    public void ImprimirInformacion()
    {
        Console.WriteLine($"Nombre: {nombre} {apellido}");
        Console.WriteLine($"Edad: {edad}");
        Console.WriteLine($"Genero: {genero}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Crear la clase Persona
        Persona persona = new Persona("Dave", "Pozo", 30, "Masculino");

        // Mostrar la informacion inicial de la persona
        Console.WriteLine("Informacion inicial:");
        persona.ImprimirInformacion();

        // Modificar los atributos
        persona.EstablecerNombre("Maria");
        persona.EstablecerApellido("Pozo");
        persona.EstablecerEdad(25);
        persona.EstablecerGenero("Femenino");

        // Mostrar la informacion actualizada 
        Console.WriteLine("\nInformacion actualizada:");
        persona.ImprimirInformacion();
    }
}
