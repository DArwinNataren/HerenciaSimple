/* Instituto Tecnológico Superior de Cintalapa
* Programacion Orientada a Objetos
* Profesor: Jorge Iván Bermúdez Rodríguez
* Alumno: Darwin Amaury Nataren Arellano
* Práctica: Herencia Simple Tarea
* Unidad: 3
 */
using System;
public class Animal
{
    public string Nombre { get; set; }
    public int Edad { get; set; }

    public Animal(string nombre, int edad)
    {
        Nombre = nombre;
        Edad = edad;
    }

    public void HacerSonido()
    {
        Console.WriteLine($"El { Nombre} hace un sonido y tiene {Edad} años de edad");
    }
}

public class Perro : Animal
{
    public string Raza;

    public Perro(string nombre, int edad, string raza) : base(nombre, edad)
    {
        Raza = raza;
    }

    public void Ladrar()
    {
        Console.WriteLine($"El {Nombre} ladra");
    }
}

public class Gato : Animal
{
    public bool Caza { get; set; }
    public string cAZADOR;

    public Gato(string nombre, int edad, bool CAZA) : base(nombre, edad)
    {
        Caza = CAZA;
    }

    public void Maullar()
    {
        Console.WriteLine($"{Nombre} maulla");
    }
}

class program 
{
    static void Main()
    {
        Perro p = new Perro("Solovino", 5, "Chihuahua");
        Gato g = new Gato("Luna", 7, true);

        p.Ladrar();
        g.Maullar();
    }


}