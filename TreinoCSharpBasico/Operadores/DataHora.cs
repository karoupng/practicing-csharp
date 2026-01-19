using System;

class DataHora
{
    public static void Executar()
    {
        var now = DateTime.Now;
        var today = DateTime.Today;

        //três dias atrás, neste mesmo horário
        var threeDaysAgo = now.AddDays(-3);
        //três dias atrás, horário zerado, desde o início do dia
        //    var threeDaysAgo = today.AddDays(-3);







    }
}
