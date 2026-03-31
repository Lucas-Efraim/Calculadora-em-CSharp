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

            if ((operacao == 4) && (segundoNumero == 0))
            {
                Console.WriteLine("ERRO: Não é possível realizar divisão por 0");
            }
            else
            {
                double resultado = Calculo(operacao , primeiroNumero , segundoNumero);
                Console.WriteLine($"RESULTADO: {resultado:F2}");
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

    public static double Calculo(int operacao , double primeiroNumero , double segundoNumero)
    {
        double resultado;
        switch (operacao)
        {
            case 1:
                resultado = primeiroNumero + segundoNumero;
                break;
            
            case 2:
                resultado = primeiroNumero - segundoNumero;
                break;
            
            case 3:
                resultado = primeiroNumero * segundoNumero;
                break;
            
            case 4:
                resultado = primeiroNumero / segundoNumero;
                break;

            default:
                resultado = 0;
                break;
        }

        return resultado;
    }
}