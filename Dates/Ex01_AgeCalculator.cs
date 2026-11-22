/*
Calcular a idade a partir da data de nascimento usando DateOnly e ParseExact.
*/

using System.Globalization;

namespace CsharpExercises.Dates;

public static class Ex01_AgeCalculator
{
    public static void Run()
    {
        Console.Write("Digite sua data de aniversário (dd/MM/yyyy): ");
        string? input = Console.ReadLine();

        DateOnly birthDate = DateOnly.ParseExact(
            input!,
            "dd/MM/yyyy",
            CultureInfo.GetCultureInfo("pt-BR")
        );

        DateOnly today = DateOnly.FromDateTime(DateTime.Today);

        int age = today.Year - birthDate.Year;

        if (today.Month < birthDate.Month || (today.Month == birthDate.Month && today.Day < birthDate.Day))
        {
            age--;
        }

        Console.WriteLine($"Você tem {age} anos de idade.");
    }
}