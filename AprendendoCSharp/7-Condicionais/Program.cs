using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 7 - Condicionais");

        int media = 6;

        if ( media >= 7)
        {
            Console.WriteLine("Aluno Aprovado.");

        } else if ( media < 7 && media > 5 )
        {
            Console.WriteLine("Aluno de recuperação.");
        } else
        {
            Console.WriteLine("Aluno reprovado.");
        }

        Console.WriteLine("Tecle enter para fechar...");
        Console.ReadLine();
    }
}