/*
Verificar se um horário informado pelo usuário cai dentro da janela comercial (ex.: 08:00 às 18:00).
*/

using System.Globalization;

namespace CsharpExercises.Dates;

public static class Ex03_BusinessHours
{
    public static void Run()
    {
        Console.Write("Digite um horário (HH:mm): ");
        string? input = Console.ReadLine();
        TimeOnly hoursProvided = TimeOnly.Parse(input!);

        if(hoursProvided >= TimeOnly.Parse("8:00") && hoursProvided <= TimeOnly.Parse("18:00"))
        {
            Console.WriteLine("Está no horário de atendimento");
        }
        else
        {
            Console.WriteLine("Não está no horário de atendimento.");
        }       
    }
}