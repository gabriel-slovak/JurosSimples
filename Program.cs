using System;

namespace JurosSimples
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("---Juros Simples---");
            Console.ResetColor();
            Console.WriteLine();

            Console.WriteLine("Calcule o montante final de um investimento a juros simples, para isso insira...");

            Console.Write("Capital (R$): ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            double capital = Convert.ToDouble(Console.ReadLine());
            Console.ResetColor();

            Console.Write("Taxa de juros (%): ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            double taxa = Convert.ToDouble(Console.ReadLine());
            Console.ResetColor();

            Console.Write("Tempo (meses): ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            double tempo = Convert.ToDouble(Console.ReadLine());
            Console.ResetColor();

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            double juros = (capital * taxa/100 * tempo);
            Console.WriteLine($"Juros (R$) = {juros:N2}");
            double montante = (capital + juros);
            Console.WriteLine($"Montante (R$) = {montante:N2}");
            Console.ResetColor();
            Console.WriteLine();



        }
    }
}
