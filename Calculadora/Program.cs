using System;

namespace Calculadora;

public static class Program
{
    public static void Main()
    {
        bool escEnter = true;
        while (escEnter)
        {
            Console.WriteLine("---------------------");
            Console.WriteLine("| Calculadora em C# |");
            Console.WriteLine("---------------------");
            Console.WriteLine("Versão 1.2");

            Console.WriteLine();
            Console.WriteLine();

            Console.Write("Digite o primeiro número: ");
            double primeiroNumero;
            while (!double.TryParse(Console.ReadLine(), out primeiroNumero))
            {
                Console.WriteLine();
                Console.WriteLine("Você digitou um caractere inválido!");
                Console.Write("Digite o primeiro número: ");
            }

            Console.Write("Digite o segundo número: ");
            double segundoNumero;
            while (!double.TryParse(Console.ReadLine(), out segundoNumero))
            {
                Console.WriteLine();
                Console.WriteLine("Você digitou um caractere inválido!");
                Console.Write("Digite o segundo número: ");
            }

            Console.WriteLine();

            Console.WriteLine("Qual operação você precisa realizar?");
            Console.WriteLine("[1] Adição");
            Console.WriteLine("[2] Subtração");
            Console.WriteLine("[3] Multiplicação");
            Console.WriteLine("[4] Divisão");
            Console.Write("Escolha o valor correspondente a operação: ");
            int operacao;
            while (!int.TryParse(Console.ReadLine(), out operacao) || (operacao < 1) || (operacao > 4))
            {
                Console.WriteLine();
                Console.WriteLine("Você escolheu uma opção inválida!");
                Console.Write("Digite o valor da operação: ");
            }

            Console.WriteLine();

            switch (operacao)
            {
                case 1:
                    double resultadoAdicao = primeiroNumero + segundoNumero;
                    Console.WriteLine($"RESULTADO: {resultadoAdicao}");
                    break;

                case 2:
                    double resultadoSubtracao = primeiroNumero - segundoNumero;
                    Console.WriteLine($"RESULTADO: {resultadoSubtracao}");
                    break;

                case 3:
                    double resultadoMultiplicacao = primeiroNumero * segundoNumero;
                    Console.WriteLine($"RESULTADO: {resultadoMultiplicacao}");
                    break;

                case 4:
                    if (segundoNumero != 0)
                    {
                        double resultadoDivisao = primeiroNumero / segundoNumero;
                        Console.WriteLine($"RESULTADO: {resultadoDivisao}");
                    }

                    else
                    {
                        Console.WriteLine("ERRO: Não é possível realizar divisão por 0.");
                    }
                    break;

            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Você deseja continuar ou encerrar programa?");
            Console.WriteLine("Pressione ENTER para continuar ou ESC para sair.");
            ConsoleKeyInfo tecla;
            tecla = Console.ReadKey(true);
            while ((tecla.Key != ConsoleKey.Enter) && (tecla.Key != ConsoleKey.Escape))
            {
                Console.WriteLine();
                Console.WriteLine("Tecla inválida!");
                Console.WriteLine("Pressione ENTER para continuar ou ESC para sair.");
                tecla = Console.ReadKey(true);
            }
            if (tecla.Key == ConsoleKey.Enter)
            {
                Console.Clear();
                escEnter = true;
            }
            else
            {
                escEnter = false;
            }
        }
    }
}