
public class Estudante
{
    #region Propriedades
    public int Id {get;set;}
    public string NomeCompleto{get;set;}
    public string Documento {get;set;}
    public int Nota {get;set;}

    #endregion

    //propriedade da classe em maiúsculo, parâmetros do construtor em minúsculo

    #region Construtores
    public Estudante(int id, string nomeCompleto, string documento, int nota)
    {
        Id = id;
        NomeCompleto = nomeCompleto;
        Documento = documento;
        Nota = nota;

    }

    #endregion




}