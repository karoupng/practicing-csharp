class ArrayListas
{
    public static void Executar()
    {
        var numbers = new int [] {0,1,2,3,4,5,6,7,8,9};
        //inicializando matriz com dez valores

        // int[] numbers = {0,1,2,3,4,5,6,7,8,9};

        // var numbers = new int [10]; 
        // //sem especificar valor, só com a capacidade

        var numbersCopy = new int[10];

        for (var i = 0; i < numbers.Length; i++)
        {
            numbersCopy[i] = numbers[i]; // copiando através do índice do colchete

            var numbersString = "0 1 2 3 4 5 6 7 8 9";
            var numbersArray = numbersString.Split(' ');
            var numbersConverterString = Array.ConvertAll(numbersArray, Convert.ToInt32);
            
            //Convert.ToInt32 converte o tipo de string para int, e ConvertAll converte todas strings de uma vez transformando em array
        }

        Console.WriteLine(numbersCopy[i]);

    }
}