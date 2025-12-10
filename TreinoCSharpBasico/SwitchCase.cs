class SwitchCase{
    public static void Executar()

    {
        Console.WriteLine("Seja bem-vindo a Empresa x");
        Console.WriteLine("Digite 1 - Contratação de plano");
        Console.WriteLine("Digite 2 - Reclamação de um serviço prestado");
        Console.WriteLine("Digite 3 - Segunda via de boleto");
        Console.WriteLine("Digite 4 - Sair");

        var opcao = Console.ReadLine();

        switch (opcao)
        {
            case "1":
                Console.WriteLine("Informações do plano novo");
                break;

            case "2":
                Console.WriteLine("Fale sobre sua reclamação");
                break;
             case "3":
                Console.WriteLine("Boleto enviado por e-mail!");
                break;
             case "4":
                Console.WriteLine("Até logo");
                break;

        }
        
    }
}