// See https://aka.ms/new-console-template for more information

Console.WriteLine("-------------------");
Console.WriteLine("Calculadora Simples");
Console.WriteLine("-------------------");
Console.WriteLine("Versão 1.0");

Console.WriteLine();
Console.WriteLine();

Console.WriteLine("Digite o primeiro número: ");
Double num1 = Double.Parse(Console.ReadLine());
Console.WriteLine("Digite o segundo número: ");
Double num2 = Double.Parse(Console.ReadLine());

Console.WriteLine();

Console.WriteLine("Qual operação você precisa realizar?");
Console.WriteLine("[1] Adição");
Console.WriteLine("[2] Subtração");
Console.WriteLine("[3] Multiplicação");
Console.WriteLine("[4] Divisão");
Console.WriteLine("Escolha o valor correspondente a operação");
Double operation = Double.Parse(Console.ReadLine());

Console.WriteLine();
Console.WriteLine();

if (operation == 1)
{
    Double ResultAd = (num1 + num2);
    Console.WriteLine($"O resultado da equação ({num1})+({num2}) é {ResultAd}.");
}
else if (operation == 2)
{
    Double ResultSub = (num1 - num2);
    Console.WriteLine($"O resultado da equação ({num1})-({num2}) é {ResultSub}.");
}
else if (operation == 3)
{
    Double ResultMult = (num1 * num2);
    Console.WriteLine($"O resultado da equação ({num1})*({num2}) é {ResultMult}.");
}
else if (operation == 4)
{
    if (num2 != 0)
    {
        Double ResultDiv = (num1 / num2);
        Console.WriteLine($"O resultado da equação ({num1})/({num2}) é {ResultDiv}.");
    }
    else
    {
        Console.Write("ERROR: Não é possível realizar divisão por 0.");
    }
}
else
{
    Console.WriteLine("ERROR: Você escolheu uma opção inválida.");
}