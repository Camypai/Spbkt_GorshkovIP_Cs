using System.Linq;
using Spbkt_GorshkovIP_Cs.Models;


namespace Spbkt_GorshkovIP_Cs.Labs
{
    /// <summary>
    /// Дан массив A. В массиве заменить все числа, которые больше данного числа, на среднее арифметическое всех чисел массива
    /// </summary>
    /// <author>
    /// Горшков Илья, ЗФ-95
    /// </author>
    public static class Lab7
    {
        public static readonly MenuItem MenuItem = new()
        {
            Id          = 7,
            Title       = "Лабараторная работа №7",
            Description = "Дан массив A. В массиве заменить все числа, которые больше данного числа, на среднее арифметическое всех чисел массива",
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
            var success = int.TryParse(Menu.Question("Введите пороговое число"), out var number);
            
            if (!success)
            {
                Menu.Print("Введено некорректное значение, убедитесь, что введено целое положительное число");
                return;
            }

            var result = arr.Select(q => q > number ? arr.Average() : q);
            
            Menu.Print($"Результат выполнения замены: {string.Join(", ", result)}");
            
            Menu.Pause();
        }
    }
}