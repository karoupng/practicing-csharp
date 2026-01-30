class ArrayListas
{
    public static void Executar()
    {
       
        //inicializando matriz com dez valores

        var numbers = new int[] {0,1,2,3,4,5,6,7,8,9};
        //array vazio com capacidade para 10 elementos
        var numbersCopy = new int[10];

        for (var i = 0; i < numbers.Length; i++)
        {
            //pega o valor na posição "i" do array numbers e copia para a mesma posição "i" no array numberscopy
            numbersCopy[i] = numbers[i]; 
            var numbersString = "0 1 2 3 4 5 6 7 8 9";

            //Criando uma string com números separados por espaço 
            var numbersArray = numbersString.Split(' ');
            //quebra em múltiplas strings usando espaço como separador
            var numbersConverterString = Array.ConvertAll(numbersArray, Convert.ToInt32);
           
            //ConvertAll pega cada string do array e converte para int
            //Convert.ToInt32 é o método que faz a conversão de cada elemento 
        }

        Console.WriteLine(string.Join(',', numbersCopy));

    }
}