
class Conversao
{
    public static void Executar()
    {
        // Conversão implícita
    int notaAluno = 10;

    // Conversão explícita
    double notaAlunoDouble = notaAluno;
    int notaAlunoDoublecomoInt = (int)notaAlunoDouble;

    // Conversão de string para inteiro utilizando Convert

    string notaString = "10";

    int notaConvert = Convert.ToInt32(notaString);

    // Conversão utilizando Parse

    int notaParse = int.Parse(notaString);

if (int.TryParse(notaString, out int notaTryParse))
{
    
}
else
{
    System.Console.WriteLine("Número em formato inválido");
}

    }
}