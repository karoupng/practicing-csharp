class OperadoresLogicos{
    public static void Executar()
    {

        // // Utilizando OR || 
        // System.Console.WriteLine(true || false);
        // System.Console.WriteLine(false || true);
        // System.Console.WriteLine(true || true);
        // System.Console.WriteLine(false || false);

        // // Utilizando AND && (Os dois precisam ser verdadeiro pra ser verdadeiro)

        // System.Console.WriteLine(true || false);
        // System.Console.WriteLine(false || true);
        // System.Console.WriteLine(true || true); //única verdadeira
        // System.Console.WriteLine(false || false);

        var minhaNota = 7;
        var ultimoAno = true;

        if (minhaNota >= 7 && ultimoAno)
        {
            System.Console.WriteLine("Aprovado e terminou o curso, parabéns!");
        }
        else
        {
            System.Console.WriteLine("Reprovado!");
        }
    }

}