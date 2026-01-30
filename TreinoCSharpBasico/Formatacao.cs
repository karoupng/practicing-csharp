using System;



class Formatacao
{

    public static void Executar()
    {
        var now = DateTime.Now;
        System.Console.WriteLine("Formatos");

        var formats = new string[] { "d", "D", "f", "F", "g", "G", "m", "o", "r", "s", "t", "u", "U", "Y" };


        foreach (var format in formats)
        {
            Console.WriteLine("Data no formato {0}: {1}", format, now.ToString(format));

            // System.Console.WriteLine($" Data no formato {format} : {now.ToString(format)}");

        }

        System.Console.WriteLine("Diferentes maneiras de formatar manualmente.");
        System.Console.WriteLine($"Data no formato d: {now:d}");
        System.Console.WriteLine($"Data no Formato MM-dd-yyyy: {now:MM-dd-yyyy}");
        var dateFormat = now.ToString("MM-dd-yyyy");
        var dateFormatBr = now.ToString("dd/MM/yyyy HH:mm:ss");

        System.Console.WriteLine($"Data formatada MM-dd-yyyy{now:MM-dd-yyyy}");








}}

