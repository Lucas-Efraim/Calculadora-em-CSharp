using System;

namespace Calculadora;

public static class Program
{
    public static void Main()
    {
        Console.WriteLine("-----------------------");
        Console.WriteLine("| Calculadora Simples |");
        Console.WriteLine("-----------------------");
        Console.WriteLine("Versão 1.1");

        Console.WriteLine();
        Console.WriteLine();

        Console.Write("Digite o primeiro número: ");
        bool primeiroNumeroValido = double.TryParse(Console.ReadLine(), out double primeiroNumero);
        if (!primeiroNumeroValido)
        {
            Console.WriteLine("ERRO: Você digitou um caractere inválido!");
            Console.WriteLine("Encerrando o programa...");
            return;
        }

        Console.Write("Digite o segundo número: ");
        bool segundoNumeroValido = double.TryParse(Console.ReadLine(), out double segundoNumero);
        if (!segundoNumeroValido)
        {
            Console.WriteLine("ERRO: Você digitou um caractere inválido");
            Console.WriteLine("Encerrando o programa...");
            return;
        }

        Console.WriteLine();

        Console.WriteLine("Qual operação você precisa realizar?");
        Console.WriteLine("[1] Adição");
        Console.WriteLine("[2] Subtração");
        Console.WriteLine("[3] Multiplicação");
        Console.WriteLine("[4] Divisão");
        Console.Write("Escolha o valor correspondente a operação: ");
        bool operacaoValida = int.TryParse(Console.ReadLine(), out int operacao);
        if (!operacaoValida)
        {
            Console.WriteLine("ERRO: Você digitou um caractere inválido!");
            Console.WriteLine("Encerrando o programa...");
            return;
        }

        Console.WriteLine();
        Console.WriteLine();

        switch (operacao)
        {
            case 1:
                double resultadoAdicao = (primeiroNumero + segundoNumero);
                Console.WriteLine($"O resultado da soma entre {primeiroNumero} e {segundoNumero} é {resultadoAdicao}.");
                break;

            case 2:
                double resultadoSubtracao = (primeiroNumero - segundoNumero);
                Console.WriteLine($"O resultado da subtração entre {primeiroNumero} e {segundoNumero} é {resultadoSubtracao}.");
                break;

            case 3:
                double resultadoMultiplicacao = (primeiroNumero * segundoNumero);
                Console.WriteLine($"O resultado da multiplicação entre {primeiroNumero} e {segundoNumero} é {resultadoMultiplicacao}.");
                break;

            case 4:
                if (segundoNumero != 0)
                {
                    double resultadoDivisao = (primeiroNumero / segundoNumero);
                    Console.WriteLine($"O resultado da divisão entre {primeiroNumero} e {segundoNumero} é {resultadoDivisao}.");
                }

                else
                {
                    Console.WriteLine("ERRO: Não é possível realizar divisão por 0.");
                    Console.WriteLine("Encerrando o programa...");
                    return;
                }
                break;

            default:
                Console.WriteLine("ERRO: Opção inválida!");
                break;
        }
    }
}