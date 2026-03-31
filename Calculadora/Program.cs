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

            double? resultado = null;

                switch (operacao)
                {
                    case 1:
                        resultado = Somar(primeiroNumero , segundoNumero);
                        break;

                    case 2:
                        resultado = Diminuir(primeiroNumero , segundoNumero);
                        break;

                    case 3:
                        resultado = Multiplicar(primeiroNumero , segundoNumero);
                        break;

                    case 4:
                        if (segundoNumero != 0)
                        {
                            resultado = Dividir(primeiroNumero , segundoNumero);
                        }
                        else
                        {
                            resultado = null;
                        }
                        break;
                }
            
            if (resultado.HasValue)
            {
                Console.WriteLine($"RESULTADO: {resultado.Value:0.##}");
            }
            else
            {
                Console.WriteLine("ERRO: Não é possível realizar divisão por 0");
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

    private static double Somar(double primeiroNumero , double segundoNumero)
    {
        double resultado = primeiroNumero + segundoNumero;
        return resultado;
    }

    private static double Diminuir(double primeiroNumero , double segundoNumero)
    {
        double resultado = primeiroNumero - segundoNumero;
        return resultado;
    }

    private static double Multiplicar(double primeiroNumero , double segundoNumero)
    {
        double resultado = primeiroNumero * segundoNumero;
        return resultado;
    }

    private static double Dividir(double primeiroNumero , double segundoNumero)
    {
        double resultado = primeiroNumero / segundoNumero;
        return resultado;
    }
}