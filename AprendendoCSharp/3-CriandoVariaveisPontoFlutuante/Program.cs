using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 3 - Variáveis Ponto Flutuante");

        double salario = 3000.10;
        int somatorio = 330;

        double soma = somatorio / salario;

        Console.WriteLine(soma);

        Console.WriteLine("Tecle enter para fechar...");
        Console.ReadLine();
    }
}