using System;

namespace Calculadora;

public static class Program
{
        public static void Main()
    {
        bool escEnter = true;
        while (escEnter)
        {
            DarkCyan();
            Console.WriteLine("=====================");
            Console.WriteLine("| Calculadora em C# |");
            Console.WriteLine("=====================");
            Console.WriteLine("Versão 1.3");
            ResetColor();

            LinhaDivisoria();

            Console.Write("Digite o primeiro número: ");
            double primeiroNumero = LerNumero("primeiro número");

            Console.Write("Digite o segundo número: ");
            double segundoNumero = LerNumero("segundo número");

            Console.WriteLine();

            Console.WriteLine("Qual operação você precisa realizar?");
            Console.WriteLine("[1] Adição");
            Console.WriteLine("[2] Subtração");
            Console.WriteLine("[3] Multiplicação");
            Console.WriteLine("[4] Divisão");
            Console.Write("Escolha o valor correspondente a operação: ");

            int operacao = LerOperacao();
            MostrarOperacao(operacao);

            double? resultado = CalcularResultado(operacao, primeiroNumero, segundoNumero);
            if (resultado.HasValue)
            {
                MostrarResultado(operacao, primeiroNumero, segundoNumero, resultado.Value);
            }
            else
            {
                DarkRed();
                Console.WriteLine("[ERRO] Divisão por 0 não é permitida!");
                ResetColor();
            }

            LinhaDivisoria();

            Console.WriteLine("Você deseja continuar ou encerrar programa?");
            Console.WriteLine("Pressione ENTER para continuar ou ESC para sair.");

            ConsoleKeyInfo tecla = Console.ReadKey(true);

            while ((tecla.Key != ConsoleKey.Enter) && (tecla.Key != ConsoleKey.Escape))
            {
                DarkRed();
                Console.WriteLine("\n[ERRO] Tecla inválida!");
                ResetColor();
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
    private static double LerNumero(string contexto)
    {
        double numeroValido;
        while (!double.TryParse(Console.ReadLine(), out numeroValido))
        {
            DarkRed();
            Console.WriteLine($"\n[ERRO] Você digitou um caractere inválido!");
            ResetColor();
            Console.Write($"Digite o {contexto} novamente: ");
        }
        return numeroValido;
    }
    private static int LerOperacao()
    {
        int operacaoValida;
        while (!int.TryParse(Console.ReadLine(), out operacaoValida) || (operacaoValida < 1) || (operacaoValida > 4))
            {
                DarkRed();
                Console.WriteLine("\n[ERRO] Você digitou uma opção inválida!");
                ResetColor();
                Console.Write("Digite o valor da operação novamente: ");
            }
        return operacaoValida;
    }
    private static void MostrarOperacao (int operacao)
    {
        DarkYellow();
        switch (operacao)
        {
            case 1:
                Console.WriteLine("\n[INFO] Operação escolhida: Adição\n");
                break;
            case 2:
                Console.WriteLine("\n[INFO] Operação escolhida: Subtração\n");
                break;
            case 3:
                Console.WriteLine("\n[INFO] Operação escolhida: Multiplicação\n");
                break;
            case 4:
                Console.WriteLine("\n[INFO] Operação escolhida: Divisão\n");
                break;
        }
        ResetColor();
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
        DarkGreen();
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
        ResetColor();
    }
    private static void DarkCyan ()
    {Console.ForegroundColor = ConsoleColor.DarkCyan;}
    private static void DarkRed ()
    {Console.ForegroundColor = ConsoleColor.DarkRed;}
    private static void DarkYellow ()
    {Console.ForegroundColor = ConsoleColor.DarkYellow;}
    private static void DarkGreen ()
    {Console.ForegroundColor = ConsoleColor.DarkGreen;}
    private static void ResetColor ()
    {Console.ResetColor();}
}