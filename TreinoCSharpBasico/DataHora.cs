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

        var sixMonthsLater = today.AddMonths(6);
        var twoYearsLater = today.AddYears(2);


        var shortDate = now.ToShortDateString();
        var longTime = now.ToLongTimeString();

        var date = now.Date;
        var day = now.Day;
        var month = now.Month;
        var year = now.Year;
        var hour = now.Hour;
        var minute = now.Minute;
        var second = now.Second;

        var hoje = DateTime.Now.DayOfWeek;

        if (hoje == DayOfWeek.Saturday || hoje == DayOfWeek.Sunday)
        {
            System.Console.WriteLine("É fim de semana!");
        }

        var diaDoAno = DateTime.Now.DayOfYear;










    }
}
