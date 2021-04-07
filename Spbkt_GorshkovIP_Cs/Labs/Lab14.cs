using System.Linq;
using Spbkt_GorshkovIP_Cs.Extensions;
using Spbkt_GorshkovIP_Cs.Models;


namespace Spbkt_GorshkovIP_Cs.Labs
{
    /// <summary>
    /// Создать метод, который возвращает минимальное значение в матрице NxM
    /// </summary>
    /// <author>
    /// Горшков Илья, ЗФ-95
    /// </author>
    public static class Lab14
    {
        public static readonly MenuItem MenuItem = new()
        {
            Id          = 14,
            Title       = "Лабараторная работа №14",
            Description = "Создать метод, который возвращает минимальное значение в матрице NxM",
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
            arr.FillRand(-9, 9);

            var result = arr.FindMin();
            
            Menu.Print($"Минимальное значение в матрице {arr.GetLength(0)}x{arr.GetLength(1)} равно {result}");
            
            Menu.Pause();
        }
    }
}