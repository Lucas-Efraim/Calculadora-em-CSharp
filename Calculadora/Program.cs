using System;

namespace Calculadora;

public static class Program
{
        public static void Main()
    {
        bool escEnter = true;
        while (escEnter)
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("=====================");
            Console.WriteLine("| Calculadora em C# |");
            Console.WriteLine("=====================");
            Console.WriteLine("Versão 1.2");
            Console.ResetColor();

            LinhaDivisoria();

            Console.Write("Digite o primeiro número: ");
            double primeiroNumero = LerNumero();

            Console.Write("Digite o segundo número: ");
            double segundoNumero = LerNumero();

            Console.WriteLine();

            Console.WriteLine("Qual operação você precisa realizar?");
            Console.WriteLine("[1] Adição");
            Console.WriteLine("[2] Subtração");
            Console.WriteLine("[3] Multiplicação");
            Console.WriteLine("[4] Divisão");
            Console.Write("Escolha o valor correspondente a operação: ");

            int operacao = LerOperacao();
            Console.ForegroundColor = ConsoleColor.Yellow;
            MostrarOperacao(operacao);
            Console.ResetColor();

            double? resultado = CalcularResultado(operacao, primeiroNumero, segundoNumero);
            if (resultado.HasValue)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                MostrarResultado(operacao, primeiroNumero, segundoNumero, resultado.Value);
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("[ERRO] Divisão por 0 não é permitida!");
                Console.ResetColor();
            }

            LinhaDivisoria();

            Console.WriteLine("Você deseja continuar ou encerrar programa?");
            Console.WriteLine("Pressione ENTER para continuar ou ESC para sair.");

            ConsoleKeyInfo tecla = Console.ReadKey(true);

            while ((tecla.Key != ConsoleKey.Enter) && (tecla.Key != ConsoleKey.Escape))
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("\n[ERRO] Tecla inválida!");
                Console.ResetColor();
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
    private static void LinhaDivisoria()
    {
        Console.WriteLine("\n-------------------------------------------------\n");
    }
    private static double LerNumero()
    {
        double numeroValido;
        while (!double.TryParse(Console.ReadLine(), out numeroValido))
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n[ERRO] Você digitou um caractere inválido!");
            Console.ResetColor();
            Console.Write("Digite o número novamente: ");
        }
        return numeroValido;
    }
    private static int LerOperacao()
    {
        int operacaoValida;
        while (!int.TryParse(Console.ReadLine(), out operacaoValida) || (operacaoValida < 1) || (operacaoValida > 4))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n[ERRO] Você escolheu uma opção inválida!");
                Console.ResetColor();
                Console.Write("Digite o valor da operação novamente: ");
            }
        return operacaoValida;
    }
    private static void MostrarOperacao (int operacao)
    {
        switch (operacao)
        {
            case 1:
                Console.WriteLine("\n[INFO] Operação escolhida: Adição");
                break;
            case 2:
                Console.WriteLine("\n[INFO] Operação escolhida: Subtração");
                break;
            case 3:
                Console.WriteLine("\n[INFO] Operação escolhida: Multiplicação");
                break;
            case 4:
                Console.WriteLine("\n[INFO] Operação escolhida: Divisão");
                break;
        }
    }
    private static double? CalcularResultado(int operacao, double primeiroNumero, double segundoNumero)
    {
        double? resultado;
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
                if (segundoNumero != 0)
                {
                    resultado = primeiroNumero / segundoNumero;
                }
                else
                {
                    resultado = null;
                }
                break;
            default:
                resultado = null;
                break;
        }
        return resultado;
    }
    private static void MostrarResultado (int operacao, double primeiroNumero, double segundoNumero, double resultado)
    {
        switch (operacao)
        {
            case 1:
                Console.WriteLine($"[RESULTADO] {primeiroNumero} + {segundoNumero} = {resultado:0.##}");
                break;
            case 2:
                Console.WriteLine($"[RESULTADO] {primeiroNumero} - {segundoNumero} = {resultado:0.##}");
                break;
            case 3:
                Console.WriteLine($"[RESULTADO] {primeiroNumero} * {segundoNumero} = {resultado:0.##}");
                break;
            case 4:
                Console.WriteLine($"[RESULTADO] {primeiroNumero} / {segundoNumero} = {resultado:0.##}");
                break;
        }
    }
}