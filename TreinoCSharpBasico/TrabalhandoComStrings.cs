using System.ComponentModel.DataAnnotations;

class TrabalhandoComStrings
{
    public static void Executar()
    {
        var paragrafo = "   C# é uma linguagem moderna e versátil. " + 
        "Com c# consigo desenvolver para Web, Desktop, Jogos, " +
        "Mobile, entre outros. ";

        var tamanho = paragrafo.Length;

        var vazio = string.Empty;

        var maiuscula = paragrafo.ToUpper();

        var minuscula = paragrafo.ToLower();

        var frases = paragrafo.Split('.');

        var removerEspacoComeco = paragrafo.TrimStart();
        var removerEspacoFinal = paragrafo.TrimEnd();
        var removerTodoEspaco = paragrafo.Trim();

        var nuloOuVazio = string.IsNullOrWhiteSpace(paragrafo); // espaço em branco em toda a sua extensão

        var paragrafoCSharp = paragrafo.Replace("C#", "C-Sharp");

        Console.ReadKey();

        







        
    }

}