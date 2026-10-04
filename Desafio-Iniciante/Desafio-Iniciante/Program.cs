using System;
using System.Globalization;

public class Program
{
    public static void Main(string[] args)
    {
        // DESAFIO 01
        int soma = 0;

        for (int i = 1; i <= 10; i++)
        {
            soma += i;
        }
        Console.WriteLine("A soma dos números de 1 a 10 é: " + soma);



        // DESAFIO 02
        Console.Write("Digite seu peso em kg: ");
        double peso = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.Write("Digite sua altura em metros: ");
        double altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        double imc = peso / (altura * altura);

        if (imc < 18.5)
        {
            Console.WriteLine("Você está abaixo do peso.");
        }
        else if (imc < 25)
        {
            Console.WriteLine("Você está com o peso normal.");
        }
        else if (imc < 30)
        {
            Console.WriteLine("Você está acima do peso.");
        }
        else
        {
            Console.WriteLine("Você está obeso.");
        }

        Console.WriteLine("O seu IMC é igual a: " + imc.ToString("F2"));



        // DESAFIO 03
        Console.Write("Digite o primeiro número");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite o primeiro número");
        double num2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite a operação desejada (+, -, *, /): ");
        string operacao = Console.ReadLine();

        if (operacao == "+")
        {
            Console.WriteLine("Resultado: " + (num1 + num2));
        }
        else if (operacao == "-")
        {
            Console.WriteLine("Resultado: " + (num1 - num2));
        }
        else if (operacao == "*")
        {
            Console.WriteLine("Resultado: " + (num1 * num2));
        }
        else if (operacao == "/")
        {
            if (num2 != 0)
            {
                Console.WriteLine("Resultado: " + (num1 / num2));
            }
            else
            {
                Console.WriteLine("Divisão inválida.");
            }
        }
        else
        {
            Console.WriteLine("Operação inválida.");
        }
    }
}