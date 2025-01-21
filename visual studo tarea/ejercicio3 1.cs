using System;

class Persona
{
    // Atributos de la clase
    private string nombre;
    private int edad;
    private string dni;

    // Constructor de la clase
    public Persona(string nombre, int edad, string dni)
    {
        this.nombre = nombre;
        this.edad = edad;
        this.dni = dni;
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
            Console.WriteLine("Edad no válida.");
        }
    }

    // Obtener DNI
    public string ObtenerDni()
    {
        return dni;
    }

    // Establecer DNI
    public void EstablecerDni(string dni)
    {
        this.dni = dni;
    }

    // Método para mostrar los datos de la persona
    public void MostrarInformacion()
    {
        Console.WriteLine($"Nombre: {nombre}");
        Console.WriteLine($"Edad: {edad}");
        Console.WriteLine($"DNI: {dni}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Crear una clase persona
        Persona persona = new Persona("Dave Pozo", 30, "12345678A");

        // Mostrar informacion de la persona
        persona.MostrarInformacion();

        // Cambiar algunos valores utilizando los metodos
        persona.EstablecerNombre("Olmedo Pozo");
        persona.EstablecerEdad(35);

        // Mostrar la nueva informacion
        Console.WriteLine("\nDespues de actualizar:");
        persona.MostrarInformacion();
    }
}
