/*
Encontrar a próxima sexta-feira 13 e calcular quantos dias faltam.
*/

using System.Globalization;

namespace CsharpExercises.Dates;

public static class Ex02_NextFridayThe13th
{
    public static void Run()
    {
        Console.Write("Digite a data inicial (dd/MM/yyyy): ");
        string? input = Console.ReadLine();

        DateOnly initialDate = DateOnly.ParseExact(
            input!,
            "dd/MM/yyyy",
            CultureInfo.GetCultureInfo("pt-BR")
        );

        var days = 0;

        while(!(initialDate.DayOfWeek == DayOfWeek.Friday && initialDate.Day == 13))
        {
            initialDate = initialDate.AddDays(1);
            days++;
        }

        Console.WriteLine($"Data da próximo sexta-feira 13: {initialDate}");
        Console.WriteLine($"Dias faltantes para próxima sexta-feira 13: {days}");
    }
}