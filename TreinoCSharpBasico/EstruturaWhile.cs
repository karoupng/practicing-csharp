using System.Diagnostics.Contracts;

class EstruturaWhile
{
    public static void Executar()
    {
        System.Console.WriteLine("Digite uma sequência de números separados por espaço.");

        var numerosTexto = Console.ReadLine();
        var numeros = numerosTexto.Split(' ');

        var contador = 0;
        while (contador < numerosTexto.Length)
        {
            System.Console.WriteLine(numeros[contador]);
            contador++;
        }
    }
}