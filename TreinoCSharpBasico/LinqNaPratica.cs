using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Xml;
public class LinqNaPratica
{
    public static void Executar()
    {
        //LINQ é uma ferramenta para filtrar, ordenar, transformar dados 
        #region LINQ
        var ListaEstudante = new List<Estudante>
            {
                new Estudante (1,"Karol", "09209738917", 100),
                new Estudante (2, "Hayala","82738172967" , 35),
                new Estudante (3, "Lucas", "03581695678", 85),
                new Estudante (4, "Mateus", "03859381734", 70),
                new Estudante (4, "Luis", "03853381734", 75),



            };
        #endregion LINQ

        //Tem algum item nessa lista ?
        var any = ListaEstudante.Any(l => l.Nota == 100);
        //Single gera exceção se existir mais de um com o mesmo id
        var single = ListaEstudante.Single(l => l.Id == 1);
        //Existe algum aluno com nota 0? Se não existir, retorna nulo, mas não gera exceção 
        var singleOrDefault = ListaEstudante.SingleOrDefault(l => l.Documento == "09209738917");

        //retorna o primeiro elemento Luis, não retorna os demais
        var first = ListaEstudante.First(l => l.NomeCompleto == "Luis");

        //Evita exceção, retorna o primeiro ou nulo

        var firstOrDefault = ListaEstudante.FirstOrDefault(l => l.Nota == 0);

        //ordena por ordem crescente
        var orderedByGrade = ListaEstudante.OrderBy(l => l.Nota);
        //ordena por ordem decrescente
        var orderedByGradeDescending = ListaEstudante.OrderByDescending(l => l.Nota);

        //Retornar alunos aprovados 
        var approvedEstudents = ListaEstudante.Where(l => l.Nota >= 70);

        //Selecionando estudantes e retornando apenas suas notas
        var grades = ListaEstudante.Select(l => l.Nota);

        // //enviando mensagem para todos os alunos
        // var phoneNumbers = ListaEstudante.SelectMany(l => l.PhoneNumbers);

        var sum = ListaEstudante.Sum(l => l.Nota);
        var min = ListaEstudante.Min(l => l.Nota);
        var max = ListaEstudante.Max(l => l.Nota);

        var count = ListaEstudante.Count;












    }
}

