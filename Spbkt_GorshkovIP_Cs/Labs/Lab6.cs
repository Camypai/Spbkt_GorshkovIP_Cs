using System.Linq;
using Spbkt_GorshkovIP_Cs.Models;


namespace Spbkt_GorshkovIP_Cs.Labs
{
    /// <summary>
    /// Ввести целое число N > 0. Последовательность вещественных чисел A(K) определяется следующим образом: A(0)=1/0!, A(K)=1/K!, K=1, 2, ...,N.
    /// Вывести сумму последовательности. Примечание К! — это К–факториал, обозначает произведение всех целых чисел от 1 до К
    /// </summary>
    /// <author>
    /// Горшков Илья, ЗФ-95
    /// </author>
    public static class Lab6
    {
        public static readonly MenuItem MenuItem = new()
        {
            Id    = 6,
            Title = "Лабараторная работа №6",
            Description =
                @"Ввести целое число N > 0. Последовательность вещественных чисел A(K) определяется следующим образом: A(0)=1/0!, A(K)=1/K!
Вывести сумму последовательности. Примечание К! — это К–факториал, обозначает произведение всех целых чисел от 1 до К",
            ItemMethod = Init
        };

        private static void Init()
        {
            var success = int.TryParse(Menu.Question("Введите целое положительное число"), out var number);

            if (!success)
            {
                Menu.Print("Введено некорректное значение, убедитесь, что введено целое положительное число");
                return;
            }

            
            var result = Enumerable.Range(1, number).Select(q =>
            {
                var aggregate = Enumerable.Range(1, q).Aggregate((a, n) => a * n);

                return 1d / aggregate;
            }).Sum();

            Menu.Print($"Сумма последовательности чисел до {number} равна {result}");

            Menu.Pause();
        }
    }
}