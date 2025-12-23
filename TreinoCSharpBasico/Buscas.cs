class Buscas
{
    public static void Executar()
    {
        var paragrafo2 = "C# é uma linguagem moderna e versátil." + 
        "Com c# consigo desenvolver para Web, Desktop, Jogos," +
        "Mobile, entre outros.";

        var descobrirIndex = paragrafo2.IndexOf("C#");
        var ultimoIndex = paragrafo2.LastIndexOf("C#");
        var comecaCom = paragrafo2.StartsWith("C#");

        var posicao = paragrafo2.IndexOf("Mobile"); // encontra o índice onde "Mobile" começa
        var substringMobile = paragrafo2.Substring(posicao, 6); // Ao encontrar, extrai 6 caracteres

        var utilizandoContain = paragrafo2.Contains("jogos", StringComparison.OrdinalIgnoreCase);

        var containsExato = paragrafo2.Contains("Jogos");
        

        






        
    }
}