using System;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool cond = true;

            do
            {
                Menu();
                Console.WriteLine();
                Console.Write("Deseja continuar (s/n): ");
                char let = char.Parse(Console.ReadLine());
                if (let == 'n')
                {
                    cond = false;
                }

            } while (cond);

            Console.WriteLine();
            Console.WriteLine("Até a próxima!");
        }
        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Divisão");
            Console.WriteLine("4 - Multiplicação");
            Console.WriteLine("5 - Sair");

            Console.WriteLine();
            Console.Write("Selecione uma opção: ");
            short res = short.Parse(Console.ReadLine());

            switch (res)
            {
                case 1:
                    Soma();
                    break;
                case 2:
                    Subtracao();
                    break;
                case 3:
                    Divisao();
                    break;
                case 4:
                    Multiplicacao();
                    break;
                case 5:
                    Environment.Exit(0);
                    break;
            }
        }

        static void Soma()
        {
            Console.Clear();

            Console.Write("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.Write("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            float resultado = v1 + v2;
            Console.WriteLine();
            Console.WriteLine($"Resultado: {v1} + {v2} = {resultado}");
        }

        static void Subtracao()
        {
            Console.Clear();

            Console.Write("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.Write("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            float resultado = v1 - v2;
            Console.WriteLine();
            Console.WriteLine($"Resultado: {v1} - {v2} = {resultado}");
        }

        static void Divisao()
        {
            Console.Clear();

            Console.Write("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.Write("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            float resultado = v1 / v2;
            Console.WriteLine();
            Console.WriteLine($"Resultado: {v1} / {v2} = {resultado}");
        }

        static void Multiplicacao()
        {
            Console.Clear();

            Console.Write("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.Write("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            float resultado = v1 * v2;
            Console.WriteLine();
            Console.WriteLine($"Resultado: {v1} * {v2} = {resultado}");
        }
    }
}