class EstruturaFor
{
    public static void Executar()
    {
        System.Console.WriteLine("Digite uma sequência de números separados por espaço.");

        var numerosTexto = Console.ReadLine();
        var numeros = numerosTexto.Split(' ');

        for (int i = 0; i < numeros.Length; i++) //Enquanto i for menor que comprimento de ''numeros''
        {
            System.Console.WriteLine(numeros[i]); //sem i iria referenciar o array inteiro e não o elemento em si
        }

        //Split é como uma tesoura que corta onde tem espaço, sem adicionar o espaçamento, ele não sabe onde dividir.

    }
}