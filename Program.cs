// See https://aka.ms/new-console-template for more information

using Cantoneira;

using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Informe um numero: ");
        var v1 = Console.ReadLine();
        int.TryParse(v1, out int valor);
        Contar minhaInstancia = new Contar();
        minhaInstancia.ImprimirSequencia(valor);
    }
}

