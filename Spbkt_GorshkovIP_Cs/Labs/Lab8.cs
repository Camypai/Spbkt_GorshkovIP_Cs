using System.Linq;
using Spbkt_GorshkovIP_Cs.Extensions;
using Spbkt_GorshkovIP_Cs.Models;


namespace Spbkt_GorshkovIP_Cs.Labs
{
    /// <summary>
    /// Дан целочисленный массив A размера N.
    /// Переписать в новый целочисленный массив B все четные числа из исходного массива (в том же порядке) и вывести размер полученного массива B и его содержимое
    /// </summary>
    /// <author>
    /// Горшков Илья, ЗФ-95
    /// </author>
    public static class Lab8
    {
        public static readonly MenuItem MenuItem = new()
        {
            Id          = 8,
            Title       = "Лабараторная работа №8",
            Description = @"Дан целочисленный массив A размера N.
Переписать в новый целочисленный массив B все четные числа из исходного массива (в том же порядке) и вывести размер полученного массива B и его содержимое",
            ItemMethod  = Init
        };
        
        private static void Init()
        {
            var arr = Menu.Question("Введите случайную последовательность чисел через пробел").Split(' ').Select(q =>
                new
                {
                    succes = int.TryParse(q, out var i),
                    result = i
                }).Select(q => q.result).ToList();

            var result = arr.Where(q => q.IsEven());
            
            Menu.Print($"Результат выборки из массива получился ёмкостью {result.Count()}: {string.Join(", ", result)}");
            
            Menu.Pause();
        }
    }
}