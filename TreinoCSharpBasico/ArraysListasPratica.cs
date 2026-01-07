using System;
using System.Collections.Generic;
using System.Linq.Expressions;

class ArraysListasPratica
{
    public static void Executar()
    {
        var list = new List<int> {0,1,2,3,4};
        var numbers = new int[] {0,1,2,3,4,5,6,7,8,9};

        //podemos inicializar uma lista a partir de uma array

        var listFromArray = new List<int>(numbers);

        //posso adicionar outros tipos além de inteiros
        list.Add(5); 
        //Para passar uma coleção como parâmetro
        list.AddRange(new List<int> {6,7});
        //Passar um array como parâmetro
        list.AddRange(new int[] {8,9});

        //método para contar quantos elementos há na lista
        var count = list.Count;
        //contém tal elemento?
        var contains14 = list.Contains(14);
        var contains = list.Contains(2);

        //método para reverter a ordem

        Console.WriteLine("Lista reversa: ");
        list.Reverse();
        //Foreach vai iterar em cada um dos elementos e vai permitir executar uma certa ação
        //"item" é um lambda, que significa : para cada item, execute Console.WriteLine passando esse item como argumento
        list.ForEach(item => Console.WriteLine(item));

        Console.WriteLine("Lista ordenada");
        list.Sort();
        list.ForEach(item => Console.WriteLine(item));

        list.Remove(4);
        //remover todos os elementos na condição a seguir
        list.RemoveAll(item => item > 5);

        list.Clear();








    }

    
}