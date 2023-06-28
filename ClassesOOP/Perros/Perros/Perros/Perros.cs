using System;
using System.Collections.Generic;

public class Perrito
{
    public string name;
    public string barking;

    public void Bark(int times)
    {
        for (int i = 0; i < times; i++)
        {
            Console.WriteLine(barking);
        }
    }
}

public class Perros
{
    public static void Main(string[] args)
    {
        Perrito poncho = new Perrito();
        poncho.name = "Poncho";
        poncho.barking = "Woof!";

        Perrito juana = new Perrito();
        juana.name = "Juana";
        juana.barking = "Guau!";

        Perrito geremy = new Perrito();
        geremy.name = "Geremy";
        geremy.barking = "aaaaaaa";

        List<Perrito> perritus = new List<Perrito>(){ poncho, juana, geremy };

        Console.WriteLine("Escribe el nombre de un perrito:\n");
        string nombre = Console.ReadLine();

        Console.WriteLine("\n¿Cuántas veces quieres que ladre?\n");
        string veces = Console.ReadLine();

        int times = 0;


        if (nombre != null && int.TryParse(veces, out times))
        {
            bool encontrado = false;
            foreach (Perrito actual in perritus)
            {
                if (actual.name.Equals(nombre))
                {
                    actual.Bark(times);
                    encontrado = true;
                }
            }

            if (!encontrado) Console.WriteLine("No hay ningun perro con ese nombre.");
        }
        else
        {
            Console.WriteLine("Favor de seguir las indicaciones.");
        }

        Console.WriteLine("Gracias");
        Console.ReadLine();
    }
}
