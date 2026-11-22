/*
Data de nascimento e idade aproximada
Peça ao usuário (ou defina em variáveis) uma data de nascimento no formato dd/MM/yyyy usando DateOnly (ou DateTime.ParseExact). Calcule quantos anos a pessoa completou até a data atual (DateOnly.FromDateTime(DateTime.Today)).

Dica: Lembre-se de ajustar caso o aniversário ainda não tenha ocorrido no ano atual.
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