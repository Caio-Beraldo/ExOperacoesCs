

class Program
{
    static void Main()
    {
        // Ex.1
        Console.WriteLine("Digite um numero: ");
        string numero = Console.ReadLine();
        Console.WriteLine("Digite outro numero: ");
        string numero2 = Console.ReadLine();
        Console.WriteLine(" ");
        // Ex.2 TryParse
        if (int.TryParse(numero, out int a))
        {
            Console.WriteLine("Valido");

        }
        else
        {
            Console.WriteLine("Invalido");

        }
        Console.WriteLine(" ");
        if (int.TryParse(numero2, out int b))
        {
            Console.WriteLine("Valido");

        }
        else
        {
            Console.WriteLine("Invalido");

        }

        Console.WriteLine(" ");
        int soma = a + b;
        int subtracao = a - b;
        int multiplicacao = a * b;
        int divisao = a / b;
        Console.WriteLine("A soma é: " + soma);
        Console.WriteLine("A subtração é: " + subtracao);
        Console.WriteLine("A multiplicação é: " + multiplicacao);
        Console.WriteLine("A divisão é: " + divisao);
        Console.WriteLine(" ");
        // Ex.3
        Console.WriteLine(" ");
        double nota1 = 7;
        double nota2 = 7;
        double nota3 = 7.5;
        double media = (nota1 + nota2 + nota3) / 3;
        Console.WriteLine($"A media é: {media}");
        if (media >= 6)
        {
            Console.WriteLine("Aprovado");
        }
        else
        {
            Console.WriteLine("Reprovado");
        }
        // Ex.4
        Console.WriteLine(" ");
        int? ponto = null;
        int valor = ponto ?? 0;
        Console.WriteLine(valor);
        // Ex.5
        Console.WriteLine(" ");
        int mediaInt = (int)media;
        Console.WriteLine(mediaInt);

    }
}
