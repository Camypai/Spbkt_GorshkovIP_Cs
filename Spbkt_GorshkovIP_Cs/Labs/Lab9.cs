using System.Linq;
using Spbkt_GorshkovIP_Cs.Extensions;
using Spbkt_GorshkovIP_Cs.Models;


namespace Spbkt_GorshkovIP_Cs.Labs
{
    /// <summary>
    /// Написать программу, которая запрашивает размерность двумерного массива,
    /// заполняет его случайными числами от 5 до 9 и заменяет на 0 значения элементов массива с нечетной суммой индексов.
    /// </summary>
    /// <author>
    /// Горшков Илья, ЗФ-95
    /// </author>
    public static class Lab9
    {
        public static readonly MenuItem MenuItem = new()
        {
            Id          = 9,
            Title       = "Лабараторная работа №9",
            Description = @"Написать программу, которая запрашивает размерность двумерного массива,
заполняет его случайными числами от 5 до 9 и заменяет на 0 значения элементов массива с нечетной суммой индексов.",
            ItemMethod  = Init
        };
        
        private static void Init()
        {
            var rang = Menu.Question("Введите длину и ширину массива через пробел").Split(' ').Select(q =>
                new
                {
                    succes = int.TryParse(q, out var i),
                    result = i
                }).ToList();

            if (rang.Any(q => !q.succes) || rang.Count > 2)
            {
                Menu.Print("Введены некорректные значения или их больше 2");
                return;
            }

            var arr = new int[rang[0].result, rang[1].result];
            arr.FillRand(5, 9);
            arr.ReplaceBy((i, j) => !(i + j).IsEven());
            
            Menu.Print($"Результат выполнения замены:\n{arr.Show()}");
            
            Menu.Pause();
        }
    }
}