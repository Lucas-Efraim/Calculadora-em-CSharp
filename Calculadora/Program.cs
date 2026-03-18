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
        double primeiroNumero;
        while (!double.TryParse(Console.ReadLine(), out primeiroNumero))
        {
            Console.WriteLine("Você digitou um caractere inválido!");
            Console.Write("Digite o primeiro número: ");
        }

        Console.Write("Digite o segundo número: ");
        double segundoNumero;
        while (!double.TryParse(Console.ReadLine(), out segundoNumero))
        {
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
            Console.WriteLine("Você escolheu uma opção inválida!");
            Console.Write("Digite o valor da operação: ");
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
                }
                break;

        }
        
    }

}
