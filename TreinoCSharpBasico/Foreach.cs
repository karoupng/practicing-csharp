class Foreach
{
    public static void Executar()
    {
        var numerosTexto = Console.ReadLine();
        var numeros = numerosTexto.Split(' ');

        foreach (var numero in numeros)
        {
            System.Console.WriteLine(numero);
        }

        Console.ReadKey();

    }
}