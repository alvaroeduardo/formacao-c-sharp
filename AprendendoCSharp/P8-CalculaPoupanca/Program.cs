using System;
using System.IO;

class Programa
{
    static void Main(string[] args)
    {
        char finalizacao;

        do
        {
            Console.WriteLine("Projeto 8 - Calcula Poupança");

            // rendimento de 0.5% (0.005) ao mês

            double investimento = 1000;
            int mes = 1;

            while (mes <= 12)
            {
                investimento = investimento + investimento * 0.005;
                Console.WriteLine(mes + " - " + investimento);

                mes += 1;
            }

            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine(i);
            }

            for(int linha = 0; linha <= 10; linha++)
            {
                for(int coluna = 0; coluna <= linha; coluna++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }

            Console.Write("Digite 0 para repetir e 1 para fechar: ");
            finalizacao = (char)Console.Read();
        } while (finalizacao != '1');
    }
}