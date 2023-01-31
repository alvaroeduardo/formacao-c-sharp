using System;

class Programa
{
    static void Main(string[] args)
    {
        double salario = 1302.53;

        int salarioInteiro = (int)salario;

        Console.WriteLine(salarioInteiro);

        long x = 2000000000000000009;
        float altura = 1.62f;

        // Isto é um comentário - finalmente!
        Console.WriteLine(altura); // Da pra comentar na frente das parada também

        Console.WriteLine("Tecle enter para fechar...");
        Console.ReadLine();
    }
}